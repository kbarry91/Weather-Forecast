﻿// Author : G00339811
// Module : Mobile Application Developement 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{

    public class Main
    {
        public double Temp { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public double Pressure { get; set; }
        public double Sea_level { get; set; }
        public double Grnd_level { get; set; }
        public int Humidity { get; set; }
        public double Temp_kf { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public override string ToString()
        {

            return Description;
        }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }

    }
    public class Rain
    {
        public double? __invalid_name__3h { get; set; }
    }

    public class Snow
    {
        public double __invalid_name__3h { get; set; }
    }

    public class Sys
    {
        public string Pod { get; set; }
    }

    public class List
    {
        public int Dt { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Sys Sys { get; set; }
        public string Dt_txt { get; set; }

        public override string ToString()
        {

            var myStr = "";
            foreach (var myWeather in Weather)
            {
                myStr = myStr + Main.ToString() + Dt_txt + " " + myWeather.ToString();
            }
            return myStr + Main.ToString();
        }
    }

    public class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
    }

    public class RootObject
    {
        public string Cod { get; set; }
        public double Message { get; set; }
        public int Cnt { get; set; }
        public List<List> List { get; set; }
        public City City { get; set; }
        public Coord Coord { get; set; }

        public override string ToString()
        {
            var count = 0;
            var myStr = "";
            foreach (var mylist in List)
            {
                count++;
                myStr = myStr + mylist.ToString() + " c " + count + "\n";
            }
            return myStr;
        }
    }
}
