using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command1
{
    /// <summary>
    /// A 3-directional joystick with 1 button.
    /// </summary>
    public class Input
    {
        public bool Left { get; set; }
        public bool Right { get; set; }
        public bool Up { get; set; }

        public bool ButtonDown { get; set; }


        public IEnumerable<Command> GetCommands()
        {
            if (Left) yield return new MoveCommand { Direction = Direction.Left };
            if (Right) yield return new MoveCommand { Direction = Direction.Right };
            if (Up) yield return new JumpCommand { };
            if (ButtonDown) yield return new AttackCommand { };
            yield break;
        }
    }

}
