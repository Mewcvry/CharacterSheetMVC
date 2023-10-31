using CharacterSheetMVC.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterSheetMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EventManager events;
        private Character character;

        public MainWindow()
        {
            InitializeComponent();
            character = new Character();
            this.DataContext = character;
            events = new EventManager();

            EventManager.OnStrengthChanged += UpdateStrengthSkills;
            EventManager.OnDexterityChanged += UpdateDexteritySkills;
            EventManager.OnConstitutionChanged += UpdateConstitutionSkills;
            EventManager.OnIntelligenceChanged += UpdateIntelligenceSkills;
            EventManager.OnWisdomChanged += UpdateWisdomSkills;
            EventManager.OnCharismaChanged += UpdateCharismaSkills;

            EventManager.OnProficiencyChanged += UpdateStrengthSkills;
            EventManager.OnProficiencyChanged += UpdateDexteritySkills;
            EventManager.OnProficiencyChanged += UpdateConstitutionSkills;
            EventManager.OnProficiencyChanged += UpdateIntelligenceSkills;
            EventManager.OnProficiencyChanged += UpdateWisdomSkills;
            EventManager.OnProficiencyChanged += UpdateCharismaSkills;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != null)
            {
                string path = openFileDialog.FileName;


                string[] heading = { "CName" ,"Info", "Background", "Alignment" ,"Playername" ,"Notes" ,"ExperiencePoints" ,"HitDice" ,"Strength" ,
                    "Dexterity" ,"Constitution" ,"Intelligence" ,"Wisdom" ,"Charisma" ,"ArmorPro","WeaponsPro","ToolsPro","LanguagesPro" ,"" +
                    "Defenses" ,"Conditions" ,"Advantages" ,"Speed" ,"Initiativ" ,"ArmorClass" ,"CurrentHP" ,"TempHP" ,"MaxHP" ,"Proficiency" ,"" +
                    "Inventory" ,"AllAttacks" ,"AttackExtras" ,"Acrobatics" ,"AnimalHandling" ,"Arcana" ,"Athletics" ,"" +
                    "Deception" ,"History" ,"Insight" ,"Intimidation" ,"Investigation" ,"Medicine" ,"Nature" ,"Perception" ,"Performance" ,"Persuasion" ,"" +
                    "Religion" ,"SleightOfHand" ,"Stealth" ,"Survival" ,"Inspiration" ,"STRSavingThrow" ,"DEXSavingThrow" ,"CONSavingThrow" ,"INTSavingThrow" ,"" +
                    "WISSavingThrow" ,"CHASavingThrow"};

                char seperator = ';';

                StringBuilder output = new StringBuilder();

                output.AppendLine(string.Join(seperator, heading));

                string[] charactertext = { character.CName, character.Info, character.Background, character.Alignment, character.Playername,
                character.Notes, character.ExperiencePoints, character.HitDice, character.Strength.ToString(), character.Dexterity.ToString(),
                character.Constitution.ToString(),character.Intelligence.ToString(), character.Wisdom.ToString(), character.Charisma.ToString(),
                character.ArmorPro, character.WeaponsPro, character.ToolsPro,character.LanguagesPro, character.Defenses, character.Conditions,
                character.Advantages, character.Speed.ToString(), character.Initiativ.ToString(), character.ArmorClass.ToString(), character.CurrentHP.ToString(),
                character.TempHP.ToString(), character.MaxHP.ToString(), character.Proficiency.ToString(), character.Inventory,
                character.AllAttacks, character.AttackExtras, character.Acrobatics.ToString(),character.AnimalHandling.ToString(), character.Arcana.ToString(),
                character.Athletics.ToString(), character.Deception.ToString(), character.History.ToString(), character.Insight.ToString(),
                character.Intimidation.ToString(), character.Investigation.ToString(), character.Medicine.ToString(), character.Nature.ToString(),
                character.Perception.ToString(), character.Performance.ToString(), character.Persuasion.ToString(), character.Religion.ToString(),
                character.SleightOfHand.ToString(), character.Stealth.ToString(), character.Survival.ToString(), character.Inspiration.ToString(),
                character.STRSavingThrow.ToString(), character.DEXSavingThrow.ToString(), character.CONSavingThrow.ToString(), character.INTSavingThrow.ToString(),
                character.WISSavingThrow.ToString(), character.CHASavingThrow.ToString()
                };

                output.AppendLine(string.Join(seperator, charactertext));

                File.AppendAllText(path, output.ToString());
            }
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != null)
            {
                string path = openFileDialog.FileName;

                string[] source = File.ReadAllLines(path)[1].Split(';');

                character.CName = source[0];
                character.Info = source[1];
                character.Background = source[2];
                character.Alignment = source[3];
                character.Playername = source[4];
                character.Notes = source[5];
                character.ExperiencePoints = source[6];
                character.HitDice = source[7];
                character.Strength = int.Parse(source[8]);
                character.Dexterity = int.Parse(source[9]);
                character.Constitution = int.Parse(source[10]);
                character.Intelligence = int.Parse(source[11]);
                character.Wisdom = int.Parse(source[12]);
                character.Charisma = int.Parse(source[13]);
                character.ArmorPro = source[14];
                character.WeaponsPro = source[15];
                character.ToolsPro = source[16];
                character.LanguagesPro = source[17];
                character.Defenses = source[18];
                character.Conditions = source[19];
                character.Advantages = source[20];
                character.Speed = int.Parse(source[21]);
                character.Initiativ = int.Parse(source[22]);
                character.ArmorClass = int.Parse(source[23]);
                character.CurrentHP = int.Parse(source[24]);
                character.TempHP = int.Parse(source[25]);
                character.MaxHP = int.Parse(source[26]);
                character.Proficiency = int.Parse(source[27]);
                character.Inventory = source[28];
                character.AllAttacks = source[29];
                character.AttackExtras = source[30];
                character.Acrobatics = bool.Parse(source[31]);
                character.AnimalHandling = bool.Parse(source[32]);
                character.Arcana = bool.Parse(source[33]);
                character.Athletics = bool.Parse(source[34]);
                character.Deception = bool.Parse(source[35]);
                character.History = bool.Parse(source[36]);
                character.Insight = bool.Parse(source[37]);
                character.Intimidation = bool.Parse(source[38]);
                character.Investigation = bool.Parse(source[39]);
                character.Medicine = bool.Parse(source[40]);
                character.Nature = bool.Parse(source[41]);
                character.Perception = bool.Parse(source[42]);
                character.Performance = bool.Parse(source[43]);
                character.Persuasion = bool.Parse(source[44]);
                character.Religion = bool.Parse(source[45]);
                character.SleightOfHand = bool.Parse(source[46]);
                character.Stealth = bool.Parse(source[47]);
                character.Survival = bool.Parse(source[48]);
                character.Inspiration = bool.Parse(source[49]);
                character.STRSavingThrow = bool.Parse(source[50]);
                character.DEXSavingThrow = bool.Parse(source[51]);
                character.CONSavingThrow = bool.Parse(source[52]);
                character.INTSavingThrow = bool.Parse(source[53]);
                character.WISSavingThrow = bool.Parse(source[54]);
                character.CHASavingThrow = bool.Parse(source[55]);

            }
        }

        //Inventory

        /// <summary>
        /// Adding Items to the Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_Add(object sender, RoutedEventArgs e)
        {
            Items item = new Items();

            try { item.Name = InvAddName.Text; } catch { item.Name = "Unnamed"; }
            try { item.Amount = Convert.ToInt32(InvAddAmount.Text); } catch { item.Amount = 1; }
            try { item.Weight = Convert.ToInt32(InvAddWeight.Text); } catch { item.Weight = 0; }
            item.Description = "/";

            character.items.Add(item);

            Inventory.Text = "";
            int invcount = 0;
            foreach (var thing in character.items)
            {
                invcount++;
                Inventory.Text += $"{invcount}. {thing} \n";
            }

        }
        /// <summary>
        /// Removing Items from the Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_Remove(object sender, RoutedEventArgs e)
        {
            try { character.items.RemoveAt(Convert.ToInt32(RemoveIndex.Text) - 1); } catch { }

            Inventory.Text = "";
            int invcount = 0;
            foreach (var thing in character.items)
            {
                invcount++;
                Inventory.Text += $"{invcount}. {thing} \n";
            }
        }
        /// <summary>
        /// Editing Items from the Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_Edit(object sender, RoutedEventArgs e)
        {
            try
            {

                EditName.Text = character.items.ElementAt(Convert.ToInt32(EditIndex.Text) - 1).Name;
                EditAmount.Text = Convert.ToString(character.items.ElementAt(Convert.ToInt32(EditIndex.Text) - 1).Amount);
                EditWeight.Text = Convert.ToString(character.items.ElementAt(Convert.ToInt32(EditIndex.Text) - 1).Weight);
                EditDescription.Text = character.items.ElementAt(Convert.ToInt32(EditIndex.Text) - 1).Description;

                character.items.RemoveAt(Convert.ToInt32(EditIndex.Text) - 1);


                edititem.Visibility = Visibility.Visible;
                EditName.Visibility = Visibility.Visible;
                EditDescription.Visibility = Visibility.Visible;
                EditAmount.Visibility = Visibility.Visible;
                EditWeight.Visibility = Visibility.Visible;

                NameTXT.Visibility = Visibility.Visible;
                DescTXT.Visibility = Visibility.Visible;
                AmountTXT.Visibility = Visibility.Visible;
                WeightTXT.Visibility = Visibility.Visible;

                Done.Visibility = Visibility.Visible;

            }
            catch { }
        }
        /// <summary>
        /// Closing the edit window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDone(object sender, RoutedEventArgs e)
        {
            Items item = new Items();

            try { item.Name = EditName.Text; } catch { item.Name = "Unnamed"; }
            try { item.Description = EditDescription.Text; } catch { item.Name = "/"; }
            try { item.Amount = Convert.ToInt32(EditAmount.Text); } catch { item.Amount = 1; }
            try { item.Weight = Convert.ToInt32(EditWeight.Text); } catch { item.Weight = 0; }

            character.items.Insert(Convert.ToInt32(EditIndex.Text) - 1, item);

            Inventory.Text = "";
            int invcount = 0;
            foreach (var thing in character.items)
            {
                invcount++;
                Inventory.Text += $"{invcount}. {thing} \n";
            }

            edititem.Visibility = Visibility.Hidden;
            EditName.Visibility = Visibility.Hidden;
            EditDescription.Visibility = Visibility.Hidden;
            EditAmount.Visibility = Visibility.Hidden;
            EditWeight.Visibility = Visibility.Hidden;

            NameTXT.Visibility = Visibility.Hidden;
            DescTXT.Visibility = Visibility.Hidden;
            AmountTXT.Visibility = Visibility.Hidden;
            WeightTXT.Visibility = Visibility.Hidden;

            Done.Visibility = Visibility.Hidden;
        }

        //Attacks

        /// <summary>
        /// Adding Attacks to the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attack_Add(object sender, RoutedEventArgs e)
        {
            Attacks attack = new Attacks();

            try { attack.Name = AttackName.Text; } catch { attack.Name = "Unnamed"; }
            try { attack.Range = AttackRange.Text; } catch { attack.Range = "/"; }
            try { attack.HitDC = Convert.ToInt32(AttackHit.Text); } catch { attack.HitDC = 0; }
            try { attack.Damage = AttackDamage.Text; } catch { attack.Damage = "/"; }
            try { attack.Notes = AttackNotes.Text; } catch { attack.Notes = "/"; }

            character.attacks.Add(attack);

            AttackList.Text = "";
            int AttackCount = 0;
            foreach (var thing in character.attacks)
            {
                AttackCount++;
                AttackList.Text += $"{AttackCount}. {thing}\n";
            }
            AttackName.Text = "";
            AttackRange.Text = "";
            AttackHit.Text = "";
            AttackDamage.Text = "";
            AttackNotes.Text = "";
        }
        private void Attack_Edit(object sender, RoutedEventArgs e)
        {
            int index = -1;

            try { index = Convert.ToInt32(AttackIndex.Text) - 1; } catch { }

            if (index <= character.attacks.Count && index >= 0)

            {
                EditAttack.Visibility = Visibility.Visible;

                NameATTTXT.Visibility = Visibility.Visible;
                RangeATTTXT.Visibility = Visibility.Visible;
                HitATTTXT.Visibility = Visibility.Visible;
                DamageATTTXT.Visibility = Visibility.Visible;
                NotesATTTXT.Visibility = Visibility.Visible;

                EditATTName.Visibility = Visibility.Visible;
                EditATTRange.Visibility = Visibility.Visible;
                EditHit.Visibility = Visibility.Visible;
                EditATTDamage.Visibility = Visibility.Visible;
                EditATTNotes.Visibility = Visibility.Visible;
            }

        }
        /// <summary>
        /// Removing Attacks from the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attack_Remove(object sender, RoutedEventArgs e)
        {
            try { int index = Convert.ToInt32(AttackIndex.Text) - 1; character.attacks.RemoveAt(index); } catch { }

            AttackList.Text = "";
            int AttackCount = 0;
            foreach (var thing in character.attacks)
            {
                AttackCount++;
                AttackList.Text += $"{AttackCount}. {thing}\n";

            }
        }


        //Skill Autorolling and Custom Rolls

        /// <summary>
        /// Autorolling when clicking the Die
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkill_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;

            Random random = new Random();

            int Roll = (int)random.Next(1, 21);
            int Result = 0;

            try
            {
                Result = Roll + Convert.ToInt32(button.Content); DiceResult.Text += $"\n{Roll} + {button.Content} = {Result}";
            }
            catch { }

        }
        /// <summary>
        /// Showing what Dice it is when the mouse hovers over it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceMouseOver(object sender, MouseEventArgs e)
        {
            Button button = (Button)e.Source;

            button.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Hidding the Dice Name when Mouse is not over it anymore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceMouseGone(object sender, MouseEventArgs e)
        {
            Button button = (Button)e.Source;

            button.Visibility = Visibility.Hidden;

        }
        /// <summary>
        /// Rolling + Output when dice is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.Source;
            Random random = new Random();

            int Roll = 0;

            switch (button.Name)
            {
                case "D20": Roll = (int)random.Next(1, 21); DiceResult.Text += $"\n{Roll}"; break;
                case "D12": Roll = (int)random.Next(1, 13); DiceResult.Text += $"\n{Roll}"; break;
                case "D10": Roll = (int)random.Next(1, 11); DiceResult.Text += $"\n{Roll}"; break;
                case "D8": Roll = (int)random.Next(1, 9); DiceResult.Text += $"\n{Roll}"; break;
                case "D6": Roll = (int)random.Next(1, 7); DiceResult.Text += $"\n{Roll}"; break;
                case "D4": Roll = (int)random.Next(1, 5); DiceResult.Text += $"\n{Roll}"; break;
                case "D100": Roll = (int)random.Next(1, 101); DiceResult.Text += $"\n{Roll}"; break;
            }
        }
        /// <summary>
        /// Clearing the Roll Result Output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DiceResult.Text = "Roll Results:";
        }


        //Skill Change

        /// <summary>
        /// Calling the StrengthChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrenghtInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.StrengthChanged();
            }
            catch { }

        }

        /// <summary>
        /// Calling the DexterityChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DexterityInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.DexterityChanged();
            }
            catch { }
        }

        /// <summary>
        /// Calling the ConstitutionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConstitutionInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.ConstitutionChanged();
            }
            catch { }
        }

        /// <summary>
        /// Calling the IntelligenceChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntelligenceInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.IntelligenceChanged();
            }
            catch { }
        }

        /// <summary>
        /// Calling the WisdomChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WisdomInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.WisdomChanged();
            }
            catch { }
        }

        /// <summary>
        /// Calling the CharismaChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharismaInt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(textBox.Text);

                events.CharismaChanged();
            }
            catch { }
        }


        //Additional Skill Update

        /// <summary>
        /// Updating Strength Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateStrengthSkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Strength) - 10) / 2));
            Strenght.Text = Convert.ToString(value);

            btnAthle.Content = value + ((character.Athletics) ? character.Proficiency : 0);
            btnStr.Content = value + ((character.STRSavingThrow) ? character.Proficiency : 0);
        }

        /// <summary>
        /// Updating Dexterity Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateDexteritySkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Dexterity) - 10) / 2));
            Dexterity.Text = Convert.ToString(value);

            btnAcr.Content = value + ((character.Acrobatics) ? character.Proficiency : 0);
            btnSleiOHan.Content = value + ((character.SleightOfHand) ? character.Proficiency : 0);
            btnStea.Content = value + ((character.Stealth) ? character.Proficiency : 0);
            btnDex.Content = value + ((character.DEXSavingThrow) ? character.Proficiency : 0);
        }

        /// <summary>
        /// Updating Constitution Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateConstitutionSkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Constitution) - 10) / 2));
            Constitution.Text = Convert.ToString(value);

            btnCon.Content = value + ((character.CONSavingThrow) ? character.Proficiency : 0);
        }

        /// <summary>
        /// Updating Intelligence Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateIntelligenceSkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Intelligence) - 10) / 2));
            Intelligence.Text = Convert.ToString(value);

            btnArca.Content = value + ((character.Arcana) ? character.Proficiency : 0);
            btnHist.Content = value + ((character.History) ? character.Proficiency : 0);
            btnInv.Content = value + ((character.Investigation) ? character.Proficiency : 0);
            PassIntInt.Text = Convert.ToString(value + 10);
            btnNat.Content = value + ((character.Nature) ? character.Proficiency : 0);
            btnRel.Content = value + ((character.Religion) ? character.Proficiency : 0);
            btnIntel.Content = value + ((character.INTSavingThrow) ? character.Proficiency : 0);

        }

        /// <summary>
        /// Updating Wisdom Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateWisdomSkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Wisdom) - 10) / 2));
            Wisdom.Text = Convert.ToString(value);

            btnANHA.Content = value + ((character.AnimalHandling) ? character.Proficiency : 0);
            btnIns.Content = value + ((character.Insight) ? character.Proficiency : 0);
            PassWis2Int.Text = Convert.ToString(value + 10);
            btnMed.Content = value + ((character.Medicine) ? character.Proficiency : 0);
            btnPerc.Content = value + ((character.Perception) ? character.Proficiency : 0);
            PassWisInt.Text = Convert.ToString(value + 10);
            btnSur.Content = value + ((character.Survival) ? character.Proficiency : 0);
            btnWis.Content = value + ((character.WISSavingThrow) ? character.Proficiency : 0);
        }

        /// <summary>
        /// Updating Charisma Skills
        /// </summary>
        /// <param name="value"></param>
        private void UpdateCharismaSkills()
        {
            int value = Convert.ToInt32(Math.Floor((Convert.ToDouble(character.Charisma) - 10) / 2));
            Charisma.Text = Convert.ToString(value);

            btnDece.Content = value + ((character.Deception) ? character.Proficiency : 0);
            btnInti.Content = value + ((character.Intimidation) ? character.Proficiency : 0);
            btnPerf.Content = value + ((character.Performance) ? character.Proficiency : 0);
            btnPers.Content = value + ((character.Persuasion) ? character.Proficiency : 0);
            btnCha.Content = value + ((character.CHASavingThrow) ? character.Proficiency : 0);

        }

        //Proficiency

        private void Proficency_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                character.Proficiency = Convert.ToInt32(Proficency.Text);
                EventManager.ProficiencyChanged();
            }
            catch { }
        }
    }
}
