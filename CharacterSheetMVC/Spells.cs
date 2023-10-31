using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetMVC
{
    public class Spells : Attacks
    {
        public string Time { get; set; }
        public int Level { get; set; }
    }
}
