﻿using System;

namespace ModuleTest
{
    public class QuadraticEquation
    {
        public QuadraticEquation() {}

        public static void Main()
        {

        }

        public double[] Solve(double a, double b, double c)
        {
            var epsilon = 0.000000000001; //double.Epsilon;
            //ax2 + bx + c = 0

            if (Math.Abs(a) < epsilon)
            {
                throw new Exception("The coefficient a cannot be equal to 0");
            }

            if (a == double.NegativeInfinity || b == double.NegativeInfinity || c == double.NegativeInfinity)
            {
                throw new Exception("The coefficients cannot be NegativeInfinity");
            }

            if (a == double.PositiveInfinity || b == double.PositiveInfinity || c == double.PositiveInfinity)
            {
                throw new Exception("The coefficients cannot be PositiveInfinity");
            }

            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
            {
                throw new Exception("The coefficients cannot be NaN");
            }

            var d = b*b - 4*a*c;

            if (d < 0)
            {
                return Array.Empty<double>();
            }

            if (Math.Abs(d) < epsilon)
            {                
                return new double[] { (-b + Math.Sqrt(d)) / 2 * a};
            }

            if (d > 0)
            {
                return new double[] { (-b + Math.Sqrt(d)) / 2 * a, (-b - Math.Sqrt(d)) / 2 * a };
            }

            return Array.Empty<double>();
        }
    }
}