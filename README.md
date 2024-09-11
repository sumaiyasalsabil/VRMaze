SETTING UP EEG DEVICE

If using the OpenBCI Ganglion, you can follow the setup guide here: https://docs.openbci.com/GettingStarted/Boards/GanglionGS/
You won't be needing the OpenBCI GUI for this game but feel free to use it to make sure everything is running smoothly. 

Place electrodes as shown in the image (following the 10-20 system). As per: https://ieeexplore.ieee.org/document/8914280

Ensure EEG device is connected to computer. Note the port number.


STARTING THE BCI SYSTEM

Clone this repo: https://github.com/mindaffect/pymindaffectBCI

Move it to inside the VRMaze directory. 

In the terminal, navigate to the VRMaze directory. 

> cd pymindaffectBCI/mindaffectBCI

In the noisetag_bci.json file: edit board id (if using Ganglion then board id = 1) and serial port to whatever port you're using

Then navigate back to main VRMaze directory. 

> start_bci.bat

In the popup, select the noisetag_bci.json file.


STARTING THE GAME

Clone this repo. Then, open the game using Unity Hub. Connect VR device to computer and start the game on Unity. 

If using MetaQuest, ensure MetaQuest PC app is downloaded on computer. On VR device, connect using QuestLink. 


INSTRUCTIONS

Focus on the flashing arrow to navigate your way through the maze. Right and left turn 90 degrees in their respective directions. Straight goes forward. The arrow you choose turns green. Arrows disappear for 2 seconds after each choice.

