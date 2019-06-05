using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MousLokasyonbulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0, y = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (x = Cursor.Position.X).ToString();
            textBox2.Text = (y = Cursor.Position.Y).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (x = Cursor.Position.X).ToString();
            textBox2.Text = (y = Cursor.Position.Y).ToString();
            timer1.Start();
        }
    }
}
