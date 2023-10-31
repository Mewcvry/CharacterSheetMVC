using CharacterSheetMVC.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CharacterSheetMVC.ViewModels
{

    class Character : BaseViewModel
    {
        // Info
        public string CName
        {
            get { return cname; }
            set
            {
                cname = value;
                OnPropertyChanged(nameof(CName));
            }
        }

        private string cname = "Name";

        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                OnPropertyChanged(nameof(Info));
            }
        }

        private string info = "Info";

        public string Background
        {
            get { return background; }
            set
            {
                background = value;
                OnPropertyChanged(nameof(Background));
            }
        }

        private string background;

        public string Alignment
        {
            get { return alignment; }
            set
            {
                alignment = value;
                OnPropertyChanged(nameof(Alignment));
            }
        }

        private string alignment;

        public string Playername
        {
            get { return playername; }
            set
            {
                playername = value;
                OnPropertyChanged(nameof(Playername));
            }
        }

        private string playername;

        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }

        private string notes;

        public string ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        private string experiencePoints;

        public string HitDice
        {
            get { return hitDice; }
            set
            {
                hitDice = value;
                OnPropertyChanged(nameof(HitDice));
            }
        }

        private string hitDice;




        // Skills

        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                _dexterity = value;
                OnPropertyChanged(nameof(Dexterity));
            }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set
            {
                _constitution = value;
                OnPropertyChanged(nameof(Constitution));
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                _intelligence = value;
                OnPropertyChanged(nameof(Intelligence));
            }
        }

        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                _wisdom = value;
                OnPropertyChanged(nameof(Wisdom));
            }
        }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                _charisma = value;
                OnPropertyChanged(nameof(Charisma));
            }
        }



        // Proficiencys
        public string ArmorPro
        {
            get { return armorPro; }
            set
            {
                armorPro = value;
                OnPropertyChanged(nameof(ArmorPro));
            }
        }

        private string armorPro;

        public string WeaponsPro
        {
            get { return weaponsPro; }
            set
            {
                weaponsPro = value;
                OnPropertyChanged(nameof(WeaponsPro));
            }
        }

        private string weaponsPro;

        public string ToolsPro
        {
            get { return toolsPro; }
            set
            {
                toolsPro = value;
                OnPropertyChanged(nameof(ToolsPro));
            }
        }

        private string toolsPro;

        public string LanguagesPro
        {
            get { return languagesPro; }
            set
            {
                languagesPro = value;
                OnPropertyChanged(nameof(LanguagesPro));
            }
        }

        private string languagesPro;

        public string Defenses
        {
            get { return defenses; }
            set
            {
                defenses = value;
                OnPropertyChanged(nameof(Defenses));
            }
        }

        private string defenses;

        public string Conditions
        {
            get { return conditions; }
            set
            {
                conditions = value;
                OnPropertyChanged(nameof(Conditions));
            }
        }

        private string conditions;

        public string Advantages
        {
            get { return advantages; }
            set
            {
                advantages = value;
                OnPropertyChanged(nameof(Advantages));
            }
        }

        private string advantages = "Advantage Against: ";

        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                OnPropertyChanged(nameof(Speed));
            }
        }

        private int speed;

        public int Initiativ
        {
            get { return initiativ; }
            set
            {
                initiativ = value;
                OnPropertyChanged(nameof(Initiativ));
            }
        }

        private int initiativ;

        public int ArmorClass
        {
            get { return armorClass; }
            set
            {
                armorClass = value;
                OnPropertyChanged(nameof(ArmorClass));
            }
        }

        private int armorClass;

        public int CurrentHP
        {
            get { return currentHP; }
            set
            {
                currentHP = value;
                OnPropertyChanged(nameof(CurrentHP));
            }
        }

        private int currentHP = 0;

        public int TempHP
        {
            get { return tempHP; }
            set
            {
                tempHP = value;
                OnPropertyChanged(nameof(TempHP));
            }
        }

        private int tempHP = 0;

        public int MaxHP
        {
            get { return maxHP; }
            set
            {
                maxHP = value;
                OnPropertyChanged(nameof(MaxHP));
            }
        }

        private int maxHP = 0;

        public int Proficiency
        {
            get { return proficiency; }
            set
            {
                proficiency = value;
                OnPropertyChanged(nameof(Proficiency));
            }
        }

        private int proficiency;



        public List<Items> items = new List<Items>();

        private string _inventory;
        public string Inventory
        {
            get { return _inventory; }
            set
            {
                if (items.Count > 0)
                {
                    foreach (Items item in items)
                    {
                        _inventory += item.ToString + "\n";
                    }
                }
                else
                {
                    _inventory = value;
                }
                OnPropertyChanged(nameof(Inventory));
            }
        }


        public List<Attacks> attacks = new List<Attacks>();
        private string _allAttacks;
        public string AllAttacks
        {
            get { return _allAttacks; }
            set
            {
                if (attacks.Count > 0)
                {
                    foreach (Attacks attack in attacks)
                    {
                        _allAttacks += attack.ToString + "\n";
                    }
                }
                else
                {
                    _allAttacks = value;
                }

                OnPropertyChanged(nameof(AllAttacks));
            }
        }


        public List<Spells> spells = new List<Spells>();

        public string AttackExtras
        {
            get { return attackExtras; }
            set
            {
                attackExtras = value;
                OnPropertyChanged(nameof(AttackExtras));
            }
        }

        private string attackExtras = "Extras: ";


        // Additional Skills

        private bool _acrobatics = false;
        public bool Acrobatics
        {
            get { return _acrobatics; }
            set
            {
                _acrobatics = value;
                OnPropertyChanged(nameof(Charisma));
                EventManager.ProficiencyChanged();
            }
        }
        private bool _animalHandling = false;
        public bool AnimalHandling
        {
            get { return _animalHandling; }
            set
            {
                _animalHandling = value;
                OnPropertyChanged(nameof(AnimalHandling));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _arcana = false;
        public bool Arcana
        {
            get { return _arcana; }
            set
            {
                _arcana = value;
                OnPropertyChanged(nameof(Arcana));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _athletics = false;
        public bool Athletics
        {
            get { return _athletics; }
            set
            {
                _athletics = value;
                OnPropertyChanged(nameof(Athletics));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _deception = false;
        public bool Deception
        {
            get { return _deception; }
            set
            {
                _deception = value;
                OnPropertyChanged(nameof(Deception));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _history = false;
        public bool History
        {
            get { return _history; }
            set
            {
                _history = value;
                OnPropertyChanged(nameof(History));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _insight = false;
        public bool Insight
        {
            get { return _insight; }
            set
            {
                _insight = value;
                OnPropertyChanged(nameof(Insight));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _intimidation = false;
        public bool Intimidation
        {
            get { return _intimidation; }
            set
            {
                _intimidation = value;
                OnPropertyChanged(nameof(Intimidation));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _investigation = false;
        public bool Investigation
        {
            get { return _investigation; }
            set
            {
                _investigation = value;
                OnPropertyChanged(nameof(Investigation));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _medicine = false;
        public bool Medicine
        {
            get { return _medicine; }
            set
            {
                _medicine = value;
                OnPropertyChanged(nameof(Medicine));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _nature = false;
        public bool Nature
        {
            get { return _nature; }
            set
            {
                _nature = value;
                OnPropertyChanged(nameof(Nature));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _perception = false;
        public bool Perception
        {
            get { return _perception; }
            set
            {
                _perception = value;
                OnPropertyChanged(nameof(Perception));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _performance = false;
        public bool Performance
        {
            get { return _performance; }
            set
            {
                _performance = value;
                OnPropertyChanged(nameof(Performance));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _persuasion = false;
        public bool Persuasion
        {
            get { return _persuasion; }
            set
            {
                _persuasion = value;
                OnPropertyChanged(nameof(Persuasion));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _religion = false;
        public bool Religion
        {
            get { return _religion; }
            set
            {
                _religion = value;
                OnPropertyChanged(nameof(Religion));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _sleightOfHand = false;
        public bool SleightOfHand
        {
            get { return _sleightOfHand; }
            set
            {
                _sleightOfHand = value;
                OnPropertyChanged(nameof(SleightOfHand));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _stealth = false;
        public bool Stealth
        {
            get { return _stealth; }
            set
            {
                _stealth = value;
                OnPropertyChanged(nameof(Stealth));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _survival = false;
        public bool Survival
        {
            get { return _survival; }
            set
            {
                _survival = value;
                OnPropertyChanged(nameof(Survival));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _inspiration = false;
        public bool Inspiration
        {
            get { return _inspiration; }
            set
            {
                _inspiration = value;
                OnPropertyChanged(nameof(Inspiration));
                EventManager.ProficiencyChanged();
            }
        }

        // Saving Throws 

        private bool _strSavingThrow;
        public bool STRSavingThrow
        {
            get { return _strSavingThrow; }
            set
            {
                _strSavingThrow = value;
                OnPropertyChanged(nameof(STRSavingThrow));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _dexSavingThrow;
        public bool DEXSavingThrow
        {
            get { return _dexSavingThrow; }
            set
            {
                _dexSavingThrow = value;
                OnPropertyChanged(nameof(DEXSavingThrow));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _conSavingThrow;
        public bool CONSavingThrow
        {
            get { return _conSavingThrow; }
            set
            {
                _conSavingThrow = value;
                OnPropertyChanged(nameof(CONSavingThrow));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _intSavingThrow;
        public bool INTSavingThrow
        {
            get { return _intSavingThrow; }
            set
            {
                _intSavingThrow = value;
                OnPropertyChanged(nameof(INTSavingThrow));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _wisSavingThrow;
        public bool WISSavingThrow
        {
            get { return _wisSavingThrow; }
            set
            {
                _wisSavingThrow = value;
                OnPropertyChanged(nameof(WISSavingThrow));
                EventManager.ProficiencyChanged();
            }
        }

        private bool _chaSavingThrow;
        public bool CHASavingThrow
        {
            get { return _chaSavingThrow; }
            set
            {
                _chaSavingThrow = value;
                OnPropertyChanged(nameof(CHASavingThrow));
                EventManager.ProficiencyChanged();
            }
        }


        public bool[] DS_succ { get; set; }
        public bool[] DS_fail { get; set; }

    }
}
