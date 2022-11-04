using Ank9_EF_Entities_CT.Entities;

namespace Ank9_MvcUI_PlakDukkani_CT.ViewModels
{
    public class NewBand
    {
        public string Name { get; set; }

        public Band GetBand()
        {
            return new Band()
            {
                Name = this.Name
            };
        }
    }
}
