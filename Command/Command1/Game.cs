using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command1
{
    public class Game
    {
        public bool GameOver { get; set; } = false;

        public Input Input { get; set; } = new Input();

        public Player Player { get; set; }

        public BadGuy Enemy { get; set; }


        public void Run()
        {
            Player = new Player();
            Enemy = new BadGuy();

            while (!GameOver)
            {
                if (Input.Left)
                {
                    Player.Move(-1);
                }
                if (Input.Right)
                {
                    Player.Move(1);
                }
                if (Input.Up)
                {
                    Player.Jump();
                }
                if (Input.ButtonDown)
                {
                    Player.Attack(1);
                }

                // TODO: What about enemy?
            }



            //while (!GameOver)
            //{
            //    // Handle the player input
            //    foreach (var command in Input.GetCommands())
            //    {
            //        command.Execute(Player);
            //    }

            //    // Then the enemy reponds.
            //    foreach (var command in Enemy.AI.GetCommands(Player))
            //    {
            //        command.Execute(Enemy);
            //    }
            //}


        }
    }
}
