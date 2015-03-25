using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class PinPaiCheXiForDisplay
    {
        public string FirstLetter { get; set; }
        public string Anchor { get; set; }
        public List<PinPaiForDisplay> PinPais { get; set; }
    }
}