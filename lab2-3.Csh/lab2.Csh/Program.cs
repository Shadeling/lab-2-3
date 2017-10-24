using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab2.Csh
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(3);
            Square s1 = new Square(4);
            Rectangle r1 = new Rectangle(3, 5);
            ArrayList ar = new ArrayList(3);
            ar.Add(c1); ar.Add(s1); ar.Add(r1);
            ar.Sort();
            Console.WriteLine("Отсортированный ArrayList:");
            foreach(object o in ar)
            {
                Console.WriteLine(o);
            }

            List<Figure> list = new List<Figure>();
            list.Add(c1); list.Add(s1); list.Add(r1);
            list.Sort();
            Console.WriteLine("");
            Console.WriteLine("Отсортированный List<Figure>:");
            foreach (Figure f in list)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("");
            Matrix<int> m = new Matrix<int>(3, 3, 3, 0);
            Console.Write(m.ToString());

            Console.WriteLine("");
            Console.WriteLine("SimpleStack:");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.push(c1);  stack.push(s1); stack.push(r1);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.pop());
            }

            Console.ReadKey();
        }
    }
}
