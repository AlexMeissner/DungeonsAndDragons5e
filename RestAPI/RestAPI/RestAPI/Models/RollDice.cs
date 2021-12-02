using System.Collections.Generic;

namespace RestAPI.Models
{
    public class RollDice
    {
        public int Result { get; set; }
        public List<bool> Results { get; set; }
    }
}