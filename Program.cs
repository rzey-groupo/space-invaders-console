using SpaceInvadersConsole;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;

        const int GameWidth = 60;
        const int GameHeight = 20;
        const int FrameRate = 20;
        int frameCounter = 0;

        Player player = new Player(GameWidth, GameHeight);

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        player.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        player.MoveRight();
                        break;
                    case ConsoleKey.Escape:
                        Console.CursorVisible = true;
                        Console.Clear();
                        Console.WriteLine("Thanks for playing Space Invaders!");
                        return;
                }
            }

            frameCounter++;

            if (frameCounter % (60 / FrameRate) == 0)
            {
                Console.Clear();
                DrawBorders(GameWidth, GameHeight);
                player.Draw();
                Console.SetCursorPosition(1, GameHeight - 1);
                Console.Write("Arrow Keys/WASD: Move | ESC: Exit");
                frameCounter = 0;
            }

            Thread.Sleep(16);
        }
    }

    static void DrawBorders(int width, int height)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("┌" + new string('─', width - 2) + "┐");

        Console.SetCursorPosition(0, height - 2);
        Console.Write("└" + new string('─', width - 2) + "┘");

        for (int y = 1; y < height - 2; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("│");
            Console.SetCursorPosition(width - 1, y);
            Console.Write("│");
        }
    }
}