using System;
using System.Collections.Generic;
namespace LTDT
{
    class Graph
    {
        private List<int> vertices;
        private List<Tuple<int, int>> edges;

        public Graph()
        {
            vertices = new List<int>();
            edges = new List<Tuple<int, int>>();
        }

        // Thêm đỉnh vào đồ thị
        public void AddVertex(int vertex)
        {
            if (!vertices.Contains(vertex))
            {
                vertices.Add(vertex);
            }
        }

        // Thêm cạnh vào đồ thị
        public void AddEdge(int source, int target)
        {
            if (!vertices.Contains(source) || !vertices.Contains(target))
            {
                throw new InvalidOperationException("Both source and target vertices must exist in the graph.");
            }

            edges.Add(new Tuple<int, int>(source, target));
        }

        // In danh sách đỉnh và cạnh trong đồ thị
        public void PrintGraph()
        {
            Console.WriteLine("Danh sách đỉnh:");
            foreach (var vertex in vertices)
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine("\nDanh sách cạnh:");
            foreach (var edge in edges)
            {
                Console.WriteLine(edge.Item1 + " -> " + edge.Item2);
            }
        }
    }

    
}
