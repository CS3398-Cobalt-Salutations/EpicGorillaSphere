# Epic Gorilla Sphere

Epic Gorilla Sphere is the result of a semester-long team project for Fall Semester 2016 of Software Engineering (CS 3398) at Texas State University taught by Ted Lehr.
It served as a testbed for our knowledge of agile software development as well as a learning tool for the Unity game engine. 
Epic Gorilla Sphere is a 3D puzzle/adventure game in which you take control of a gorilla trapped in a transparent sphere.
Navigate through the various levels of teleporters, moving platforms, loops and twists, collecting as many bananas as possible and making it to the goal line at the end of every level. 

## Getting Started

### Playing the Game

To play the game, simply:

1. Click the green *Clone or download* button on [the project's GitHub page](https://github.com/CS3398-Cobalt-Salutations/EpicGorillaSphere).
2. Click *Download ZIP* and wait for the download to finish.
3. Navigate to the location of the downloaded ZIP file and extract the contents of the file.
4. Run the *FinalDemo.exe* executable. (Note: The game currently looks best at a resolution of 1024x768.)

### Editing the Project

In order to edit Epic Gorilla Sphere on your local machine, you will first need to download and install the latest version of [Unity 3D](https://unity3d.com/get-unity/download).
>As of writing, the most up-to-date version of Unity is 5.5.0, which was released on Nov. 30, 2016. However, Epic Gorilla Sphere's development was done on Unity 5.4.3.

0. Install [Unity 3D](https://unity3d.com/get-unity/download).
1. Once installed, clone or download the EpicGorillaSphere project from [the project's GitHub page](https://github.com/CS3398-Cobalt-Salutations/EpicGorillaSphere).
2. Launch Unity and select *Open* on the top right.
3. Navigate to the directory containing the EpicGorillaSphere folder (if you downloaded the ZIP, extract the contents of the ZIP file first).
4. Select the EpicGorillaSphere folder, and click *Select Folder*.
5. If a window pops up saying that the project version does not match the editor version, simply select *Continue* to update the project version to match the editor version.
6. Unity should take care of the rest and set up the Unity Editor to begin editing the project.

Additional help can be found [on Unity's website](https://unity3d.com/learn), where there are tutorials and documentation for Unity so that you can better understand how to edit this project.

## Deployment

To build the project, first follow the steps in the [**Editing the Project**](https://github.com/CS3398-Cobalt-Salutations/EpicGorillaSphere#editing-the-project) section to open the project in Unity. Then follow these steps:

0. Open the EpicGorillaSphere project in Unity.
1. Select *File > Build Settings* in the toolbar at the top of the Unity Editor.
2. In the Build Settings window, select the scenes that should be built. Make sure *OpeningScreen* and *Start Menu* are scenes 0 and 1, respectively.
3. Select the target end-user platform. (Note: We have only tested the game when deployed for Windows x86.)
4. Select *Build*, or *Build and Run* for quick testing.
5. Enter a name for the executable and select *Save*.

There will now be an executable file (e.g., "MyBuild.exe") and a corresponding data folder (e.g., "MyBuild_Data"). The end-user only needs these two items to run the game; Unity does not need to be installed in order to run the executable.
>Note: Building for different target platforms will probably create different types of files.

## Built With

* [Unity 3D](https://unity3d.com/) - The game engine used

## Contributing

We currently have no plans to update Epic Gorilla Sphere. If you wish to make changes, feel free to clone the project and make it your own!

## Authors

* **Dillon Lohr** - [djl70](https://github.com/djl70)
* **Mitchell LaRocca** - [mjl71](https://github.com/mjl71)
* **Stephen Phipps** - [s_p272 or DustyGreen64](https://github.com/DustyGreen64)
* **Natahn Hellrung** - [nmh46](https://github.com/nmh46)
* **Aaron Laurence** - [apl14](http://github.com/apl14)
* **Douglas Pitt** - [d_p113](https://github.com/dp113)
## License

This project does not have a license, meaning default copyright laws apply. More information can be found [here](https://help.github.com/articles/open-source-licensing/).

## Acknowledgments

* Unity for developing such a great game engine
* All of the creators of the assets we used for the game
* Ted Lehr for being a great professor
