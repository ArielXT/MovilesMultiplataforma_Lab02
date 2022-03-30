using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Punto
    {
        public double x
        {
            get;
            set;
        }
        public double y
        {
            get;
            set;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}