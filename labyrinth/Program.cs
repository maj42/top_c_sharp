using System.Drawing;

namespace labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            int choice = 0;

            while (true) {
                
                Labyrinth labyrinth = new Labyrinth(size);
                Point start = new Point(0, 0);
                Point end = new Point(size - 1, size - 1);
                List<Point> path;
                
                if (choice == 5)
                {
                    labyrinth.Load();
                    start = new Point(0, 0);
                    end = new Point(size - 1, size - 1);
                    Console.WriteLine("Labyrinth loaded");
                    Console.ReadLine();
                }
                
                Console.WriteLine("\nChoose an algorythm for labyrinth solving:\n\n1. Breadth First Search (BFS)\n" +
                                  "2. A*\n3. Dijkstra\n\n4. Save the maze\n5. Load the maze\n\n6. Exit\n");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    choice = 0;
                }

                switch (choice)
                {
                    case 1:
                        if (!labyrinth.BFS(start, end, out path))
                        {
                            Console.WriteLine("Path not found");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (!labyrinth.AStar(start, end, out path))
                        {
                            Console.WriteLine("Path not found");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (!labyrinth.Dijkstra(start, end, out path))
                        {
                            Console.WriteLine("Path not found");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        labyrinth.Save();
                        Console.WriteLine("Labyrinth saved");
                        Console.ReadLine();
                        break;
                    case 5:
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
