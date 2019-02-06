using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Kohsaar.Model.DTO.Catalog;
using Kohsaar.Model.Entity;
using ServiceStack.OrmLite.Legacy;
using ServiceStack.OrmLite;

namespace Kohsaar.Service
{
    public class TextileService : ServiceStack.Service
    {
        public async Task<object> Get(GetTextileSample request)
        {
            return new GetTextileSampleResponse() { Samples = await Db.SelectAsync<Sample>() };
        }
    }
}
