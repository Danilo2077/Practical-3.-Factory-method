using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3.Factory_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowShape(DrawShape shape)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                // Очищення області
                shape.Clear(graphics, this.BackColor, this.ClientRectangle);

                // Малювання фігури
                this.Text = $"Показуємо: {shape.GetName()}";
                shape.Draw(graphics);
            }
        }
        private void ButtonCube_Click(object sender, EventArgs e)
        {
            DrawShape shape = new Cube();
            ShowShape(shape);
        }

        private void ButtonCylinder_Click(object sender, EventArgs e)
        {
            DrawShape shape = new Cylinder();
            ShowShape(shape);
        }

        private void ButtonPyramid_Click(object sender, EventArgs e)
        {
            DrawShape shape = new Pyramid();
            ShowShape(shape);
        }
    }
}
