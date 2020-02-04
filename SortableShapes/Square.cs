namespace SortableShapes
{
    public class Square : ShapeBase
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}
