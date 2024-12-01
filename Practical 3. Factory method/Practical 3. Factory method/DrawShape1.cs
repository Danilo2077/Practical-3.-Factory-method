using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3.Factory_method
{
    public abstract class DrawShape
    {
        // Отримання назви фігури
        public abstract string GetName();

        // Малювання фігури 
        public abstract void Draw(Graphics graphics);

        // Загальний метод очищення області малювання
        public virtual void Clear(Graphics graphics, Color backgroundColor, Rectangle area)
        {
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                graphics.FillRectangle(brush, area);
            }
        }
    }
    public class Cube : DrawShape
    {
        public override string GetName() => "Куб";

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Blue, 2);
            graphics.DrawRectangle(pen, 50, 50, 100, 100);
        }
    }
    public class Cylinder : DrawShape
    {
        public override string GetName() => "Циліндр";

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Green, 2);
            graphics.DrawEllipse(pen, 50, 50, 100, 50); // Верхня частина
            graphics.DrawRectangle(pen, 50, 75, 100, 75); // Тіло
            graphics.DrawEllipse(pen, 50, 125, 100, 50); // Нижня частина
        }
    }
    public class Pyramid : DrawShape
    {
        public override string GetName() => "Піраміда";

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Red, 2);
            Point[] points = { new Point(100, 50), new Point(50, 150), new Point(150, 150) };
            graphics.DrawPolygon(pen, points);
        }
    }
}
