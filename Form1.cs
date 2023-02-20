using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capicua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;
            int ult = palabra.Length;
            if (capicuarec(palabra,ult))
            {
                MessageBox.Show("La palabra es capicua");
            }
            else MessageBox.Show("La palabra no es capicua");
        }


        private bool capicuarec(string palabra, int largo, int ini=0)
        {
            bool capi = false;
            if (!(ini == largo-1))
            {
                if (palabra[ini] == palabra[largo-1])
                {
                    capi = capicuarec(palabra, largo - 1, ini+1);
                }
            }
            else
            { capi = true; }
            return capi;
        }
    }
}


