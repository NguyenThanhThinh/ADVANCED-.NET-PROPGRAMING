using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3.DTO
{
  public  class AirportEntity
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Country { set; get; }
        public string UtcTime { set; get; }
        public bool Deleted { set; get; }
        public bool Openning { set; get; }

        public AirportEntity()
        {
            Code = null;
            Name = null;
            City = null;
            State = null;
            Country = null;
            UtcTime = null;
            Deleted = false;
            Openning = false;
        }

        public AirportEntity(string code, string name, string city, string state, string country, string utctime)
        {
            Code = code;
            Name = name;
            City = city;
            State = state;
            Country = country;
            UtcTime = utctime;
            Deleted = false;
            Openning = true;
        }
        public AirportEntity(string code, string name, string city, string state, string country, string utctime, bool deleted = false, bool openning = true)
        {
            Code = code;
            Name = name;
            City = city;
            State = state;
            Country = country;
            UtcTime = utctime;
            Deleted = deleted;
            Openning = openning;
        }

        public override string ToString()
        {
            return String.Format("CODE: {0}; Name: {1}; City: {2}; State: {3}; Country: {4}; UTC Time: {5}; Is Openning: {6}",
                Code, Name, City, State, Country, UtcTime, Openning == true ? "Yes" : "No");
        }

    }
}
