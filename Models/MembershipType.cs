using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FIRST_PROJECT.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonts { get; set; }
        public byte DiscountRate { get; set; }
    }
}