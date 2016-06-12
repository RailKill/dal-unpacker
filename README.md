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

- **.drg**: Unsure/proprietory, looks like 3D model.
- **.dra**: Unsure/proprietory, wild guess is animation because it's linked to .drg file most of the time, but not all the time.
- **.drc**: Unsure/proprietory, don't know what is this - some heroes have but some don't, quite inconsistent.
- **.dre**: Unsure/proprietory, looks like particle effects because it has filenames like 'fire', 'light' or 'smoke'.
- **.ogg**: OGG sound files and music.
- **.dds**: Microsoft DDS Texture files.
