using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace them
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

    class Program
    {
        static void Main()
        {
            // Tạo một đồ thị
            Graph graph = new Graph();

            // Thêm đỉnh vào đồ thị
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);

            // Thêm cạnh vào đồ thị
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);

            // In danh sách đỉnh và cạnh
            graph.PrintGraph();
        }
    }
}
