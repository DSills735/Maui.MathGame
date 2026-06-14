
namespace Maui.MathGame.Models;

public class Game
{
    public int Id { get; set; }
    public GameOperation Type { get; set; }
    public int Score { get; set; }
    public DateTime Dateplayed { get; set; }
}

public enum GameOperation
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}