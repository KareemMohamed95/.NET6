using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Operator_Overloading
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        //Overloading the + operator
        public static Point operator +(Point p1, Point p2)
        {
            return new Point()
            {
                x = p1.x + p2.x,
                y = p1.y + p2.y
            };
        }

        //Overloading the * operator
        public static Point operator *(Point p1, int scalar) => new Point()
        {
            x = p1.x * scalar,
            y = p1.y * scalar
        };
        public static Point operator *(int scalar, Point p1) => p1 * scalar;

        //Overloading the indexer operator
        public int this[int index]
        {
            get => index switch { 0 => x, 1 => y, _ => 0 };
            set 
            {
                if (index == 0) x = value;
                else if (index == 1) y = value;
            }
        }
    }
}
