# Darkness and Light Unpacker
Written in Visual Studio using C# .NET. Unpacks .drp game files from Darkness and Light SEA to reveal all individual .dds textures and .ogg sound files. This means all the textures *(floors, heroes, user interface, loading screens)*, icons and graphics used for maps and heroes can be retrieved. .dds texture files can be viewed using software like [IrfanView](https://www.irfanview.com). As for 3D models, it is most likely proprietary and it is not known what 3D software can open it. If anyone can read the 3D files, they can consider re-creating the game.

![dal-unpacker-screenshot](https://user-images.githubusercontent.com/11093103/136636938-d242c920-56b1-4a58-bd7d-bd457c24f5ac.jpg)


Prerequisites
-------------
You need to have .drp files available to be unpacked. These files are the game asset files for Asiasoft's Darkness and Light SEA (discontinued). The installer for the game client can be found in the [v1.0.0 release](https://github.com/RailKill/dal-unpacker/releases/tag/v1.0.0) under ```DarknessAndLightSEA_SetupOBeta.zip```. Once installed, the game folder will contain .drp files that you can use dal-unpacker to extract. Read the release notes if you want to know more about how to be able to start the game client.

How to Use
-----------
1. Build the .exe or download it from the [Releases section](https://github.com/RailKill/dal-unpacker/releases).
2. Run ```dal-unpacker.exe``` and tick the checkbox, then click Browse and choose a target location to unpack the game files to.
3. Click Choose Files if unpacking individual .drp files, or Choose Folder for a folder containing .drp files.
4. After a file or folder is selected, the unpacking process will begin. If many files are selected, it may appear to freeze but is actually running.
5. When it is done, it will output to the Message Log. You can now go to the unpacked location to find the files.

List of Filetypes in DAL
----------------------------
Looks like the following file extensions are used in DAL game files:

*Note: .drg, .dra, .drc and .dre usually come together, like a bundle for 3D model and animations.*

- **.drg**: Unsure/proprietory, looks like a 3D model rig with bones.
- **.dra**: Unsure/proprietory, wild guess is animation because it's linked to .drg file most of the time, but not all the time. Could be a scripting file too.
- **.drc**: Unsure/proprietory, looks like 3D model, especially if it has no rig (lightning bolt, knives thrown by Ireine, item boxes).
- **.dre**: Unsure/proprietory, looks like particle effects because it has filenames like 'fire', 'light' or 'smoke'.
- **.drr**: Proprietory, DAL map file.
- **.drd**: Proprietory, DAL data file.
- **.ogg**: OGG sound files and music.
- **.dds**: Microsoft DDS Texture files.
