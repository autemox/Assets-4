# Assets-4

Important notes:
 - Pixels Per Unit: 20
 - Height of Average Human: 2.1 units

##In-Game Screenshot
![Screenshot](ConceptArt/screenshot.jpg)

##Example Game Assets
![Example](ConceptArt/sample.jpg)

## How to modify an existing asset to make it '3d pixelated'

Bloat/Expand Mesh with "Scale Along Normals" in Blender
1. Load FBX to Blender.
2. Tab into Edit Mode.
3. Hit A to select all, or select just the region you want.
4.	Press Alt + S (“Scale Along Normals”: expands or contracts outward/inward along each face’s normal)

Check Dimensions
1. hit N and look under 'Dimensions'
2. use this X/Y/Z dimension to estimate the size of your texture .png
3. goal is 18 pixels per meter or smaller (aka 18 ppu)
4. the objects pixels should match the size of the character pixels in example scene
