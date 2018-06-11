using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
    //ip-63 Popova Vera,Variant 20 ()
	internal class Graph
	{
		public Graph(int n, int[,] points)
		{
			distance = new int[n, n];
			minSpanningTreeLen = INFINITY;
            if (points == null)
            {
                Generate();
            }
            else
            {
                FindDistance(points);
            }
        }


        public void OutputDistanceMatrix()
		{
			int n = distance.GetLength(0);
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j)
					Console.Write($"{distance[i, j]} ");
				Console.Write("\n");
			}
		}

		public void OutputMinSpanningTree()
		{
			if (minSpanningTree == null)
			{
				Console.WriteLine("Error: path not yet found");
				return;
			}

			foreach (object curObj in minSpanningTree)
			{
				KeyValuePair<int, int> curEdge = (KeyValuePair<int, int>)curObj;
				Console.WriteLine("{0} <--> {1}", curEdge.Key, curEdge.Value);
			}
			Console.Write("\n");
		}

		public void FindPath()
		{
			minSpanningTree = new ArrayList();
			minSpanningTreeLen = 0;
			
			int n = distance.GetLength(0);
			bool[] isVisited = new bool[n];
			for (int i = 1; i < n; i++)
				isVisited[i] = false;
			isVisited[0] = true;

			int lastAddedVertex = 0;
			ArrayList sortedEdges = new ArrayList();

			while (!IsAllVisited(ref isVisited))
			{
				//  vertices to lastAdded vertex
				for (int i = 0; i < n; i++)
					if (!isVisited[i])
					{
						// Add edge 'lastAdded <--> i' to sortedEdges

						int edgeDistance = distance[lastAddedVertex, i];
						int insertIndex = 0;
						while (insertIndex < sortedEdges.Count && edgeDistance > GetEdgeDistance((KeyValuePair<int, int>)sortedEdges[insertIndex]))
							++insertIndex;
						sortedEdges.Insert(insertIndex, new KeyValuePair<int, int>(lastAddedVertex, i));
					}

				// Remove all edges which connect already visited vertex
				while(sortedEdges.Count != 0 && isVisited[((KeyValuePair<int, int>)sortedEdges[0]).Value])
					sortedEdges.RemoveAt(0);

				if (sortedEdges.Count == 0)
					return;

				KeyValuePair<int, int> lastAddedEdge = (KeyValuePair<int, int>)sortedEdges[0];
				lastAddedVertex = lastAddedEdge.Value;

				minSpanningTreeLen += GetEdgeDistance(lastAddedEdge);

				// Set new vertex as visited
				isVisited[lastAddedVertex] = true;
				// Add edge, which connect new vertex, to minSpanningTree
				minSpanningTree.Add(sortedEdges[0]);
				sortedEdges.RemoveAt(0);
			}

		}

		protected bool IsAllVisited(ref bool[] isVisited)
		{
			int n = isVisited.GetLength(0);
			for (int i = 0; i < n; i++)
				if (!isVisited[i])
					return false;
			return true;
		}

        protected void FindDistance(int[,] points)
        {
            int n = distance.GetLength(0);
            for (int a = 0; a < n; ++a)
                for (int b = 0; b < n; ++b)
                {
                    if (a == b)
                    {
                        distance[a, b] = 0;
                        continue;
                    }
                    distance[a, b] = Convert.ToInt32(Math.Pow(Math.Pow(points[b , 0] - points[a, 0], 2) + Math.Pow(points[b, 1] - points[a, 1], 2) + Math.Pow(points[b, 2] - points[a, 2], 2), 0.5));
                    distance[b, a] = distance[a, b];
                }
        }
		protected void Generate()
		{
			Random random = new Random();

			int n = distance.GetLength(0);
			for (int i = 0; i < n; ++i)
				for (int j = 0; j <= i; ++j)
				{
					if (i == j)
					{
						distance[i, j] = 0;
						continue;
					}
					distance[i, j] = random.Next(1, 10);
					distance[j, i] = distance[i, j];
				}
		}

        protected void SmezhPolzovatel()
        {
             
        }
		protected int GetEdgeDistance(KeyValuePair<int, int> edge)
		{
			return distance[edge.Key, edge.Value];
		}

		public int MinSpanningTreeLen => minSpanningTreeLen;

		protected int[,] distance;				// Distance between points
		protected ArrayList minSpanningTree;	// Founded minimum spanning tree
		protected int minSpanningTreeLen;	

		private const int INFINITY = 1000;
	}
}
