using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIN_PATH_HCMUTE
{
    public partial class Form2 : Form
    {
        private Graph graph = new Graph(); // Khởi tạo đồ thị 
        public Form2()
        {
            graph.AddEdge("B3", "B4", 0.75);
            graph.AddEdge("B4", "B5", 1.8);
            graph.AddEdge("C4", "B4", 0.8);
            graph.AddEdge("C4", "X", 2.2);
            graph.AddEdge("C4", "Z", 0.6);
            graph.AddEdge("XT", "X", 1.7);
            graph.AddEdge("X", "C9", 5.1);
            graph.AddEdge("Z", "C5", 2);
            graph.AddEdge("B5", "N", 0.7);
            graph.AddEdge("C5", "V", 1.1);
            graph.AddEdge("V", "C9", 3);
            graph.AddEdge("1", "D5", 0.8);
            graph.AddEdge("2", "D5", 2.5);
            graph.AddEdge("D5", "D6", 1);
            graph.AddEdge("D6", "5", 5.2);
            graph.AddEdge("4", "5", 0.25);
            graph.AddEdge("C9", "E12", 1.85);
            graph.AddEdge("C9", "D1", 2);
            graph.AddEdge("E12", "MN", 0.5);
            graph.AddEdge("E12", "ER", 0.9);
            graph.AddEdge("E12", "D3", 2.5);
            graph.AddEdge("D3", "QW", 0.5);
            graph.AddEdge("D3", "1", 2.25);
            graph.AddEdge("D3", "D4", 2.5);
            graph.AddEdge("ER", "D2", 1.1);
            graph.AddEdge("D2", "D1", 1.6);
            graph.AddEdge("D4", "D2", 2.65);
            graph.AddEdge("D4", "3", 0.6);
            graph.AddEdge("D6", "D4", 2);
            graph.AddEdge("D6", "D7", 2.3);
            graph.AddEdge("D7", "4", 1.5);
            graph.AddEdge("A", "D9", 0.6);
            graph.AddEdge("D9", "B", 0.5);
            graph.AddEdge("A3", "D9", 0.8);
            graph.AddEdge("A3", "A2", 1.2);
            graph.AddEdge("A2", "S", 1.5);
            graph.AddEdge("A1", "A2", 0.6);
            graph.AddEdge("A1", "R", 0.95);
            graph.AddEdge("R", "T", 2);
            graph.AddEdge("T", "A11", 2.3);
            graph.AddEdge("A11", "A10", 2);
            graph.AddEdge("A7", "A6", 2.1);
            graph.AddEdge("A10", "P", 0.25);
            graph.AddEdge("A8", "Q", 0.18);
            graph.AddEdge("P", "A9", 0.55);
            graph.AddEdge("A9", "PQ", 1.8);
            graph.AddEdge("B1", "XT", 0.85);
            graph.AddEdge("PQ", "B3", 1.25);
            graph.AddEdge("B2", "J", 0.75);
            graph.AddEdge("D7", "D8", 1.1);
            graph.AddEdge("D8", "3", 0.75);
            graph.AddEdge("D8", "6", 3);
            graph.AddEdge("R", "A10", 2.2);
            graph.AddEdge("A1", "A7", 2);
            graph.AddEdge("A3", "A6", 2.5);
            graph.AddEdge("B", "C", 0.35);
            graph.AddEdge("C", "A4", 0.6);
            graph.AddEdge("C", "D", 0.95);
            graph.AddEdge("A4", "A5", 2.9);
            graph.AddEdge("D", "A5", 0.8);
            graph.AddEdge("D", "E", 1.1);
            graph.AddEdge("A10", "A7", 1.5);
            graph.AddEdge("A11", "XT", 1.95);
            graph.AddEdge("A7", "A8", 1.2);
            graph.AddEdge("A8", "A9", 0.75);
            graph.AddEdge("P", "B1", 2.2);
            graph.AddEdge("B1", "PQ", 0.72);
            graph.AddEdge("A8", "B2", 3.75);
            graph.AddEdge("B3", "B2", 1);
            graph.AddEdge("B5", "J", 0.25);
            graph.AddEdge("6", "7", 1.5);
            graph.AddEdge("7", "8", 1.65);
            graph.AddEdge("A6", "A4", 1.3);
            graph.AddEdge("A6", "E2", 0.9);
            graph.AddEdge("E2", "G", 0.6);
            graph.AddEdge("G", "F", 0.8);
            graph.AddEdge("F", "C1", 0.45);
            graph.AddEdge("C1", "A5", 0.78);
            graph.AddEdge("C1", "E", 0.55);
            graph.AddEdge("E2", "C2", 1.3);
            graph.AddEdge("C2", "C3", 1.25);
            graph.AddEdge("C3", "B9", 1.92);
            graph.AddEdge("B9", "C1", 1.8);
            graph.AddEdge("B9", "H", 1.2);
            graph.AddEdge("E", "H", 1);
            graph.AddEdge("C3", "I", 0.3);
            graph.AddEdge("I", "K", 0.4);
            graph.AddEdge("C2", "B6", 2.75);
            graph.AddEdge("B5", "B6", 1);
            graph.AddEdge("B6", "B8", 1.5);
            graph.AddEdge("B8", "C8", 1.75);
            graph.AddEdge("C8", "B9", 2.5);
            graph.AddEdge("K", "B8", 0.25);
            graph.AddEdge("B8", "M", 0.7);
            graph.AddEdge("C8", "L", 0.85);
            graph.AddEdge("B6", "B7", 1.25);
            graph.AddEdge("B7", "N", 0.55);
            graph.AddEdge("B7", "M", 1.2);
            graph.AddEdge("C8", "C7", 4.5);
            graph.AddEdge("B7", "C6", 1.5);
            graph.AddEdge("C6", "E1", 0.5);
            graph.AddEdge("E1", "C7", 1.5);
            graph.AddEdge("C7", "O", 0.8);
            graph.AddEdge("D1", "9", 5);
            graph.AddEdge("E1", "9", 10);
            graph.AddEdge("V", "9", 6);





            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = textBox1.Text;    
            string end = textBox2.Text;
            string Result = " "; 
            var result = graph.Dijkstra(start, end);
            for(int i = 0; i < result.Count; i++)
            {
                Result += result[i] + " -> ";
            }   
            if (result != null)
            {
                label3.Text = "Đường đi ngắn nhất từ " + start + " đến " + end + " là: "  + Result + " với chi phí là: " ;
            }
            else
            {
                label3.Text = "Không có đường đi từ " + start + " đến " + end;
            }
        }
    }
}
