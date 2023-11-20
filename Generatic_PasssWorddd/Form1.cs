using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generatic_PasssWorddd
{
    public partial class Form1 : Form
    {
        int size;
        string pass;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.size = (int)numericUpDown1.Value;
            if(size>32)
            {
                MessageBox.Show("Слишком длинно,максимальная длинна пароля 32 символа");
            }
            else
            {
                Random random = new Random();
                char sym;
                for(int i=0;i<size;i++)
                {
                    sym = (char)random.Next(32, 126);
                    pass += sym;
                }
            }

            textBox1.Text = pass;
        }

       
    }
}
