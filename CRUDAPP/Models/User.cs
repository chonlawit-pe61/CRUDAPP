using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAPP.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
    }
}