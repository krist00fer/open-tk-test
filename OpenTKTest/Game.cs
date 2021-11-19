using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTKTest
{
    public class Game : GameWindow
    {
        public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings) { }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            var input = KeyboardState;
            if (input.IsKeyDown(Keys.Escape))
            {
                Environment.Exit(0);
            }

            base.OnUpdateFrame(args);
        }
    }
}
