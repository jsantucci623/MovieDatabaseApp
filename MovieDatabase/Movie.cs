using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public string title;
        public string category;

        // Constructor
        public Movie(string title, string category)
            {
              this.title = title;
              this.category = category;
            }
    }
}
