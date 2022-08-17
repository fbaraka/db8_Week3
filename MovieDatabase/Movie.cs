using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string TItle;
        public string Category;

        public Movie(string _Title, string _Category)
        {
            TItle = _Title;
            Category = _Category;
        }

        public override string ToString()
        {
            return $"{TItle} ({Category})";

        }

    }
}
