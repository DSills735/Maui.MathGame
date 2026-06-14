using Maui.MathGame.Models;
using SQLite;

namespace Maui.MathGame.Data;

public class GameRepository
{
    string _dbPath;
    private SQLiteConnection _connection;

    public GameRepository(string dbPath)
    {
        _dbPath = dbPath;

    }

    public void Init()
    {
        _connection = new SQLiteConnection(_dbPath);
        _connection.CreateTable<Models.Game>();
    }

    public List<Game> GetAllGames()
    {
        Init();
        return _connection.Table<Game>().ToList();
    }

    public void Add(Game game)
    {
        _connection = new SQLiteConnection(_dbPath);
        _connection.Insert(game);
    }

    public void Delete(int id)
    {
        _connection = new SQLiteConnection(_dbPath);
        _connection.Delete(new { Id = id});
    }
}
