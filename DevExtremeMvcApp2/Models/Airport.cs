using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp2.Models
{
    public class Airport
    {
        [Key]
        public long id { get; set; }
        public string ident { get; set; }
        public AirportType type { get; set; }
        public string name { get; set; }
        public decimal latitude_deg { get; set; }
        public decimal longitude_deg { get; set; }   
        public Int32? elevation_ft { get; set; } 
        public string continent { get; set; }
        public string iso_country { get; set; }
        public string iso_region { get; set; }
        public string municipality { get; set; } 
        public bool scheduled_service { get; set; }   
        public string gps_code { get; set; } 
        public string iata_code { get; set; }   
        public string local_code { get; set; }
        public string home_link { get; set; }   
        public string wikipedia_link { get; set; }
        public string keywords { get; set; }

    }
}