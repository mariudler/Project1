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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Yellow, 50, 50, 50, 50);
        }
    }
}
