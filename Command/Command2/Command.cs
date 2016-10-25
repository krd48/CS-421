using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command2
{
    public abstract class Command
    {
        public abstract void Execute(IList<string> lines);
    }

    public class AppendCommand : Command
    {
        public string Line { get; set; }

        public override void Execute(IList<string> lines)
        {
            lines.Add(Line);
        }
    }

    public class InsertCommand : Command
    {
        public string Line { get; set; }
        public int Position { get; set; }

        public override void Execute(IList<string> lines)
        {
            lines.Insert(Position, Line);
        }
    }

    public class EraseCommand : Command
    {
        public int Position { get; set; }

        public override void Execute(IList<string> lines)
        {
            lines.RemoveAt(Position);
        }
    }

}
