using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    abstract class Planet
    {
        //Private Varibles 
        private double _diameter;
        private double _mass;
        private double _orbitalPeriod;
        private double _rotationPeriod;
        private int _moonCount;
        private int _ringCount;
        private string _name; 

        //Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._diameter;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod ;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        //Constructor Method
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._mass = mass;
            this._diameter = diameter;
        }

        public override string ToString()
        {
            return this.Name + " has the diameter of " + this.Diameter + " kilometers and a mass of " + this.Mass + " tonnes.";
        }
    }
}
