namespace SortableShapes
{
    public class Rectangle : ShapeBase
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }
}
