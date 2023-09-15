using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace matranke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        class MTK
        {
            public int n;  // n là số đỉnh của đồ thị
            public int[,] a;   // a là ma trận 2 chiều đỉnh * đỉnh
            public MTK()
            { }
            public MTK(string filename)
            {
                bool result = load(filename);
                if (result == false)
                    Console.WriteLine("File khong ton tai");
            }
            public bool Read(string filename)
            {
                return load(filename);

            }
            public void Show()
            {
                Console.WriteLine(n);
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write(a[i, j] + " ");
                        Console.WriteLine();

                    }
                }
            }
            private bool load(string filename)
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine(" Khong xuat duoc file");
                    return false;
                }
                string[] lines = File.ReadAllLines(filename);
                n = Int32.Parse(lines[0]);
                a = new int[n, n];
                for (int i = 0; i < n; ++i)
                {
                    string[] tokens = lines[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < n; ++j)
                    {
                        a[i, j] = Int32.Parse(tokens[j]);

                    }
                }
                return true;
            }
        }
    }

