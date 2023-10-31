using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetMVC
{
    public class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Name}, Amount: {Amount}, Weight: {Weight} lbs\n{Description}";
        }
    }
}
