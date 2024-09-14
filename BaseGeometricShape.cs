using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    public class BaseGeometricShape // Base class, BaseGeometricShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public virtual double CalculateArea() // Virtual method, CalculateArea
        { 
            return Width * Height;
        }
    }
     
    public class Rectangle : BaseGeometricShape // Rectangle inherited from BaseGeometricShape
    {      
    }

    public class  Square : BaseGeometricShape // Square inherited from BaseGeometricShape
    {
    }

    public class RighTriangle : BaseGeometricShape // RightTriangle inherited from BaseGeometricShape
    {
        public override double CalculateArea() // Override method
        {
            return base.CalculateArea() / 2;
        }
    }
}
