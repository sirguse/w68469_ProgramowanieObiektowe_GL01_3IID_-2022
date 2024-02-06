using System;
using Laboratorium4.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle()
            
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}