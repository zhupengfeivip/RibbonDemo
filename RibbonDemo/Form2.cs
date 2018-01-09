using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RibbonDemo
{
    public partial class Form2 : RibbonForm
    {
        public Form2()
        {
            InitializeComponent();
        
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height - this.ribbon1.Height - this.statusStrip1.Height - 15;
            this.tabControlEx1.Size = new Size(width, height);
            //this.tabControlEx1.Size = new Size(900, 800);
        }
    }
}
