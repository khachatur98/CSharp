using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    enum TriangleType
    {
        Equilateral,
        Isosceles,
        Rightangle,
        None
    }
    class Triangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        private bool IsEquilateral()
        {
            return Side1 == Side2 && Side2 == Side3 && Side3 == Side1;
        }
        private bool IsIsosceles()
        {
            return Side1==Side2 || Side2==Side3 || Side3==Side1;
        }
        public TriangleType GetType()
        {
            if (IsEquilateral()) return TriangleType.Equilateral;
            else if (IsIsosceles()) return TriangleType.Isosceles;
            else return TriangleType.None; 
        }
    }
}
