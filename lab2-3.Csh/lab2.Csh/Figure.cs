using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Csh
{
    abstract class Figure : IComparable
    {
        string _Type;

        public int CompareTo(object obj){
            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1; //(this.Area() > p.Area())
        }
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public abstract double Area();
    }
}
