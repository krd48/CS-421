using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Command2
{
    public class DocumentEx
    {
        public IList<Command> Commands { get; private set; }
        private int Position {get;set;}

        public DocumentEx()
        {
             Commands = new List<Command>();
             Position = 0;
        }

        public void Append(string line)
        {
            Commands.Insert(Position, new AppendCommand { Line = line });
            // Commands.Add(new AppendCommand { Line = line });
            Position++;
        }

        public void Insert(int pos, string line)
        {
            Commands.Insert(Position, new InsertCommand { Position = pos, Line = line });
            //Commands.Add(new InsertCommand { Position = pos, Line = line });
            Position++;
        }

        public void Erase(int pos)
        {
            Commands.Insert(Position, new EraseCommand { Position = pos });            
            //Commands.Add(new EraseCommand { Position = pos });
            Position++;
        }

        public void Undo()
        {
            Position--;
        }

        public void Redo()
        {
            Position++;
        }

        public override string ToString()
        {
            var lines = new List<string>();
            for (int i = 0; i < Commands.Count; i++)
            {
                Commands[i].Execute(lines);
            }

            var sb = new StringBuilder();
            foreach (string line in lines)
            {
                sb.Append(lines);
                sb.Append('\n');
            }

            return sb.ToString();
        }


    }
}
