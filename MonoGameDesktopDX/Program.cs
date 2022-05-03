using System;

namespace MonoGameDesktopDX
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Game1 game = new Game1();
            game.Run();
        }
    }
}