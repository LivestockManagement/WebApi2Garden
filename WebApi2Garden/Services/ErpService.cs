using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2Garden.Services.Entities;

namespace WebApi2Garden.Services
{
    // A fake class that potentially utilise a WCF Service Reference.
    public class ErpService
    {

        private List<Erp> Erps;

        public ErpService()
        {
            Erps = new List<Erp>();
            for (int x = 1; x < 10; x++ )
            {
                Add(new Erp() { Description = string.Format("Erp Description {0}", x) });
            }
        }

        public void Add(Erp erp)
        {
            erp.Id = Erps.Count() + 1;
            Erps.Add(erp);
        }

        public IEnumerable<Erp> Get()
        {
            return Erps;
        }

        public Erp Get(int id)
        {
            return Erps.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}