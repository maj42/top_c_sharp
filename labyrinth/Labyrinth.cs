using System.Data;
using System.Drawing;
using System.Text;

namespace labyrinth
{
    public class Labyrinth
    {
        public Cell[,] lab;
        public int size;

        public Labyrinth(int size)
        {
            lab = new Cell[size, size];
            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    lab[row, col] = new Cell();
                }
            }
            this.size = size;
            makePath();
        }

        public Labyrinth(string[] strs)
        {
            int size = Convert.ToInt32(strs[0]);
            lab = new Cell[size, size];
            int cnt = 0;
            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    lab[row, col] = new Cell();
                    int num = Convert.ToInt32(strs[1][cnt++]);
                    lab[row, col].Left = (num & 1) == 1;
                    lab[row, col].Up = ((num >> 1) & 1) == 1;
                    lab[row, col].Right = ((num >> 2) & 1) == 1;
                    lab[row, col].Down = ((num >> 3) & 1) == 1;
                }
            }
            this.size = size;
            makePath();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    result.Append(lab[row, col].TopLine);
                }
                result.AppendLine();
                for (int col = 0; col < size; ++col)
                {
                    result.Append(lab[row, col].MidLine);
                }
                result.AppendLine();
                for (int col = 0; col < size; ++col)
                {
                    result.Append(lab[row, col].BotLine);
                }
                result.AppendLine();
            }
            return result.ToString();
        }

        private void makePath()
        {
            bool[,] visited = new bool[size, size];

            DFS(0, 0, visited, new Random());
        }

        // DFS for maze initialization
        private void DFS(int row, int col, bool[,] visited, Random random)
        {
            visited[row, col] = true;
            List<(int, int, string)> directions = new List<(int, int, string)>
        {
            (-1, 0, "up"),
            (1, 0, "down"),
            (0, -1, "left"),
            (0, 1, "right")
        };

            directions = directions.OrderBy(x => random.Next()).ToList();

            foreach (var (dRow, dCol, direction) in directions)
            {
                int newRow = row + dRow;
                int newCol = col + dCol;

                if (newRow >= 0 && newRow < size && newCol >= 0 && newCol < size && !visited[newRow, newCol])
                {
                    if (direction == "up")
                    {
                        lab[row, col].Up = true;
                        lab[newRow, newCol].Down = true;
                    }
                    else if (direction == "down")
                    {
                        lab[row, col].Down = true;
                        lab[newRow, newCol].Up = true;
                    }
                    else if (direction == "left")
                    {
                        lab[row, col].Left = true;
                        lab[newRow, newCol].Right = true;
                    }
                    else if (direction == "right")
                    {
                        lab[row, col].Right = true;
                        lab[newRow, newCol].Left = true;
                    }

                    DFS(newRow, newCol, visited, random);
                }
            }
        }

        public bool BFS(Point start, Point end, out List<Point> path)
        {
            path = new List<Point>();
            Queue<Point> queue = new Queue<Point>();
            bool[,] visited = new bool[size, size];
            Dictionary<Point, Point> cameFrom = new Dictionary<Point, Point>();

            queue.Enqueue(start);
            visited[start.Y, start.X] = true;

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                lab[current.Y, current.X].MidLine = lab[current.Y, current.X].MidLine[0] + " . " + lab[current.Y, current.X].MidLine[4];
                Console.WriteLine(this);
                Thread.Sleep(200);
                Console.Clear();

                if (current == end)
                {
                    ReconstructPath(cameFrom, start, end, path);
                    return true;
                }

                foreach (var neighbor in GetNeighbors(current))
                {
                    if (!visited[neighbor.Y, neighbor.X])
                    {
                        visited[neighbor.Y, neighbor.X] = true;
                        queue.Enqueue(neighbor);
                        cameFrom[neighbor] = current;
                    }
                }
            }
            return false;
        }

        public bool AStar(Point start, Point end, out List<Point> path)
        {
            path = new List<Point>();

            // Очередь с приоритетом (узел, приоритет)
            PriorityQueue<Point, int> openSet = new PriorityQueue<Point, int>();
            openSet.Enqueue(start, 0);

            // Хранит предыдущие точки для восстановления пути
            Dictionary<Point, Point> cameFrom = new Dictionary<Point, Point>();

            // Стоимость пути от старта до текущего узла
            Dictionary<Point, int> gScore = new Dictionary<Point, int>();
            gScore[start] = 0;

            // Оценка стоимости пути от текущего узла до цели (gScore + эвристика)
            Dictionary<Point, int> fScore = new Dictionary<Point, int>();
            fScore[start] = Heuristic(start, end);

            while (openSet.Count > 0)
            {
                Point current = openSet.Dequeue();

                if (current == end)
                {
                    ReconstructPath(cameFrom, start, end, path);
                    return true;
                }

                foreach (var neighbor in GetNeighbors(current))
                {
                    int tentativeGScore = gScore[current] + 1;

                    if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeGScore;
                        fScore[neighbor] = gScore[neighbor] + Heuristic(neighbor, end);

                        lab[current.Y, current.X].MidLine = lab[current.Y, current.X].MidLine[0] + " . " + lab[current.Y, current.X].MidLine[4];
                        Console.WriteLine(this);
                        Thread.Sleep(200);
                        Console.Clear();

                        if (!openSet.UnorderedItems.Any(x => x.Element == neighbor))
                        {
                            openSet.Enqueue(neighbor, fScore[neighbor]);
                        }
                    }
                }
            }
            return false;
        }

        public bool Dijkstra(Point start, Point end, out List<Point> path)
        {
            path = new List<Point>();

            // Очередь с приоритетом (узел, стоимость пути)
            PriorityQueue<Point, int> openSet = new PriorityQueue<Point, int>();
            openSet.Enqueue(start, 0);

            // Хранит предыдущие точки для восстановления пути
            Dictionary<Point, Point> cameFrom = new Dictionary<Point, Point>();

            // Стоимость пути от старта до текущего узла
            Dictionary<Point, int> costSoFar = new Dictionary<Point, int>();
            costSoFar[start] = 0;

            while (openSet.Count > 0)
            {
                Point current = openSet.Dequeue();

                if (current == end)
                {
                    ReconstructPath(cameFrom, start, end, path);
                    return true;
                }

                foreach (var neighbor in GetNeighbors(current))
                {
                    int newCost = costSoFar[current] + 1;

                    if (!costSoFar.ContainsKey(neighbor) || newCost < costSoFar[neighbor])
                    {
                        lab[current.Y, current.X].MidLine = lab[current.Y, current.X].MidLine[0] + " . " + lab[current.Y, current.X].MidLine[4];
                        Console.WriteLine(this);
                        Thread.Sleep(200);
                        Console.Clear();
                        costSoFar[neighbor] = newCost;
                        cameFrom[neighbor] = current;
                        openSet.Enqueue(neighbor, newCost);
                    }
                }
            }
            return false;
        }

        // For A*
        private int Heuristic(Point a, Point b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }

        // For BFS, Dijkstra and A* ----------------------------------------------------------------------------
        private List<Point> GetNeighbors(Point p)
        {
            List<Point> neighbors = new List<Point>();

            if (p.Y > 0 && lab[p.Y, p.X].Up) neighbors.Add(new Point(p.X, p.Y - 1));
            if (p.Y < size - 1 && lab[p.Y, p.X].Down) neighbors.Add(new Point(p.X, p.Y + 1));
            if (p.X > 0 && lab[p.Y, p.X].Left) neighbors.Add(new Point(p.X - 1, p.Y));
            if (p.X < size - 1 && lab[p.Y, p.X].Right) neighbors.Add(new Point(p.X + 1, p.Y));

            return neighbors;
        }

        private void ReconstructPath(Dictionary<Point, Point> cameFrom, Point start, Point end, List<Point> path)
        {
            Point current = end;
            while (current != start)
            {
                path.Add(current);
                lab[current.Y, current.X].MidLine = lab[current.Y, current.X].MidLine[0] + " o " + lab[current.Y, current.X].MidLine[4];
                current = cameFrom[current];
            }
            path.Reverse();
            Console.WriteLine($"Found the path: {path.Count} steps");
            Console.WriteLine(this);
        }
        // -----------------------------------------------------------------------------------------------------

        public void Save(string name = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size);
            sb.Append('\n');

            foreach (Cell cell in lab)
            {
                {
                    int cellInt = 0;
                    if (cell.Left) cellInt += 1;
                    if (cell.Up) cellInt += 2;
                    if (cell.Right) cellInt += 4;
                    if (cell.Down) cellInt += 8;
                    sb.Append(cellInt);
                }
            }
            File.WriteAllText(name == "" ? "labyrinth.txt" : name, sb.ToString());
        }

        public Labyrinth Load(string name = "labyrinth.txt")
        {
            string[]? strs = null;
            try
            {
                strs = File.ReadAllLines(name);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (strs != null && strs[0] != "" && strs[1] != "")
            {
                return new Labyrinth(strs);
            }
            else
            {
                return new Labyrinth(size);
            }
        }

        public class Cell
        {
            internal bool left = false;
            internal bool right = false;
            internal bool up = false;
            internal bool down = false;

            private string topLine = "┌───┐";
            private string midLine = "│   │";
            private string botLine = "└───┘";

            public bool Left
            {
                get { return left; }
                set
                {
                    left = value;
                    if ((value == true) && Right) MidLine = "     ";
                    else if ((value == false) && Right) MidLine = "│    ";
                    else if ((value == true) && !Right) MidLine = "    │";
                    else MidLine = "│   │";
                }
            }
            public bool Right
            {
                get { return right; }
                set
                {
                    right = value;
                    if ((value == true) && Left) MidLine = "     ";
                    else if ((value == false) && Left) MidLine = "    │";
                    else if ((value == true) && !Left) MidLine = "│    ";
                    else MidLine = "│   │";
                }
            }
            public bool Up
            {
                get { return up; }
                set
                {
                    up = value;
                    if (value == true) TopLine = "┌   ┐";
                    else TopLine = "┌───┐";
                }
            }
            public bool Down
            {
                get { return down; }
                set
                {
                    down = value;
                    if (value == true) BotLine = "└   ┘";
                    else BotLine = "└───┘";
                }
            }
            public string TopLine { get { return topLine; } set { topLine = value; } }
            public string MidLine { get { return midLine; } set { midLine = value; } }
            public string BotLine { get { return botLine; } set { botLine = value; } }

            public Cell() { }
        }
    }
}
