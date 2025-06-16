namespace HomeWork
{
    internal class Mainn
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 20, 30);

            point.Print();

            point.MoveBy(1, 5, 25);

            point.Print();

            Pc pc = new Pc("HyperPC", 12.22, 32, 1000);
            pc.Info();

            User user = new User("Oleg", "Samogonov", "Yan", 37);
            user.Fio();

            PostOffice postOffice = new PostOffice(66666666, "RU", "Green Wood.", 11, 21, 211, "Hallo");
            postOffice.Info();

            Laptop msi = new Laptop("Lenovo Legion", 12.22, 32, 1000, 2000);
            msi.Info();

            SmartPhone iphone11 = new SmartPhone("Iphone 13", 7.22, 16, 32, 300, "Ios");
            iphone11.Info();

            Rectangle rect = new Rectangle(3, 5, 9, 2);
            rect.Perimeter();
            rect.Square();

            Triangle triangle = new Triangle(10, 10, 10);
            triangle.Perimeter();
            triangle.Square();
            triangle.Info();

            Circle circle = new Circle(1, 8, 6);
            circle.Square();
            circle.Lenght();

            Square square = new Square(2, 5, 9);
            square.Perimeter();
            square.Area();
        }
    }
}
