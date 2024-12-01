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
        private ShapeFactory _currentFactory;

        public Form1()
        {
            InitializeComponent();
        }

        // Метод для зміни фабрики
        private void ChangeFactory(ShapeFactory factory)
        {
            _currentFactory = factory;
        }

        // Метод для відображення фігури
        private void ShowShape()
        {
            if (_currentFactory != null)
            {
                DrawShape shape = _currentFactory.CreateShape();
                using (Graphics graphics = this.CreateGraphics())
                {
                    shape.Clear(graphics, this.BackColor, this.ClientRectangle);
                    shape.Draw(graphics);
                }
            }
        }

        private void ButtonCube_Click(object sender, EventArgs e)
        {
            ChangeFactory(new CubeFactory());  // Встановлення фабрики для Куба
            ShowShape();
        }

        private void ButtonCylinder_Click(object sender, EventArgs e)
        {
            ChangeFactory(new CylinderFactory());  // Встановлення фабрики для Циліндра
            ShowShape();
        }

        private void ButtonPyramid_Click(object sender, EventArgs e)
        {
            ChangeFactory(new PyramidFactory());  // Встановлення фабрики для Піраміди
            ShowShape();
        }
    }
}
