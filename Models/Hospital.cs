using System;
using System.Collections.Generic;

#nullable disable

namespace covid_backend.Models
{
    public partial class Hospital
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Fid { get; set; }
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public int? Zip4 { get; set; }
        public string Telephone { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int? Population { get; set; }
        public string County { get; set; }
        public int? Countyfips { get; set; }
        public string Country { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? NaicsCode { get; set; }
        public string NaicsDesc { get; set; }
        public string Source { get; set; }
        public string Sourcedate { get; set; }
        public string ValMethod { get; set; }
        public string ValDate { get; set; }
        public string Website { get; set; }
        public string StateId { get; set; }
        public string AltName { get; set; }
        public int? StFips { get; set; }
        public string Owner { get; set; }
        public int? TtlStaff { get; set; }
        public int? Beds { get; set; }
        public string Trauma { get; set; }
        public char Helipad { get; set; }
    }
}
