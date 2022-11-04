using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_CT.Entities
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Band ın içine birden çok müzisyen
        public IList<Musician> BandMembers { get; set; }
        public Band()
        {
            BandMembers = new List<Musician>();
        }
    }
}
