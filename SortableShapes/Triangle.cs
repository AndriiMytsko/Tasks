namespace SortableShapes
{
    public class Triangle : ShapeBase
    {
        private readonly double _baseSide;
        private readonly double _height;

        public Triangle(double baseSide, double height)
        {
            _baseSide = baseSide;
            _height = height;
        }

        public override double GetArea()
        {
            return _baseSide * _height / 2;
        }
    }
}
