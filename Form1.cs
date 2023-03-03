using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciselneSoustavy08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
            MessageBox.Show("Binární číslo je: " + BinToDec(bin));
        }
        public static int BinToDec(string binarniCislo)
        {
            int decimalniCislo = 0;
            int násobek = 1; //Číslo které se stále násobí a když je bin číslo je tak se přičte k dec
            for (int i = binarniCislo.Length - 1; i >= 0; i--)
            {
                if (binarniCislo[i] == '1')
                {
                    decimalniCislo += násobek;
                }
                násobek *= 2;
            }
            return decimalniCislo;
        }
    }
}
