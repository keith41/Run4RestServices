using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Run4RestServices.Models
{
    public class MemberDTO
    {
        public string memberFirstName { get; set; }
        public string memberLastName { get; set; }
        public string memberAddress { get; set; }
        public string memberCity { get; set; }
        public string memberState { get; set; }
        public string memberZip { get; set; }
    }
}