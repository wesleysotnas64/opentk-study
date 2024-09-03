using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK_HelloWorld;

var nativeWindowSettings = new NativeWindowSettings()
{
    ClientSize = new Vector2i(800, 600),
    Title = "LearnOpenTK - Creating a Window",
};

using(var game = new Game(GameWindowSettings.Default, nativeWindowSettings))
{
    game.Run();
}