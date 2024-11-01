using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findSimpleNums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            button1.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            if (!int.TryParse(textBox1.Text, out int n) || n <= 0) 
            {
                label1.Text = "Ошибка ввода: Введите положительное число.";
                return;
            }

            
            List<int> simplNums = FindSimplNums(n);

            foreach (int simplNum in simplNums)
            {
                listBox1.Items.Add(simplNum);
            }

            label1.Text = $" Всего простых чисел {simplNums.Count}:";
        }

        
        private static List<int> FindSimplNums(int n)
        {
            List<int> simplNums = new List<int>();

            for (int i = 2; i <= n; i++) 
            {
                bool isSimple = true; 
                for (int j = 2; j < i; j++) 
                {
                    if (i % j == 0) 
                    {
                        isSimple = false;
                        break; 
                    }
                }

                if (isSimple) 
                {
                    simplNums.Add(i);
                }
            }

            return simplNums;
        }
    }
}
