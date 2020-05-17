using System;
using System.Drawing;

public class Molecula
{
    private double Temperature;
    private double Weight;

    private int X; 
    private int Y;
    public double vectorX;
    public double vectorY;

    public Molecula()
    {
       
    }

    public Molecula(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Molecula(int x, int y, double tempr)
    {
        X = x;
        Y = y;
        Temperature = tempr;
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
}
