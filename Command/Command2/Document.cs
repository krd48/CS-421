using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Command2
{
    public class Document
    {
        private List<string> Lines { get; set; }
        private Stack<string> RedoList { get; set; }

        public Document()
        {
            Lines = new List<string>();
        }

        public void Append(string line)
        {
            Lines.Add(line);
        }

        public void Undo()
        {
            if (Lines.Count > 0)
            {
                var str = Lines.Last();
                Lines.RemoveAt(Lines.Count - 1);
                RedoList.Push(str);
            }
            else
            {
                throw new Exception("Can't undo");
            }
        }

        public void Redo()
        {
            if (RedoList.Count > 0)
            {
                var str = RedoList.Pop();
                Lines.Add(str);
            }
            else
            {
                throw new Exception("Can't redo");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Lines.Count; i++)
            {
                sb.Append(Lines[i]);
                sb.Append('\n');
            }

            return sb.ToString();
        }
    }
}
