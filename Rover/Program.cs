using System;
using System.Collections.Generic;
namespace Rover
{

    class Program
    {
        static void Main(string[] args)
        {
            ObstacleGenerator generatorProva = new ObstacleGenerator(0);
            //ProvaAManoGeneratore generatorProva = new ProvaAManoGeneratore();
            Grid myProvaGrid = new Grid(0, 0, generatorProva);

            RoverMars myRover = new RoverMars();

            char commandToInsertInList = 'c';
            List<ICommand> userList = new List<ICommand>();

            Console.WriteLine("Welcome to the program that make you send command to rover in a list" + Environment.NewLine +
                "Digit F to insert a foreward command;" + Environment.NewLine +
                "Digit B to insert a backword command;" +
                Environment.NewLine +
                "Digit L to insert a left command;" + Environment.NewLine +
                "Digit R to insert a right command" + Environment.NewLine +
                "Digit E to send the complete list of command to the rover");

            while (commandToInsertInList != 'E')
            {
                try
                {
                    commandToInsertInList = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                catch (Exception e)
                {
                    commandToInsertInList = 'c';//not valid command-->defalut is the case
                }

                switch (commandToInsertInList)
                {
                    case 'F':
                        userList.Add(new Foreward());
                        Console.WriteLine("if you want insert another command or send the list");
                        break;
                    case 'B':
                        userList.Add(new Backward());
                        Console.WriteLine("if you want insert another command or send the list");
                        break;
                    case 'L':
                        userList.Add(new Left());
                        Console.WriteLine("if you want insert another command or send the list");
                        break;
                    case 'R':
                        userList.Add(new Right());
                        Console.WriteLine("if you want insert another command or send the list");
                        break;
                    case 'E':
                        Console.WriteLine("The following command have been sent to Rover");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (ICommand c in userList)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("The command is not valid");
                        break;
                }


            }
            Console.WriteLine("The following are the rover movement");
            Move.MoveRover(myRover, myProvaGrid, userList);
            Console.ReadLine();// only to not close terminal
        }



    }
}
