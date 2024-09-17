namespace FigureSquare.Abstractions
{
    public abstract class Figure
    {
        public abstract double CalculateSquare();
        public virtual bool IsRightTriangle() => false;
    }
}
