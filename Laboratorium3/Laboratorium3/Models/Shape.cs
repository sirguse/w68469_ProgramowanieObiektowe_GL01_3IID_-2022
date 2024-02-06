﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium4.Models
{
    public abstract class Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Rysowanie figury...");
        }
    }
}
