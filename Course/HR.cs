using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    abstract public class HR:HRD
    {
        protected  int numberOfCameras;
        protected int freezerVolume;
        public string freezerLocation {get;set;}

        public int NumberOfCameras
        {
            get { return numberOfCameras; }
            set { if (value <= 0) value = 1; numberOfCameras = value; }
        }
        public int FreezerVolume
        {
            get { return freezerVolume; }
            set { if (value <= 0) value = 1; freezerVolume = value; }
        }
        public HR(Dimensions d, string color, double weight, int prise, string producingCountry, string title, 
            double percent, int numberOfCameras, int freezerVolume, string freezerLocation):base(d,color,weight,prise,producingCountry,title,percent)
        {
            this.numberOfCameras = numberOfCameras;
            this.freezerLocation = freezerLocation;
            this.freezerVolume = freezerVolume;

        }
        public HR()
        { }
        public override List<string> HRDChar()
        {

            List<string> s = base.HRDChar();
            s.Add(freezerLocation);
            s.Add(Convert.ToString(freezerVolume));
            s.Add(Convert.ToString(numberOfCameras));
            return s;
        }
        
    }
}
