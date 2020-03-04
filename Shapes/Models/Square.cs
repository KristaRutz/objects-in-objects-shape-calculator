using System;

namespace Shapes.Models
{
  public class Square : Rectangle
  {
    public Square(int side) : base(side, side)
    {
      Length = side;
      Width = side;
    }
  }
}