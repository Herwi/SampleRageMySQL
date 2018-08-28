using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRageMySQL.Models
{
    public partial class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string salt { get; set; }
        public string password { get; set; }
    }
}
