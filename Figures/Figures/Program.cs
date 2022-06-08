namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
            {
                new Circle(15, new Point(1, 2)),
                new Rectangle(10, 15, new []
                {
                    new Point(1, 1),
                    new Point(1, 4),
                    new Point(5, 4),
                    new Point(5, 1)
                }),
                new Segment(10, new Point[]
                {
                    new Point(1, 2),
                    new Point(1, 10)
                }),
                new Triangle(new Point[]
                {
                    new Point(1, 1),
                    new Point(4, 5),
                    new Point(5, 1)
                })
            };

            foreach (Figure f in figures)
            {
                f.Draw();
            }
        }
    }
}
