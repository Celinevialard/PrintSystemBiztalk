using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuotaReturn
    {
        public string username { get; set; }
        public int quota { get; set; }

        public Guid requestId { get; set; }
    }
}
