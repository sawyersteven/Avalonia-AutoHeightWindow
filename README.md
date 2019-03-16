# Avalonia-AutoHeightWindow
Automatically scale window height to contents with Avalonia MVVM


As of the the creation of this repo, Avalonia's automatic window resizing does not work on X11 (osx, linux). This small example implements a system to re-measure during a `layoutupdated` event.

To use this in a project you need only to a copy of `AutoHeightWindow.cs` and inherit the class in your `Window` classes.
