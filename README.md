# Animated Sparse Voxel Octrees


## Introduction

Animated Sparse Voxel Octrees (ASVO) is an animation technique for sparse voxel octrees. It allows you to apply rigid transformations or skinning to voxel based 3D models.

You can find more detailed information on the [project page](http://bautembach.de/wordpress/?page_id=7).

This is the C# version of the project used for data structure- and algorithm design as well as prototyping purposes. Among other things, it contains a software rasterzier to render '.asvo' models.


## Dependencies

- [Microsoft XNA Game Studio 4.0](http://www.microsoft.com/en-gb/download/details.aspx?id=23714)
- [XNAnimation Library](http://xnanimation.codeplex.com/): This project contains a ported version of XNAnimation 0.7.0.0 BETA 3 to support XNA 4.0. Please use this copy as it contains custom changes and ASVO won't work with the official version.


## Usage

After launching the program you can rotate the camera by holding down the left mouse button and moving your mouse. The scroll wheel allows you to zoom in and out.


## License

- Author: Dennis Bautembach
- ASVO: [Creative Commons Attribution (CC BY 3.0)](http://creativecommons.org/licenses/by/3.0/deed.en_US): If you use any of the source code in your own code, please mention the original author's name in a comment or other appropriate place. ASVO itself uses code released under CC BY 3.0 and mentions the original authors in comments. Please maintain this information.
- XNAnimation Library: [Microsoft Public License (Ms-PL)](http://xnanimation.codeplex.com/license)
