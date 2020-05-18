using System;
using System.Drawing;

namespace PhisicExperiments
{
    public class Molecula
    {
        private double Temperature;

        private int X;
        private int Y;
        private Vector vector;

        public Molecula()
        {

        }

        public Molecula(Point p, double t, Vector v)
        {
            X = p.X;
            Y = p.Y;
            Temperature = t;
            vector = v;
        }

        public double GetTemperature()
        {
            return Temperature;
        }

        public void SetTemperature(double tempr)
        {
            Temperature = tempr;
        }

        public void SetLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SetLocation(Point p)
        {
            SetLocation(p.X, p.Y);
        }

        public Point GetLocation()
        {
            return new Point(X, Y);
        }

        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }

        public void SetVector(Vector v)
        {
            vector = v;
        }

        public Vector GetVector()
        {
            return vector;
        }
    }

}