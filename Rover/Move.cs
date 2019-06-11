using System;
using System.Collections.Generic;
namespace Rover
{
    public class Move
    {
        public static void MoveRover(IRover rover, IGrid grid, List<ICommand> commands)
        {
            Console.WriteLine("Starting rover position "+rover.Position.X.ToString()+" "+rover.Position.Y.ToString()+" "+"starting rover direction "+
                rover.Direction.ToString());
            foreach (Command c in commands)
            {
                if (rover.Direction == 'N')//CONSIDER TO UPPER AND TO LOWER CASE IN THE CHAR
                {
                    c.MoveFromNordDirection(rover, grid);
                }
                else if (rover.Direction == 'S')
                {
                    c.MoveFromSudDirection(rover, grid);
                }
                else if (rover.Direction == 'O')
                {
                    c.MoveFromOvestDirection(rover, grid);
                }
                else if (rover.Direction == 'E')
                {
                    c.MoveFromEstDirection(rover, grid);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("New rover position "+rover.Position.X.ToString() + " " + rover.Position.Y.ToString()+
                    " new rover direction: "+rover.Direction.ToString());
                Console.ResetColor();
            }
        }
    }
        }
