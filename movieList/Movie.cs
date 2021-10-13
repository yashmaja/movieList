using System;
using System.Collections.Generic;
using System.Text;

namespace movieList
{
    class Movie
    {
        public string Name;
        public string Category;

        //constructor
        public Movie(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
