
//Created once, changed when needed
class LineUp
{
    private Player[] order = new Player[9];
    private int next = -1;

    public Player Next() { return (++next) % 9; }

    public Player Batting1 { get; set; }
    public Player Batting2 { get; set; }
    public Player Batting3 { get; set; }
    public Player Batting4 { get; set; }
    public Player Batting5 { get; set; }
    public Player Batting6 { get; set; }
    public Player Batting7 { get; set; }
    public Player Batting8 { get; set; }
    public Player Batting9 { get; set; }

}
