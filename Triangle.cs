namespace Figure
{
    internal sealed class Triangle : IFigure
    {
        #region Properties

        public double Aria { get; private set; }
        public double Perimeter { get; private set; }

        public double[] Sides { get; private set; }
        
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                double[] sides = Sides.OrderByDescending(side => side).ToArray();
                return Pow2(sides[0]) == (Pow2(sides[1]) + Pow2(sides[0]));
            }
        }

        #endregion


        #region ClassLifeCicle

        /// <summary>
        /// Задать стороны треугольника
        /// </summary>
        /// <param name="sideA">Сторона а</param>
        /// <param name="sideB">Сторона b</param>
        /// <param name="sideC">Сторона c</param>
        private Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA >= sideB + sideC || sideB >= sideC + sideA || sideC >= sideA + sideB)
            {
                throw new Exception("Треугольника с такими сторонами не существует");
            }

            Sides = new double[3] { sideA, sideB, sideC };

            Perimeter = Sides.Sum();

            double perimeterHalf = Perimeter / 2;
            Aria = Math.Sqrt(perimeterHalf * (perimeterHalf - Sides[0]) * (perimeterHalf - Sides[1]) * (perimeterHalf - Sides[2]));
        }

        private double Pow2(double number) => Math.Pow(number, 2);

        #endregion
    }
}
