using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte UNKNOWN = 0;
        public static readonly byte PAYASYOUGO = 1;
        public static readonly byte MONTHLY = 2;
        public static readonly byte QUARTERLY = 3;
        public static readonly byte YEARLY = 4;

    }
}
