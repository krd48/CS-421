
class Game
{
    public Team home { get; set; }
    public Team away { get; set; }
};
class Team: Game
{
    public string TeamName { get; set; }
    public List<Player> players { get; private set; }
};
class TeamStats: Team
{
    public int runs { get; private set; }
    public int hits { get; private set; }
    public int errors { get; private set; }
    public int strikeouts { get; private set; }
    public int baseOnBalls { get; private set; }
};
class Player : Team
{
    public string playerName { get; private set; }
    public string position { get; private set; }
};
class Inning: Game
{
    public int outs { get; private set; }
    public string[] runnersOn { get; private set; } //A name could show whether someone was on base, otherwise an empty string, runnersOn[0] is home, etc.
};
class AtBat: Inning
{
    public int strikes { get; private set; }
    public int balls { get; private set; }
    public int pitches { get; private set; }
};
class Program
{
    static void Main(string[] args)
    {
        Game test = new Game();
        test.away = new Team();
        test.home = new Team();
        test.away.TeamName = "Kansas City Royals";
        test.home.TeamName = "Cleveland Indians";
        Console.WriteLine("The {0} will be playing the {1} as the away team.", test.away.TeamName, test.home.TeamName);
    }
}
