using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MouseClickDemo
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            // UI
            InitializeComponent();

            // Attach to Event HAndler
            this.MouseDown += Form1_MouseDown;
        }

        // Event Handler
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // On Event Show Mouse Coordinates
            MessageBox.Show(string.Format("X = {0}, Y = {1}", e.X, e.Y));
        }
    }
}
