using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houston.HoustonBaza.Models
{
    class DefaultInfo
    {
        public static void Initialize (RampaDbContext context)
        {
            if(!context.Rampe.Any())
            {
                context.Rampe.AddRange(new Rampa("Kennedy Space Centre", "Titusville , Florida, USA"));
                context.SaveChanges();
            }
        }
    }
}
