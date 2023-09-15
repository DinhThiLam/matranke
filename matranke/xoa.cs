using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matranke
{
    class xoa
    {

       class Graph
    {
        private int V; // Số lượng đỉnh trong đồ thị
        private int[,] adjacencyMatrix; // Ma trận kề

        public Graph(int v)
        {
            V = v;
            adjacencyMatrix = new int[v, v];
        }

        // Thêm một cạnh vào đồ thị
        public void AddEdge(int source, int destination)
        {
            adjacencyMatrix[source, destination] = 1;
            adjacencyMatrix[destination, source] = 1; // Đối với đồ thị vô hướng
        }

        // Xóa một cạnh khỏi đồ thị
        public void RemoveEdge(int source, int destination)
        {
            adjacencyMatrix[source, destination] = 0;
            adjacencyMatrix[destination, source] = 0; // Đối với đồ thị vô hướng
        }

        // Hiển thị ma trận kề
        public void DisplayMatrix()
        {
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

   
        static void xoacanh()
        {
            int vertices = 5; // Số lượng đỉnh trong đồ thị
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            Console.WriteLine("Ma trận kề ban đầu:");
            graph.DisplayMatrix();

            // Xóa cạnh giữa đỉnh 0 và 1
            graph.RemoveEdge(0, 1);

            Console.WriteLine("\nMa trận kề sau khi xóa cạnh:");
            graph.DisplayMatrix();
        }
   

}
}
