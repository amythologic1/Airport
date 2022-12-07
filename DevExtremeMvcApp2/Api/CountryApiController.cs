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
    public class CountryAPIController : System.Web.Http.ApiController
    {
        CountryContext db = new CountryContext();
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(GenerateData(), loadOptions));
        }

        private IEnumerable<object> GenerateData()
        {
            List<Country> Countries = db.Countries.ToList();
            return Countries;
        }
    }
}