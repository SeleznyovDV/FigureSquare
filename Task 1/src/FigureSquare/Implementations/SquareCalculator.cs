namespace FigureSquare.Implementations
{
    using FigureSquare.Abstractions;
    public class SquareCalculator : ISquareCalculator
    {
        public double CalulateFigureSquare(IFigure figure) => figure.CalculateSquare();
    }
}
