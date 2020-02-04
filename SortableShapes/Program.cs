using System.Collections.Generic;

namespace SortableShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var baseSide = 5D;
            var height = 2D;

            var shapes = new List<ShapeBase>
            {
                new Square(side),
                new Circle(radius),
                new Triangle(baseSide, height)
            };

            shapes.Sort();
        }
    }
}
