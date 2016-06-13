# Darkness and Light Unpacker
Unpacks .DRP game files from Darkness and Light SEA. Written in Visual Studio using C# .NET.


How to Use
-----------
1. Build the .exe or download it at http://mojo10.synology.me/~lemoney/files/dal-unpacker-v1.0.zip
2. Run it and click Choose Files or Choose Folder.
3. Select the .DRP files to unpack (multiple files supported), click Open.

List of Filetypes in DAL
----------------------------
Looks like the following file extensions are used in DAL game files:

*Note: .drg, .dra, .drc and .dre usually come together, like a bundle for 3D model and animations.*

- **.drg**: Unsure/proprietory, looks like a 3D model rig with bones.
- **.dra**: Unsure/proprietory, wild guess is animation because it's linked to .drg file most of the time, but not all the time. Could be a scripting file too.
- **.drc**: Unsure/proprietory, looks like 3D model, especially if it has no rig (lightning bolt, knives thrown by Ireine, item boxes).
- **.dre**: Unsure/proprietory, looks like particle effects because it has filenames like 'fire', 'light' or 'smoke'.
- **.drr**: Proprietory, DAL map file.
- **.drd**: Propreitory, DAL data file.
- **.ogg**: OGG sound files and music.
- **.dds**: Microsoft DDS Texture files.
