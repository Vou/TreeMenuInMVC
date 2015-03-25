using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class PinPaiForDisplay
    {
        public int PinPaiId { get; set; }
        public string PinPaiName { get; set; }
        public List<CheXiForDisplay> CheXis { get; set; }
    }
}