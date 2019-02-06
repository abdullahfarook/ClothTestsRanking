using System;
using System.Collections.Generic;
using System.Text;
using Kohsaar.Model.Entity;
using ServiceStack;

namespace Kohsaar.Model.DTO.Catalog
{
    [Route("/textile/samples", "GET")]
    public class GetTextileSample : IReturn<GetTextileSampleResponse>
    {
    }

    public class GetTextileSampleResponse
    {
        //  public List<Sampling> Samples { get; set; }
        public List<Sample> Samples { get; set; }

    }

    public class Sampling
    {
        public string Name { get; set; }
        public float Value { get; set; }

    }
}
