@echo off

cd pymindaffectBCI 

:: Step 1: Run UtopiaHub in a new terminal
start cmd /k python -m mindaffectBCI.decoder.startUtopiaHub

:: Step 2: Run the online BCI with the noisetag_bci.json config in a new terminal
start cmd /k python -m mindaffectBCI.online_bci

:: Inform the user that the process has started
echo "Both UtopiaHub and online BCI have been started in separate terminals."
pause
