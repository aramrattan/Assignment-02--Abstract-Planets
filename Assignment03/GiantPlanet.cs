using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class GiantPlanet: Planet
    {
        //Private Varibles
        private string _type;

        //Constructor Method
        public GiantPlanet(string name, double diameter, double mass, string type) : base( name, diameter, mass)
        {
            this._type = type;

        }

        //Public Method
        public bool HasMoons()
        {
           bool moon;
            
            if (MoonCount >0)
            {
                moon = true;
            }
            else 
            {
                moon = false;
            }
            return moon;
        }

        public bool HasRings()
        {
            bool rings;
            if (RingCount > 0)
            {
                rings = true;
            }
            else
            {
                rings = false;
            }
            return rings;
        }
    }
}
