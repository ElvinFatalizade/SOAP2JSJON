using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAP2JSON1V.Models
{
    public class D1
    {
        public int Id { get; set; }

        public TimeSpan INSERT_DATE { get; set; }

        List<D2> D2s { get; set; }
    }
}