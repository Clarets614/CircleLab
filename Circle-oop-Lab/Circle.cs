using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_oop_Lab
{
    public class Circle
    {
        //properties
        private double Radius { get; set; }

        //Constructor

        public Circle(double _radius)
        {
            Radius = _radius;
        }


        //methods

        public double CalculateDiameter()
        {
            double diameter = Radius * 2;
            return diameter;
        }

        public double CalculateCircumference()
        {
            double circumference = (Radius * 2) * Math.PI;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }

        public void Grow()
        {
            Radius = Radius * 2;
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
