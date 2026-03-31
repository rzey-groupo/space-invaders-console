namespace SpaceInvadersConsole;

/// <summary>
/// Handles collision detection for the game.
/// </summary>
public static class Collision
{
    /// <summary>
    /// Checks if a point is within a rectangular bounds.
    /// </summary>
    public static bool IsPointInBounds(int x, int y, int minX, int maxX, int minY, int maxY)
    {
        return x >= minX && x <= maxX && y >= minY && y <= maxY;
    }

    /// <summary>
    /// Checks if two rectangles overlap.
    /// </summary>
    public static bool AreRectanglesOverlapping(
        int rect1X, int rect1Y, int rect1Width, int rect1Height,
        int rect2X, int rect2Y, int rect2Width, int rect2Height)
    {
        return rect1X < rect2X + rect2Width &&
               rect1X + rect1Width > rect2X &&
               rect1Y < rect2Y + rect2Height &&
               rect1Y + rect1Height > rect2Y;
    }
}