using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack.DataAnnotations;

namespace Kohsaar.Model.Entity
{
    [Alias("Textile")]
    public class Textile
    {
        [PrimaryKey]
        [Alias("Id")]
        public System.Int64 Id { get; set; }
        [Alias("Name")]
        public System.String Name { get; set; }
    }
}
