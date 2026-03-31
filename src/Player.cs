namespace SpaceInvadersConsole;

/// <summary>
/// Represents the player's spaceship.
/// </summary>
public class Player
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }

    private int _gameWidth;
    private int _gameHeight;
    private const int PlayerSpeed = 2;

    public Player(int gameWidth, int gameHeight)
    {
        _gameWidth = gameWidth;
        _gameHeight = gameHeight;
        X = gameWidth / 2;
        Y = gameHeight - 3;
        Symbol = '▲';
    }

    public void MoveLeft()
    {
        X = Math.Max(1, X - PlayerSpeed);
    }

    public void MoveRight()
    {
        X = Math.Min(_gameWidth - 2, X + PlayerSpeed);
    }

    public void Draw()
    {
        if (X > 0 && X < _gameWidth && Y > 0 && Y < _gameHeight)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }
}