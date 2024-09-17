namespace FigureSquare.Implementations
{
    using FigureSquare.Abstractions;
    using FigureSquare.Implementations.Figures;

    public class FigureFactory : IFigureFactory
    {
        /// <summary>
        /// Создать круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <returns>Круг.</returns>
        public ICircle CreateCircle(double radius)
        {
            return new Circle(radius);
        }
        
        /// <summary>
        /// Слздать треугольник. 
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        /// <returns>Треугольник.</returns>
        public ITriangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
