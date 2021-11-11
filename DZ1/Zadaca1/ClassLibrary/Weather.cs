using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;

        public double Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }

        public double Humidity
        {
            get { return this.humidity; }
            set { this.humidity = value; }
        }

        public double WindSpeed
        {
            get { return this.windSpeed; }
            set { this.windSpeed = value; }
        }

        public Weather(double Temperature, double Humidity, double WindSpeed)
        {
            this.Temperature = Temperature;
            this.Humidity = Humidity;
            this.WindSpeed = WindSpeed;
        }

        public void SetTemperature(double temperatura)
        {
            Temperature = temperatura;
        }

        public void SetWindSpeed(double brzinaVjetra)
        {
            WindSpeed = brzinaVjetra;
        }

        public void SetHumidity(double vlaznost)
        {
            Humidity = vlaznost;
        }


        public double GetTemperature()
        {
            return Temperature;
        }

        public double GetWindSpeed()
        {
            return WindSpeed;
        }

        public double GetHumidity()
        {
            return Humidity;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double c1 = -8.78469475556, c2 = 1.61139411, c3 = 2.33854883889, c4 = -0.14611605, c5 = -0.012308094, c6 = -0.0164248277778, c7 = 0.002211732, c8 = 0.00072546, c9 = -0.000003582;
            double HI;
            HI = c1 + (c2 * Temperature) + (c3 * Humidity) + (c4 * Temperature * Humidity) + (c5 * (Temperature * Temperature)) + (c6 * (Humidity * Humidity)) + (c7 * (Temperature * Temperature) * Humidity) + (c8 * Temperature * (Humidity * Humidity)) + (c9 * (Humidity * Humidity) * (Temperature * Temperature));
            return HI;
        }

        public double CalculateWindChill()
        {
            double WCI;
            WCI = 13.12 + (0.6215 * Temperature) - (11.37 * (Math.Pow(WindSpeed, 0.16))) + (0.3965 * Temperature * (Math.Pow(WindSpeed, 0.16)));
            if (temperature < WCI)
            {
                WCI = 0.0;
            }
            return WCI;
        }
    }
}
