namespace Shapes
{
    public abstract class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // Abstract method forces derived classes to provide their own area calculation
        public abstract double GetArea();
    }
}