// See https://aka.ms/new-console-template for more information
namespace oopExample
{
    // 1. Encapsulation
    public class Person
    {
        private string name;  // Field private (terenkapsulasi)

        public string Name   // Public property
        {
            get { return name; }
            set { name = value; }
        }

        public void Greet()
        {
            Console.WriteLine($"Hallo, nama saya adalah {Name}");
        }
    }
    
    // 2. Inheritance & 3. Polymorphism
    public class Employee : Person
    {
        public string Position { get; set; }

        // Overriding method
        public new void Greet()
        {
            Console.WriteLine($"Hallo, nama saya {Name} dan saya adalah seorang {Position}");
        }
    }

    // 3. Polymorphism: Overloading methods
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // 4. Abstraction
    public abstract class Shape
    {
        public abstract double GetArea();  // Abstract method (harus diimplementasikan di turunan)
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Encapsulation
            Person person = new Person();
            person.Name = "Nada";
            person.Greet(); 

            // Inheritance and Polymorphism (overriding)
            Employee employee = new Employee();
            employee.Name = "Aca";
            employee.Position = "Mahasiswa";
            employee.Greet();  

            // Polymorphism (overloading)
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));          
            Console.WriteLine(calc.Add(2.5, 3.1));      

            // Abstraction
            Shape shape = new Circle(5);
            Console.WriteLine($"Area of the circle: {shape.GetArea()}");  
        }
    }
}
