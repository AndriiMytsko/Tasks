using System;

namespace SortableShapes
{
    public class Circle : ShapeBase
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}