abstract class Shape
{
    public abstract void Area();
    public abstract void Perimeter();
}
class Rectangle : Shape
{
    public double Weight;
    public double Height;

    public Rectangle(double weiht, double height)
    {
        Weight=weiht;
        Height=height;
     
    }
    public override void Area()
    {
        Console.WriteLine("Area of Rectangle: "+(Weight*Height));
    }
    public override void Perimeter()
    {
        Console.WriteLine("Perimeter of Rectangle: "+(2*(Weight+Height)));
    }
    public override string ToString()
    {
        return "Rectangle";
    }
}
class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius=radius;
    }
    public override void Area()
    {
        Console.WriteLine("Area of Circle: "+(3.14*Radius*Radius));
    }
    public override void Perimeter()
    {
        Console.WriteLine("Perimeter of Circle: "+(2*3.14*Radius));
    }
    public override string ToString()
    {
        return "Circle";
    }
}
class Square : Shape
{
    public double Side;
    public Square(double side)
    {
        Side=side;
    }
        
    public override void Area()
    {
        Console.WriteLine("Area of Square: "+(Side*Side));
    }
    public override void Perimeter()
    {
        Console.WriteLine("Perimeter of Square: "+(4*Side));
    }
    public override string ToString()
    {
        return "Square";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle(3,4);
        Console.WriteLine(r.ToString());
        r.Area();
        r.Perimeter();
        Circle c = new Circle(5);
        Console.WriteLine(c.ToString());
        c.Area();
        c.Perimeter();
        Square s = new Square(11);
        Console.WriteLine(s.ToString());
        s.Area();
        s.Perimeter();
    }
}