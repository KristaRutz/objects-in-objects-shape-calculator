using System;

namespace Shapes.Models
{
  public class Triangle
  {
    public int BaseLength { get; set; }
    public int Height { get; set; }

    public Triangle(int baseLength, int height)
    {
      BaseLength = baseLength;
      Height = height;
    }

    public int GetArea()
    {
      return BaseLength * Height / 2;
    }
  }
}