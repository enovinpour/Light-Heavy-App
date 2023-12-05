using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Api.Store.Models
{
    public class StoreRequest
    {
        public string Sort { get; set; }
        public int Limit { get; set; }
    }
}
