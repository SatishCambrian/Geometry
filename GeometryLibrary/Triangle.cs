using GeometryLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double _base;
        private double _height;
        private double _sideA;
        private double _sideB;

        public Triangle(double baseLength, double height, double sideA, double sideB)
        {
            _base = baseLength;
            _height = height;
            _sideA = sideA;
            _sideB = sideB;
        }

        public double CalculateArea() => 0.5 * _base * _height;

        public double CalculatePerimeter() => _sideA + _sideB + _base;
        
    }
}
