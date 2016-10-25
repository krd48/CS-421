using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command1
{
    public abstract class Command
    {
        public abstract void Execute(Actor actor);
    }

    public enum Direction { Left, Right, }

    public class MoveCommand : Command
    {
        public Direction Direction { get; set; }

        public override void Execute(Actor actor)
        {
            if (Direction == Direction.Left)
            {
                actor.Move(-1);
            }
            else if (Direction == Direction.Right)
            {
                actor.Move(1);
            }
        }
    }

    public class JumpCommand : Command
    {
        public override void Execute(Actor actor)
        {
            actor.Jump();
        }
    }

    public class AttackCommand : Command
    {
        public float Power { get; set; }

        public override void Execute(Actor actor)
        {
            actor.Attack(1);
        }
    }



}
