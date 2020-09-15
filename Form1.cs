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
        int[] array;
        int range;
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
            string output = "";
            bool succes = Int32.TryParse(TextBox_arrayRange.Text, out range);
            array = new int[range];

            if (succes)
            {

                for (int i = 0; i < range; i++)
                {
                    array[i] = rand.Next(10);

                    output += $"<{array[i]}> ";
                }
            }
            else
            {
                output = $"[{TextBox_arrayRange.Text}] - не является числом";
            }
            TextBox_ArrayOutput.Text = output;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            TextBox_ArrayOutput.Text = "";
            array = null;
        }
    }
}
