using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(System.Drawing.Brushes.Blue, 100, 100, 50, 50);
        }
    }
}
