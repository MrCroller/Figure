using FigureDLL.Abstract;

namespace FigureDLL.Tests;

public class DinamicFigureTest
{
    [Fact]
    public void GetAriaFigure_ParamsTriangle()
    {
        // Arrange
        double sideA = 5;
        double sideB = 12;
        double sideC = 13;

        IFigure abstractFigure = new Triangle(sideA, sideB, sideC);
        double expectedArea = 30;

        // Act
        double actualArea = Math.Round(abstractFigure.Aria, 1);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void GetAriaFigure_ParamsCircle()
    {
        // Arrange
        double radius = 65;

        IFigure abstractFigure = new Circle(radius);
        double expectedArea = 13273.229;

        // Act
        double actualArea = Math.Round(abstractFigure.Aria, 3);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }
}
