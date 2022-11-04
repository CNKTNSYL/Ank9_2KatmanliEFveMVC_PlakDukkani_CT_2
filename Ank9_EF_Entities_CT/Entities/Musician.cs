using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_CT.Entities
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Bire çok
        public int BandId { get; set; }
        public Band Band { get; set; }

        //Çoka çok
        //public IList<Band> Bands { get; set; }
        //public Musician()
        //{
        //    Bands = new List<Band>();
        //}
    }
}
