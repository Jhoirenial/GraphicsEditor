using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormSize : Form
    {
        public int width, height;

        public FormSize()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            width = (int)this.numericUpDown1.Value;
            height = (int)this.numericUpDown2.Value;
        }
    }
}
