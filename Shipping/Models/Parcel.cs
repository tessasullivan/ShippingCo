using System;
using System.Collections.Generic;

namespace ShippingCo.Models 
{
  public class Parcel
  {
    private static List<Parcel> _instances = new List<Parcel>{};
    private int _length;
    private int _height;
    private int _width;
    private int _weight;

    public Parcel(int length, int height, int width, int weight)
    {
        _length = length;
        _height = height;
        _width = width;
        _weight = weight;
        _instances.Add(this);
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetHeight()
    {
        return _height;
    }
    public int GetWidth()
    {
        return _width;
    }
    public int GetWeight()
    {
        return _weight;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public void SetHeight(int height)
    {
        _height = height;
    }
    public void SetWidth(int width)
    {
        _width = width;
    }
    public void SetWeight(int weight)
    {
        _weight = weight;
    }
    public int CalculateVolume()
    {
        return _length * _width * _height;
    }
    public double CalculateShippingCost()
    {
        return _weight * 1.5;
    }
    public static List<Parcel> GetAll()
    {
       return _instances;
    }
  }
}