using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebApi2Garden.Services.Entities;

namespace WebApi2Garden.Models
{
    public class ModelFactory
    {
        private WebApiUrlHelper _WebApiUrlHelper;

        public ModelFactory(HttpRequestMessage request)
        {
            if (request == null)
            {
                _WebApiUrlHelper = new WebApiUrlHelper();
            }
            else
            {
                _WebApiUrlHelper = new WebApiUrlHelper(request);
            }

        }

        public ErpModel Create(Erp erp)
        {
            return new ErpModel() { 
                Id = erp.Id, 
                Description = erp.Description,
                Url = _WebApiUrlHelper.Link("erp", new { Id = erp.Id })
            };
        }
    }
}