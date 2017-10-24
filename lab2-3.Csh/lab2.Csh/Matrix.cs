using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Csh
{
    public class Matrix<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        int maxX;
        int maxY;
        int maxZ;
        T nullElement;
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }

        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y,z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y,z);
                this._matrix.Add(key, value);
            }
        }

            void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxY) throw new Exception("z=" + z + " выходит за границы");
        }
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString()+"_"+z.ToString();
        }
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < this.maxY; i++)
            {
 
                for (int j = 0; j < this.maxX; j++)
                {
                    b.Append("x=" + i + ", y=" + j+"   ");
                    b.Append("[");
                    for (int k = 0; k < this.maxZ; k++)
                    {
                        if (k > 0) b.Append("\t");
                        b.Append(this[i, j,k].ToString());
                    }
                    b.Append("]\n");
                }
            }
            return b.ToString();
        }
    }
}
