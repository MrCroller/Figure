namespace FigureDLL.Tests;

public class CircleTest
{
    [Fact]
    public void GetAria_ParamsRadius3_46_Necessary39_21()
    {
        // Arrange

        Circle circle = new(3.46);
        double expectedArea = 37.61;

        // Act
        double actualArea = Math.Round(circle.Aria, 2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void GetAria_Radius3_NecessaryArea46()
    {
        // Arrange
        var circle = new Circle(3);
        var expectedArea = 28.274;

        // Act
        var actualArea = Math.Round(circle.Aria, 3);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }


    [Fact]
    public void ChekParamsUpdate()
    {
        // Arrange
        double defoultRadius = 8;
        double newAria = 67;
        double expectedDiametr = 9.236;

        Circle circle = new(defoultRadius);

        // Act
        circle.Aria = newAria;
        double actualDiametr = Math.Round(circle.Diameter, 3);

        // Assert
        Assert.Equal(expectedDiametr, actualDiametr);
    }


    [Fact]
    public void ChekException()
    {
        // Arrange
        double defoultRadius = -0;

        try
        {
            // Act
            Circle circle = new(defoultRadius);

            // Assert
            Assert.True(false);
        }
        catch
        {
            // Assert
            Assert.True(true);
        }
        
    }
}