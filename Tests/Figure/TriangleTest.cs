namespace FigureDLL.Tests;

public class TriangleTest
{
    [Fact]
    public void GetAria_Sides2_4_5_Necessary3_8()
    {
        // Arrange
        double sideA = 2;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new(sideA, sideB, sideC);
        double expectedArea = 3.8;

        // Act
        double actualArea = Math.Round(triangle.Aria, 1);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void ChekException()
    {
        // Arrange
        double sideA = 0;
        double sideB = -4;
        double sideC = 500000;

        try
        {
            // Act
            Triangle triangle = new(sideA, sideB, sideC);

            // Assert
            Assert.True(false);
        }
        catch
        {
            // Assert
            Assert.True(true);
        }
    }

    [Fact]
    public void ChekRectangular()
    {
        // Arrange
        double sideA = 3;
        double sideB = 5;
        double sideC = 4;

        Triangle triangle = new(sideA, sideB, sideC);

        // Assert
        Assert.True(triangle.IsRectangular);
    }
}
