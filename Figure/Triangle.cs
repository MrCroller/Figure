using FigureDLL.Abstract;

namespace FigureDLL.Figure;

public sealed class Triangle : IFigure
{
    private double[] _sides;

    #region Properties

    public double Aria 
    {
        get
        {
            var plPer = Perimeter / 2;

            var sumS = plPer - Sides.First();
            for (int i = 1; i < Sides.Length; i++)
            {
                sumS *= plPer - Sides[i];
            }

            return Math.Sqrt(plPer * sumS);
        }
    }
    public double Perimeter
    {
        get => Sides.Sum();
    }

    public double[] Sides 
    {
        get => _sides;
        set
        {
            double sideA = value[0];
            double sideB = value[1];
            double sideC = value[2];

            if (sideA >= sideB + sideC || sideB >= sideC + sideA || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }
            else
            {
                _sides = value;
            }
        }
    }

    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRectangular
    {
        get
        {
            if (Sides.Length != 3) return false;

            double[] sides = Sides.OrderBy(side => side).ToArray();

            double hypotenuse = sides[2];
            double leg1 = sides[0];
            double leg2 = sides[1];

            return Pow2(hypotenuse) == Pow2(leg1) + Pow2(leg2);
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
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA >= sideB + sideC || sideB >= sideC + sideA || sideC >= sideA + sideB)
        {
            throw new ArgumentException("Треугольника с такими сторонами не существует");
        }

        _sides = new double[3] { sideA, sideB, sideC };
    }

    private double Pow2(double number) => Math.Pow(number, 2);

    #endregion

}
