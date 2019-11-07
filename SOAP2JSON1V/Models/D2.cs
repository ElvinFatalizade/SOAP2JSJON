using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAP2JSON1V.Models
{
    public class D2
    {
        public int Id { get; set; }

        public int D1Id{ get; set; }

        public TimeSpan INSERT_DATE { get; set; }

        public ICloneable VALUE { get; set; }

        public D1 D1 { get; set; }
    }
}