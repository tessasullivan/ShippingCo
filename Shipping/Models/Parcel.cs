using System;
using System.Collections.Generic;

namespace Parcel.Models 
{
  public class Parcel
  {
    private static List<Parcel> _instances = new List<Parcel>{};
    private int _length;
    private int _width;
    private int _weight;

    public Parcel(int length, int width, int weight)
    {
        _length = length;
        _width = width;
        _weight = weight;
        _instances.Add(this);
    }
    public int GetLength()
    {
        return _length;
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
    public void SetWidth(int width)
    {
        _width = width;
    }
    public void SetWeight(int weight)
    {
        _weight = weight;
    }
  }
}