using System;

namespace ComplexNumbers
{
    class Complex
    {
        double _real;
        double _image;

        public Complex(double r, double i)
        {
            _real = r;
            _image = i;
        }

        public static Complex Add(Complex z1, Complex z2)
        {
            return new Complex(z1._real + z2._real, z1._image + z2._image);
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return Add(z1, z2);
        }

        public static Complex Substract(Complex z1, Complex z2)
        {
            return new Complex(z1._real - z2._real, z1._image - z2._image);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return Substract(z1, z2);
        }

        public static Complex Multiply(Complex z1, Complex z2)
        {
            return new Complex(z1._real * z2._real - z1._image * z2._image, z1._real * z2._image + z2._real * z1._image);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return Multiply(z1, z2);
        }

        public static Complex Division(Complex z1, Complex z2)
        {
            return new Complex((z1._real * z2._real + z1._image * z2._image) / (z2._real * z2._real + z2._image * z2._image), (z2._real * z1._image - z1._real * z2._image) / (z2._real * z2._real + z2._image * z2._image));
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            return Division(z1, z2);
        }

        public Complex Power(int n)
        {
            Complex result = new Complex(1, 0);
            for (int i = 0; i < n; i++)
            {
                result = result * new Complex(_real, _image);
            }
            return result; 
        }

        public double Abs()
        {
            return Math.Sqrt(_real * _real + _image * _image);
        }

        public double Angle()
        {
            return Math.Atan(_image / _real);
        }

        public override string ToString()
        {
            return $"{_real}+{_image}i";
        }
    }
}