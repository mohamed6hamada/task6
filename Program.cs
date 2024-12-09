using library1;
namespace ConsoleApp2
{
    internal class Program
    {
        static void ModifyPoint(point p)
        {
            p.x = 100;
            p.y= 200;
            Console.WriteLine($"{p.x } , {p.y}");
        }

        static void ModifyEmployee(Employee e)
        {
            e.Name = "Modified Name";
            e.EmpId = 99;
            Console.WriteLine($"{ e.Name}, { e.EmpId}");
        }
        public struct Employee
        {
            public int EmpId { get; set; } private int Salary { get; set; }
            public string Name { get; set; }

        }

        public  struct point
        {
            public int x, y;
            public point()
            {
                x = 10;y = 20;       
            }
            public point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
            //public override string  ToString()
            //{
            //    return $"x= {this.x} , y= {this.y}";
            //}
            public override string ToString()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine( $"x= {this.x} , y= {this.y}");
                }
                return $"x= {this.x} , y= {this.y}";
            }

        }
        static void Main(string[] args)
        {
            TypeA obj1 = new TypeA();
            obj1.H = 10;
            Console.WriteLine(obj1.H);
            Employee emp = new Employee();
            emp.Name = "mohamed";
            Console.WriteLine(emp.Name);
        }
    }
}
