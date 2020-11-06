# PauseBlur

This project demonstrates enabling and disabling the depth of field (DOF) post processing settings as a pause effect.

Press the P key to toggle the pause effect.

## How to set up your scene

This script requires the Unity post processing package installed and configured as follows:

- open the package manager window and install the post processing package
- add a layer called "Post Processing"
- put your camera in this new layer
- add the Post-process Layer component
- add the Post-process Volume component
- tick `Is Global`
- click the `New` profile button
- add the `Depth Of Field` effect
- tick `Aperture` and set it to 0.1
- set the effect to `Off` (the script will turn it on)
- add the `PauseBlur` script
- drag the Post-process Volume component onto the `Volume` slot.
