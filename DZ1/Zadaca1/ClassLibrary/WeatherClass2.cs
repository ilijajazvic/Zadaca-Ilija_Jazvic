using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace ConsoleApp
{
    public static class WeatherClass2
    {
        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            int i,index=0;
            double max = weathers[0].CalculateWindChill();
            for (i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > max)
                {
                    index = i;
                    max = weathers[i].CalculateWindChill();                  
                }
            }
            return weathers[index];
        }
    }
}
