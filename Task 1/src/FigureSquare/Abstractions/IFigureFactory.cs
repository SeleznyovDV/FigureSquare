namespace FigureSquare.Abstractions
{
    public interface IFigureFactory
    {
        /// <summary>
        /// Создать круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <returns>Круг.</returns>
        public ICircle CreateCircle(double radius);

        /// <summary>
        /// Слздать треугольник. 
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        /// <returns>Треугольник.</returns>
        public ITriangle CreateTriangle(double sideA, double sideB, double sideC);
    }
}
