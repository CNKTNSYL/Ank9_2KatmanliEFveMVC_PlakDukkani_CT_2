using Ank9_EF_Entities_CT.Entities;

namespace Ank9_MvcUI_PlakDukkani_CT.ViewModels
{
    public class NewMusician
    {
        public string Name { get; set; }

        public int BandId { get; set; }

        public Musician GetMusician()
        {
            return new Musician
            {
                Name = this.Name,
                BandId = this.BandId
            };
        }
    }
}
