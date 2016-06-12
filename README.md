# Darkness and Light Unpacker
Unpacks .DRP game files from Darkness and Light SEA. Written in Visual Studio using C# .NET.

Currently only works for .DRP files with pure .DDS contents only. It is not able to deal with others such as 3D models or sound files
at this stage. Will work on it though.


How to Use
-----------
1. Build the .exe, download not available yet.
2. Run it and click Choose Files.
3. Select the .DRP files to unpack (multiple files supported), click Open.
4. The files will be unpacked in the same location.

List of Filetypes in DAL
----------------------------
Looks like the following file extensions are used in DAL game files:

- **.drg**: Unsure/proprietory, looks like 3D model. DRG, DRA and DRC are almost always linked and have the same name.
- **.dra**: Unsure/proprietory, wild guess is animation because it's linked to .drg file most of the time, but not all the time.
- **.drc**: Unsure/proprietory, looks like some 2D/3D element used for effects (lightning bolt, knives thrown by Ireine, item boxes).
- **.dre**: Unsure/proprietory, looks like particle effects because it has filenames like 'fire', 'light' or 'smoke'.
- **.drr**: Proprietory, DAL map file.
- **.drd**: Propreitory, DAL data file.
- **.ogg**: OGG sound files and music.
- **.dds**: Microsoft DDS Texture files.
