using oDataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace oDataSample
{
    public static class WebApiConfig
    {      

        public static void Register(HttpConfiguration config)
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Person>("Persons");
            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
