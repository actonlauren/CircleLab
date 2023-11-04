using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    public class Circle
    {
        public Circle()
        {

        }
        public Circle(double radius) 
        {
            Radius = radius;
        }

        private double Radius { get; set; }
     
        public double Pie => Math.PI;

        public double CalculateDiameter()
        {
            double diameter = Radius + Radius;
            return diameter;
        }
        public double CalculateCircumference()
        {
            double circumference = Pie * CalculateDiameter();
            return circumference;
        }
        public double CalculateArea()
        {
            double area = (Pie * (Math.Pow(Radius, 2))) ;
            return area;
        }
        public double Grow()
        {
            double growth = Radius * 2;
            return growth;
        }

        public double GetRadius()
        {
            return Radius;        
            
        }
         

    }
}
