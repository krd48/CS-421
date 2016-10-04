
class Game
{
    public Team Home { get; private set; }
    public Team Away { get; private set; }
    public List<inning> Innings;
    public Game(Team home, Team away, List<inning> innings)
    {
        Home = home;
        Away = away;
        List<inning> Innings = new List<inning>();
        Innings.AddRange(innings);
    }
}

class Team
{
    string name { get; private set; }
    List<player> Players;
    string location { get; private set; }
    public Team(string Name, List<player> players, string Location)
    {
        name = Name;
        List<player> Players = new List<player>();
        Players.AddRamge(players);
        location = Location;
    }
}

class player
{
    string name { get; private set; }
    DateTime birth { get; private set; }
    public player(string Name, DateTime Birth)
    {
        name = Name;
        birth = Birth;
    }
}

class innning
{
    int inning { get; private set; }
    int outHome { get; private set; }
    int outAway { get; private set; }
    public inning(int Inning, int OutHome, int OutAway)
    {
        inning = Inning;
        outHome = OutHome;
        outAway = OutAway;
    }
}

