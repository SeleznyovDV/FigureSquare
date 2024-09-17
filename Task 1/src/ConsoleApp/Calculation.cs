using FigureSquare.Abstractions;

namespace ConsoleApp
{
    internal class Calculation
    {
        private readonly ISquareCalculator _calculator;
        private readonly IFigureFactory _factory;
        public Calculation(ISquareCalculator calculator, IFigureFactory factory)
        {
            _calculator = calculator;
            _factory = factory;
        }

        public void MakeCalculation()
        {
            try
            {
                var figure = CreateRandomFigure();
                ConsoleWriteFigureInfo(figure);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private IFigure CreateRandomFigure()
        {
            Random random = new Random();
            var type = random.Next(1, 3);
            IFigure figure;
            if (type == 1)
                figure =  _factory.CreateCircle(random.NextDouble() * 10);
            else
                figure = _factory.CreateTriangle(random.NextDouble() * 10, random.NextDouble() * 10, random.NextDouble() * 10);

            return figure;
        }
        private void ConsoleWriteFigureInfo(IFigure figure)
        {
            var square = _calculator.CalulateFigureSquare(figure);
            if (figure.GetType().Name == "Circle")
            {
                ICircle circle = (ICircle)figure;
                Console.WriteLine($"Тип фигуры: {circle.GetType().Name}, радиус: {circle.GetRadius()}, диаметр: {circle.GetDiameter()}, площадь: {square}, длинна окружности: {circle.GetCircleLength()}");
            }
            else if (figure.GetType().Name == "Triangle")
            {
                ITriangle triangle = (ITriangle)figure;
                Console.WriteLine($"Тип фигуры: {triangle.GetType().Name}, периметр: {triangle.CalculatePerimeter()}, площадь: {square}, Правильный: {triangle.IsRightTriangle()}, Прямоугольный: {triangle.IsRectangleTriangle()}");
            }
        }


    }
}
