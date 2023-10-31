using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetMVC
{
    delegate void StrengthChanged();
    delegate void DexterityChanged();
    delegate void ConstitutionChanged();
    delegate void IntelligenceChanged();
    delegate void WisdomChanged();
    delegate void CharismaChanged();

    delegate void ProficiencyChanged();

    internal class EventManager
    {
        internal static event StrengthChanged OnStrengthChanged;
        internal static event DexterityChanged OnDexterityChanged;
        internal static event ConstitutionChanged OnConstitutionChanged;
        internal static event IntelligenceChanged OnIntelligenceChanged;
        internal static event WisdomChanged OnWisdomChanged;
        internal static event CharismaChanged OnCharismaChanged;
                 
        internal static event ProficiencyChanged OnProficiencyChanged;


        internal void StrengthChanged()
        {
            OnStrengthChanged();
        }
        internal void DexterityChanged()
        {
            OnDexterityChanged();
        }
        internal void ConstitutionChanged()
        {
            OnConstitutionChanged();
        }
        internal void IntelligenceChanged()
        {
            OnIntelligenceChanged();
        }
        internal void WisdomChanged()
        {
            OnWisdomChanged();
        }
        internal void CharismaChanged()
        {
            OnCharismaChanged();
        }

        internal static void ProficiencyChanged()
        {
            OnProficiencyChanged();
        }
    }
}
