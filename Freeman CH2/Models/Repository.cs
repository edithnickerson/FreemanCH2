using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreemanCH2.Models
{
    public class Repository
    {
        public static IEnumerable<object> Responses { get; internal set; }

        internal static void AddResponse(GuestResponse guestResponse)
        {
            throw new NotImplementedException();
        }
    }
}
