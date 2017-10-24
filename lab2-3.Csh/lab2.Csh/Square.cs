using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Csh
{
    class Square: Rectangle, Print
    {
        public Square(double size): base(size, size)
        {
            this.Type = "Квадрат";
        }
    }
}
