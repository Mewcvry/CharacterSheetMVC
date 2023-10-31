using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetMVC
{
    public class Attacks
    {
        public string Name { get; set; }
        public string Range { get; set; }
        public int HitDC { get; set; }
        public string Damage { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"{Name}, Range: {Range}, Hit/DC: {HitDC}, Dmg: {Damage}\nNotes: {Notes}";
        }
    }
}
