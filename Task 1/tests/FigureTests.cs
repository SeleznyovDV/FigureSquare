using FigureSquare.Abstractions;
using FigureSquare.Implementations;

public class FigureTests
{
    private readonly IFigureFactory _factory;
    public FigureTests()
    {
        _factory = new FigureFactory();
    }

    #region Тесты для круга

    [Fact]
    public void Constructor_ValidRadius_ShouldCreateCircle()
    {
        double validRadius = 5.0;
        var circle = _factory.CreateCircle(validRadius);
        Assert.NotNull(circle);
        Assert.Equal(validRadius, circle.GetRadius());
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentOutOfRangeException()
    {
        double negativeRadius = -3.0;
        var exception = Assert.Throws<ArgumentException>(() => _factory.CreateCircle(negativeRadius));
        Assert.Equal("Радиус должен быть положительным.", exception.Message);
    }

    [Fact]
    public void Constructor_ZeroRadius_ThrowsArgumentOutOfRangeException()
    {
        double zeroRadius = 0.0;
        var exception = Assert.Throws<ArgumentException>(() => _factory.CreateCircle(zeroRadius));
        Assert.Equal("Радиус должен быть положительным.", exception.Message);
    }

    [Fact]
    public void Circle_Length_Calculation()
    {
        var circle = _factory.CreateCircle(5);
        Assert.Equal(Math.PI * 10, circle.GetCircleLength());
    }

    [Fact]
    public void Circle_Square_Calculation()
    {
        var circle = _factory.CreateCircle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateSquare());
    }

    #endregion

    #region Тесты для треугольника.

    [Fact]
    public void Constructor_triangle_ValidSides_ShouldCreateTriangle()
    {
        double sideA = 3.0;
        double sideB = 4.0;
        double sideC = 5.0;
        var triangle = _factory.CreateTriangle(sideA, sideB, sideC);
        Assert.NotNull(triangle);
    }

    [Fact]
    public void Constructor_triangle_NegativeSide_ThrowsArgumentException()
    {
        double sideA = -1.0;
        double sideB = 4.0;
        double sideC = 5.0;
        var exception = Assert.Throws<ArgumentException>(() => _factory.CreateTriangle(sideA, sideB, sideC));
        Assert.Equal("Стороны треугольника должны быть положительными.", exception.Message);
    }

    [Fact]
    public void Constructor_triangle_ZeroSide_ThrowsArgumentException()
    {
        double sideA = 0.0;
        double sideB = 4.0;
        double sideC = 5.0;
        var exception = Assert.Throws<ArgumentException>(() => _factory.CreateTriangle(sideA, sideB, sideC));
        Assert.Equal("Стороны треугольника должны быть положительными.", exception.Message);
    }

    [Fact]
    public void Constructor_triangle_SumOfTwoSidesLessThanThird_ThrowsArgumentException()
    {
        double sideA = 1.0;
        double sideB = 2.0;
        double sideC = 3.0;
        var exception = Assert.Throws<ArgumentException>(() => _factory.CreateTriangle(sideA, sideB, sideC));
        Assert.Equal("Сумма двух сторон должна быть больше третьей стороны.", exception.Message);
    }

    [Fact]
    public void Triangle_Area_Calculation()
    {
        var triangle = _factory.CreateTriangle(4, 3, 5);
        Assert.Equal(6, triangle.CalculateSquare());
    }

    [Fact]
    public void Triangle_IsRightTriangle()
    {
        var triangle = _factory.CreateTriangle(1, 1, 1);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void Triangle_IsNotRightTriangle()
    {
        var triangle = _factory.CreateTriangle(3, 4, 5);
        Assert.False(triangle.IsRightTriangle());
    }

    [Fact]
    public void Triangle_IsRectangleTriangle()
    {
        var triangle = _factory.CreateTriangle(5, 4, 3);
        Assert.True(triangle.IsRectangleTriangle());
    }

    [Fact]
    public void Triangle_IsNotRectangleTriangle()
    {
        var triangle = _factory.CreateTriangle(1, 1, 1);
        Assert.False(triangle.IsRectangleTriangle());
    }
    #endregion
}
