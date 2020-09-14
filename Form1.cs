using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArrayManager
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


        private void Btn_generate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string arrayString = "";
            bool succes = Int32.TryParse(TextBox_arrayRange.Text, out int range);

            if (succes)
            {
                int[] tmpArray = new int[range];
                for (int i = 0; i < range; i++)
                {
                    tmpArray[i] = rand.Next(10);

                    arrayString += $"<{tmpArray[i]}> ";
                }
            }
            else
            {
                arrayString = $"[{TextBox_arrayRange.Text}] - не является числом";
            }
            TextBox_ArrayOutput.Text = arrayString;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            TextBox_ArrayOutput.Text = "";
        }
    }
}
