using System;

namespace GalacticGPS
{
    struct Location
    {
        // Field
        private Double latitude;
        private Double longitude;
        private Planet planetName;

        // Property
        public Double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                // Check for correct values
                if ((value < 0d) || (value > 90d))
                {
                    throw new ArgumentException("Latitude cannot be less than 0 or higher than 90.");
                }
                else
                {
                    this.latitude = value;
                }
            }
        }

        public Double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                // Check for correct values
                if ((value < -180d) || (value > 180d))
                {
                    throw new ArgumentException("Longitude cannot be less than -180 or higher than 180.");
                }
                else
                {
                    this.longitude = value;
                }
            }
        }

        public Planet PlanetName
        {
            get;
            private set;
        }

        // Constructor
        public Location(Double latitude, Double longitude, Planet planetName)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetName = planetName;
        }

        // Method
        public String Output()
        {
            String output = String.Format("{0}, {1} Planet: {2}", this.Latitude, this.Longitude, this.PlanetName);
            return output;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.PlanetName);
        }
    }
}