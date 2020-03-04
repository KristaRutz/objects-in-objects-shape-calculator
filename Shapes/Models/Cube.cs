using System;
namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set; }
    public Cube(Rectangle face)
    {
      Face = face;
    }

    public int GetVolume()
    {
      int length = Face.Length;
      return Convert.ToInt32(Math.Pow(Convert.ToDouble(length), 3));
    }

    public int GetSurfaceArea()
    {
      return Face.GetArea() * 6;
    }
  }
}