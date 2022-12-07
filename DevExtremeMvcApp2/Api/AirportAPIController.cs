using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeMvcApp2.DAL;
using DevExtremeMvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DevExtremeMvcApp2.ApiControllers
{
    public class AirportAPIController : System.Web.Http.ApiController
    {
        AirportContext db = new AirportContext();
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(GenerateData(), loadOptions));
        }

        private IEnumerable<object> GenerateData()
        {
            List<Airport> Airports = db.Airports.ToList<Airport>();
            return Airports;
        }
    }
}