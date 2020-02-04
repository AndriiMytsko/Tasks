using System;

namespace SortableShapes
{
    public abstract class ShapeBase : IComparable<ShapeBase>
    {
        public abstract double GetArea();

        public int CompareTo(ShapeBase shape)
        {
            var area = GetArea();
            var shapeArea = shape.GetArea();

            return area.CompareTo(shapeArea);
        }
    }
}
