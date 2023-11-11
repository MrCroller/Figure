using FigureDLL.Abstract;

namespace FigureDLL.Figure;

public sealed class Circle : IFigure
{

    #region Fields

    private double _radius;

    #endregion


    #region Properties

    public double Radius
    {
        get => _radius;
        set => ExaminationRadiusArgument(value);
    }

    public double Diameter
    {
        get => 2 * _radius;
        set => ExaminationRadiusArgument(value / 2);
    }

    public double Perimeter
    {
        get => 2 * Math.PI * _radius;
        set => ExaminationRadiusArgument(value / (2 * Math.PI));
    }

    public double Aria
    {
        get => Math.PI * Math.Pow(_radius, 2);
        set => ExaminationRadiusArgument(Math.Sqrt(value / Math.PI));
    }

    #endregion


    #region ClassLifeCicle

    public Circle(double radius)
    {
        Radius = radius;
    }

    #endregion


    #region Methods

    private void ExaminationRadiusArgument(double number)
    {
        if (double.IsRealNumber(number) & number > 0)
        {
            _radius = number;
        }
        else
        {
            throw new ArgumentException("number is not real");
        }
    }

    #endregion

}
