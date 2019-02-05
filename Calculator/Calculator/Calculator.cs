using System;
using System.Security.Permissions;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            double res = a + b;

            Accumulator = res;

            return res;
        }
        public double Add(double a)
        {
            double res = Accumulator + a;

            Accumulator = res;

            return res;
        }

        public double Subtract(double a, double b)
        {
            double res = a - b;

            Accumulator = res;

            return res;
        }
        public double Subtract(double a)
        {
            double res = Accumulator - a;

            Accumulator = res;

            return res;
        }

        public double Multiply(double a, double b)
        {
            double res = a * b;

            Accumulator = res;

            return res;
        }

        public double Multiply(double a)
        {
            double res = Accumulator * a;

            Accumulator = res;

            return res;
        }

        public double Divide(double a, double b)
        {
            if (a == 0) return 0;
            if (b == 0) return 0;

            Accumulator = a / b;

            return Accumulator;
        }

        public double Divide(double a)
        {
            if (a == 0) return 0;

            Accumulator = Accumulator / a;

            return Accumulator;
        }

        public double Power(double a, double b)
        {
            double res = Math.Pow(a, b);

            Accumulator = res;

            return res;
        }

        public double Power(double a)
        {
            double res = Math.Pow(Accumulator, a);

            Accumulator = res;

            return res;
        }

        public double Modulus(double a, double b)
        {
            if (b == 0)
            {
                Accumulator = a % 1;

                return Accumulator;
            }

            Accumulator = a % b;

            return Accumulator;
        }

        public double Modulus(double a)
        {
            Accumulator = Modulus(Accumulator, a);

            return Accumulator;
        }

        public double AreaCircle(double a)
        {
            if (a < 0)
            {
                return 0;
            }

            Accumulator = Math.Pow(a, 2)*3.14;

            return Accumulator;
        }

        public double AreaCircle()
        {
            Accumulator = Math.Pow(Accumulator, 2) * Math.PI;

            return Accumulator;
        }
    }
}
