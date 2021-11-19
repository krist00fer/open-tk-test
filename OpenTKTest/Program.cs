// See https://aka.ms/new-console-template for more information
using OpenTK.Windowing.Desktop;
using OpenTKTest;

Console.WriteLine("Hello, World!");


var gameWindowSettings = new GameWindowSettings();
var nativeWindowSettings = new NativeWindowSettings();

using var game = new Game(gameWindowSettings, nativeWindowSettings);

//Run takes a double, which is how many frames per second it should strive to reach.
//You can leave that out and it'll just update as fast as the hardware will allow it.
game.Run();
