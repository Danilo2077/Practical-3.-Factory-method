using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3.Factory_method
{
    public abstract class ShapeFactory
    {
        public abstract DrawShape CreateShape();
    }

    public class CubeFactory : ShapeFactory
    {
        public override DrawShape CreateShape()
        {
            return new Cube();
        }
    }

    public class CylinderFactory : ShapeFactory
    {
        public override DrawShape CreateShape()
        {
            return new Cylinder();
        }
    }

    public class PyramidFactory : ShapeFactory
    {
        public override DrawShape CreateShape()
        {
            return new Pyramid();
        }
    }
}
