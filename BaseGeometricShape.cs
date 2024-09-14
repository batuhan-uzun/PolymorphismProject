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
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual int CalculateArea() // Virtual method, CalculateArea
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
        public override int CalculateArea() // Override method
        {
            return base.CalculateArea() / 2;
        }
    }
}
