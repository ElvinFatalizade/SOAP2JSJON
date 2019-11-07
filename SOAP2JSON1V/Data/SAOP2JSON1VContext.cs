using SOAP2JSON1V.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SOAP2JSON1V.Data
{
    public class SAOP2JSON1VContext : DbContext
    {
        public SAOP2JSON1VContext() : base("SAOP2JSON1VContext")
        {

        }
        DbSet<D1> D1s {get;set;}

        DbSet<D2> D2s { get; set; }
    }
}