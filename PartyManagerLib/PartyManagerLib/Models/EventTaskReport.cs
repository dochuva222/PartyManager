using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManagerLib.Models
{
    public class EventTaskReport
    {
        public int Id { get; set; }
        public int EventTaskId { get; set; }
        public string Photo { get; set; }
        public string Message { get; set; }

    }
}
