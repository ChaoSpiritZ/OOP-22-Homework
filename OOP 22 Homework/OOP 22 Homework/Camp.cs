using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_22_Homework
{
    class Camp
    {
        private readonly int id;
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public int NumberOfPeople { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFleshLights { get; private set; }
        private static int lastCampId = 0;

        public Camp(double latitude, double longitude, int numberOfPeople, int numberOfTents, int numberOfFleshLights)
        {
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLights;
            lastCampId++;
            id = lastCampId;
        }

        public static bool operator ==(Camp c1, Camp c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
            {
                return true;
            }

            if(ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            if(c1.id == c2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >(Camp c1, Camp c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
            {
                return false;
            }

            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            if(c1.NumberOfPeople > c2.NumberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Camp c1, Camp c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
            {
                return false;
            }

            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            if(c1.NumberOfPeople < c2.NumberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object o)
        {
            Camp other = o as Camp;
            return (this == other);
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public static Camp operator +(Camp c1, Camp c2)
        {
            Camp biggerCamp = new Camp(c1.Latitude, c1.Longitude, c1.NumberOfPeople + c2.NumberOfPeople, c1.NumberOfTents + c2.NumberOfTents, c1.NumberOfFleshLights + c2.NumberOfFleshLights);
            return biggerCamp;
        }


        public override string ToString()
        {
            return $"Camp --- Latitude: {Latitude}, Longitude: {Longitude}, Number of people: {NumberOfPeople}, Number of tents: {NumberOfTents}, Number of FleshLights: {NumberOfFleshLights}";
        }
    }
}
