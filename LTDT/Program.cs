using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           BThien hien = hien = new BThien();
             hien.DocMaTranKe("input1.txt");
             Console.ReadLine();
          
           /* // Tạo một đồ thị
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
            // Tạo đồ thị
            Graph graph = new Graph();
             // Thêm các đỉnh vào đồ thị
             Node node1 = new Node(1);
             Node node2 = new Node(2);
             Node node3 = new Node(3);

             graph.AddNode(node1);
             graph.AddNode(node2);
             graph.AddNode(node3);

             // Thêm các cạnh vào đồ thị
             graph.AddEdge(node1, node2);
             graph.AddEdge(node2, node3);
             graph.AddEdge(node3, node1);

             // Kiểm tra các cạnh đã được thêm vào đồ thị
             foreach (var edge in graph.Edges)
             {
                 Console.WriteLine($"Edge from Node {edge.Source.Id} to Node {edge.Target.Id}");
             }
            */
        }
    }
}
