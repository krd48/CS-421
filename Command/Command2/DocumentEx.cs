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

        public DocumentEx()
        {
             Commands = new List<Command>();
        }

        public void Append(string line)
        {
            Commands.Add(new AppendCommand { Line = line });
        }

        public void Insert(int pos, string line)
        {
            Commands.Add(new InsertCommand { Position = pos, Line = line });
        }

        public void Erase(int pos)
        {
            Commands.Add(new EraseCommand { Position = pos });
        }

        public void Undo()
        {
        }

        public void Redo()
        {
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
