
namespace ClassInSeperateFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;





   
    
        // Replace "internal" with "public"
        internal class Rectangle
        {

        public static int Count = 0; // static means that it is only unique to this class. 
            
            public string Name;
            public decimal Length;
            public decimal Height;

            public Rectangle(string _Name, decimal _Length, decimal _Height)
            {
                Rectangle.Count++;
                Name = _Name;
                Length = _Length;
                Height = _Height;
            }

            // To add a ToString, start typing public override
            // and then remove auto code 

            public override string ToString()
            {
                return $"{Name}: Length {Length} Height{Height}Area: {Length * Height} Perimeter: {2 * Length + 2 * Height}";
                ;
            }

        }
    }


