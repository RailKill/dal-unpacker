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
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            fileChooser.ShowDialog();
        }

        /// <summary>
        /// The event when files are chosen in the file chooser.
        /// </summary>
        /// <param name="sender">Object which triggered this event which is a OpenFileDialog.</param>
        /// <param name="e">Event arguments.</param>
        private void fileChooser_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            string[] files = fileChooser.FileNames;

            // Unpack the contents of each file. Currently unpacks .DRP files with pure .DDS contents only.
            foreach (string file in files)
            {
                byte[] fileBytes = File.ReadAllBytes(file);
                ByteArraySearcher searcher = new ByteArraySearcher();
                Dictionary<int, string> positions = searcher.Locate(fileBytes); // Change this part for other formats too.
                int numberOfFiles = positions.Count;

                // Output path is currently fixed to the same place as the target file, will give user a choice in future.
                string outputPath = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file);
                Directory.CreateDirectory(outputPath); // Create the output directory.

                MessageBox.Show("Number of files detected = " + numberOfFiles);
                // Split bytes by known file positions.             
                List<int> list = positions.Keys.ToList();
                list.Sort();

                for (int i = 0; i < numberOfFiles; i++)
                {
                    int start = list[i];
                    int end = i == (numberOfFiles - 1) ? fileBytes.Length - start : list[i + 1] - start;
                        
                    File.WriteAllBytes(outputPath + Path.DirectorySeparatorChar + i + positions[list[i]], new ArraySegment<byte>(fileBytes, start, end).ToArray());
                }
            }
        }
    }
}
