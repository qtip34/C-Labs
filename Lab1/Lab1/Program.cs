using System;

namespace Lab1
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("enter number of points: ");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            Console.WriteLine("If you want to set points enter 1 . If you want to generate points enter 2: ");
            string choise = Console.ReadLine();
            int choise1 = Convert.ToInt32(choise);
            if( choise1 == 1)
            {
                Graph graph = new Graph(a, EnterPoints(a));
                Console.WriteLine("Generated distance matrix: ");
                graph.OutputDistanceMatrix();

                graph.FindPath();

                Console.WriteLine("\nFound shortest lenghes(length = {0}):", graph.MinSpanningTreeLen);
                graph.OutputMinSpanningTree();

                Console.ReadKey();
            }
            else
            {
                Graph graph = new Graph(a, null);
                Console.WriteLine("Generated distance matrix: ");
                graph.OutputDistanceMatrix();

                graph.FindPath();

                Console.WriteLine("\nFound shortest cities spanning tree(length = {0}):", graph.MinSpanningTreeLen);
                graph.OutputMinSpanningTree();

                Console.ReadKey();
            }
            
			
	       
        }
        public static int[ , ] EnterPoints(int n)
        {
            int[,] points = new int[n, 3];
            Console.WriteLine("Enter points: ");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    string s1 = Console.ReadLine();
                    points[i, j]= Convert.ToInt32(s1);
                }
            }
            return points;
        }
       
    }
}
