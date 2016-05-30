using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTCAppNew {

    /// <summary>
    /// TEST CLASS! This is just to see if I can create objects from an outside class.
    /// Represents the different major "categories" that exist on the home screen,
    /// consisting of: general info, programs/degrees, map, directory, student email, Canvas/grades.
    /// </summary>
    public class Categories {
        
        public Categories() {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int ListIndex { get; set; }
        public List<int> Id { get; set; }
        
    }
}
