using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace dal_unpacker
{
    /// <summary>
    /// The main Windows Form UI to use this unpacker.
    /// It basically loads a .DRP file and finds a pattern that marks the start of each file inside the package, then splits them apart.
    /// </summary>
    public partial class UnpackerForm : Form
    {
        /// <summary>
        /// Default constructor, initializes and shows the UI.
        /// </summary>
        public UnpackerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The event when the 'Choose Files' button is clicked.
        /// </summary>
        /// <param name="sender">Object which triggered this event which is a Button.</param>
        /// <param name="e">Event arguments.</param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (sender == btnChooseFile)
            {
                // Choose individual file.
                fileChooser.ShowDialog();
            }
            else
            {
                // Choose a folder containing many files.
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    this.Activate();
                    // Get all .drp files in the current directory.
                    Unpack(Directory.GetFiles(folderBrowser.SelectedPath, "*.drp"));
                }
            }
        }

        /// <summary>
        /// The event when files are chosen in the file chooser.
        /// </summary>
        /// <param name="sender">Object which triggered this event which is a OpenFileDialog.</param>
        /// <param name="e">Event arguments.</param>
        private void fileChooser_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            Unpack(fileChooser.FileNames);
        }

        /// <summary>
        /// Unpack the contents of each .DRP file.
        /// </summary>
        /// <param name="files">List of filepaths.</param>
        private void Unpack(string[] files)
        {
            txtMessageLog.AppendText("[" + DateTime.Now + "] Starting... \r\n");
            // Check if user wants to unpack files to a specific directory.
            bool outputToDirectory = chkOutputDir.Checked && !string.IsNullOrWhiteSpace(txtOutputDir.Text);

            foreach (string file in files)
            {
                byte[] fileBytes = File.ReadAllBytes(file);
                ByteArraySearcher searcher = new ByteArraySearcher();
                Dictionary<int, string> positions = searcher.Locate(fileBytes);
                int numberOfFiles = positions.Count;

                // If an output path is desired, files will be unpacked there. Otherwise, it will be unpacked in the same location as the selected files.
                string outputPath = outputToDirectory ? txtOutputDir.Text : Path.GetDirectoryName(file);
                outputPath += Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file);
                Directory.CreateDirectory(outputPath); // Create the output directory.

                // Split bytes by known file positions.             
                List<int> list = positions.Keys.ToList();
                list.Sort();

                for (int i = 0; i < numberOfFiles; i++)
                {
                    int start = list[i];
                    int end = i == (numberOfFiles - 1) ? fileBytes.Length - start : list[i + 1] - start;

                    File.WriteAllBytes(outputPath + Path.DirectorySeparatorChar + i + positions[list[i]], new ArraySegment<byte>(fileBytes, start, end).ToArray());
                }

                // Log message.
                txtMessageLog.AppendText(Path.GetFileName(file) + ": " + numberOfFiles + " files unpacked. \r\n");
            }
            txtMessageLog.AppendText("Finished. \r\n");
            txtMessageLog.AppendText("=================== \r\n");
        }

        /// <summary>
        /// Select output directory for files to be unpacked to.
        /// </summary>
        /// <param name="sender">Object which triggered this event which is a Button.</param>
        /// <param name="e">Event arguments.</param>
        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            if (outputBrowser.ShowDialog() == DialogResult.OK)
            {
                this.Activate();
                chkOutputDir.Checked = true; // If a folder is selected, automatically check the output box.
                txtOutputDir.Text = outputBrowser.SelectedPath; // Show selected path to output to.
            }
        }
    }
}
