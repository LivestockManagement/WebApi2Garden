using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Garden.Models;
using WebApi2Garden.Services;
using WebApi2Garden.Services.Entities;

namespace WebApi2Garden.Controllers
{
    [RoutePrefix("api/erp")]
    public class ErpController : ApiController
    {
        private ErpService _ErpService;
        private ModelFactory _modelFactory;
        protected ModelFactory _ModelFactory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(this.Request);
                }
                return _modelFactory;
            }

        }

        public ErpController(ErpService erpService)
        {
            _ErpService = erpService;
        }

        // GET api/erp
        [Route("")]
        public IEnumerable<ErpModel> Get()
        {
            IEnumerable<Erp> erps = _ErpService.Get();
            return erps.Select(x => _ModelFactory.Create(x));
        }

        // GET api/erp/5
        [Route("{id}", Name="Erp" )]
        public ErpModel Get(int id)
        {
            return _ModelFactory.Create(_ErpService.Get(id));
        }

        // POST api/erps
        public void Post([FromBody]string value)
        {
        }

        // PUT api/erp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/erp/5
        public void Delete(int id)
        {
        }
    }
}
