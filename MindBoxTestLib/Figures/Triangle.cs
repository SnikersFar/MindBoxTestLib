namespace MindBoxTestLib.Figures
{
    public class Triangle : Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double CalculateArea()
        {
            if (!IsValidTriangle(_side1, _side2, _side3))
                throw new ArgumentException("Unable triangle.");

            double sp = (_side1 + _side2 + _side3) / 2;
            double area = Math.Sqrt(sp * (sp - _side1) * (sp - _side2) * (sp - _side3));
            return area;
        }
        public static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 > 0 && side2 > 0 && side3 > 0 &&
                   side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
        public bool IsRightTriangle()
        {
            double maxSide = Math.Max(_side1, Math.Max(_side2, _side3));
            double sumOfSquares = 0;

            if (maxSide == _side1)
                sumOfSquares = _side2 * _side2 + _side3 * _side3;
            else if (maxSide == _side2)
                sumOfSquares = _side1 * _side1 + _side3 * _side3;
            else if (maxSide == _side3)
                sumOfSquares = _side1 * _side1 + _side2 * _side2;

            return maxSide * maxSide == sumOfSquares;
        }
    }
}
