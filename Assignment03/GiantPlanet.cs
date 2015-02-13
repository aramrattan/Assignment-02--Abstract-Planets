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

    }
}
