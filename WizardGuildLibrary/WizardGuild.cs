using System.Reflection.Emit;
using System.Text;


namespace WizardGuildLibrary
{
    public class WizardGuild : List<Wizard>
    {

        public string AddWizardToGuild(Wizard wizard)
        {
            if (Contains(wizard))
            {
                return "Wizard is already a member of the guild.";
            }
            Add(wizard);
            return "Wizard added to the guild.";
        }

        public string RemoveWizardFromGuild(Wizard wizard)
        {
            if (this.Contains(wizard))
            {
                Remove(wizard);
                return "Wizard is removed of the guild.";
            }
            return "Wizard is not a member of the guild.";
        }

        public override string ToString()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder("Guild Members:\n");
                foreach (Wizard wizard in this)
                {
                    sb.AppendLine(wizard.Name);
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string AllMages()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder("Guild Members:\n");
                foreach (Wizard wizard in this.OrderBy(w => w.Name))
                {
                    sb.AppendLine(wizard.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string FindExperiancedWizards(int level)
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Wizards witch level increase level-{level}:\n");
                foreach (Wizard wizard in this.Where(w => w.Level > level).OrderByDescending(w => w.Level))
                {
                    sb.AppendLine(wizard.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string PotentialOfAllOffensWizards()
        {
            if (this.Any())
            {
                int result = this.Where(w => w.Level > 2 && w.Dexterity > 10).Select(w => w.NumOfMaxManaPoints).Sum();
                StringBuilder sb = new StringBuilder($"Summary of mana points, all offensive wizards in guild : {result}");

                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string WizardsWhoHaveTheGreatestArsenalOfSpells(int numOfSpells)
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Wizards witch spells arsenal increase {numOfSpells}:\n");

                var queryResult = this.Where(w => w.Spells.Count >= numOfSpells).Select(w => new 
                {
                    w.Name, NumOfSpells = w.Spells.Count, w.NumOfMaxManaPoints
                }).OrderByDescending(a => a.NumOfSpells);

                foreach (var wizard in queryResult)
                {
                    // sprawdzić co zwróci nie nadpisany ToString(), w razie bładu zmienić na wypisanie konkretnych wartosci
                    sb.AppendLine(wizard.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string InformationAboutMostVersatileWizards()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Most versatile wizards:\n");

                var queryResult = this.Select(w => new
                {
                    w.Name,
                    w.Level,
                    avgSDI = (w.Strength + w.Dexterity + w.Intelligence)/3
                }).OrderByDescending(a => a.avgSDI);

                foreach (var wizard in queryResult)
                {
                    sb.AppendLine(wizard.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string WizardsWhoHasMostSpells()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Wizards who has most spells :\n");

                var queryResult = this.OrderByDescending(a => a.Spells.Count).Take(3);

                foreach (var wizard in queryResult)
                {
                    sb.AppendLine(wizard.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet.";
            }
        }

        public string DisplyAllSpells()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"All spells known by wizards in this guild : \n\n");

                var queryResult = this.SelectMany(a => a.Spells).Distinct();

                foreach (var spell in queryResult)
                {
                    
                    sb.AppendLine(spell.ToString());

                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplyAllSpellsOfSpecifyType(string type)
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"All spells of {type} type : \n\n");

                var queryResult = this.SelectMany(a => a.Spells).Where(a => a.Type.ToString() == type).Distinct();

                foreach (var spell in queryResult)
                {

                    sb.AppendLine(spell.ToString());

                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplyAllSpellsOfSpecifyType(string wizard, string type)
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"All {type} type spells of {wizard} : \n\n");

                var queryResult = this.Single(w => w.Name.Equals(wizard)).Spells.Where(a => a.Type.ToString() == type);

                foreach (var spell in queryResult)
                {

                    sb.AppendLine(spell.ToString());

                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplyCountOfAllSpellsByType()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Count of all spells known by wizards in this guild by type : \n\n");

                var queryResult = this.SelectMany(a => a.Spells).Distinct().GroupBy(a => a.Type).Select(a => new { 
                    SpellType = a.Key,
                    SpellCount = a.Count()
                });

                foreach (var spell in queryResult)
                {

                    sb.AppendLine(spell.ToString());

                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplyMostPowerfullWizards()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Top 3 most powerfull wizards : \n\n");

                var queryResult = this.OrderByDescending(w => w.Level).ThenByDescending(w => w.Experience)
                    .Skip(1).Take(2).Select(w => new { 
                        Name = w.Name,
                        Level = w.Level
                });

                foreach (var spell in queryResult)
                {

                    sb.AppendLine(spell.ToString());

                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplayTournamentPreparation()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Is every wizard is ready for the tournament : ");

                var queryResult = this.All(w => w.NumOfActualHealthPoints.Equals(w.NumOfMaxHealthPoints) && w.NumOfActualManaPoints.Equals(w.NumOfMaxManaPoints));

                sb.AppendLine(queryResult ? "yes" : "no");
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplayHealthCondition()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Has anyone lost consciousness : ");

                var queryResult = this.Any(w => w.NumOfActualHealthPoints.Equals(0));

                sb.AppendLine(queryResult ? "yes" : "no");
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

        public string DisplayBestWizardsForSpeciallMission()
        {
            if (this.Any())
            {
                StringBuilder sb = new StringBuilder($"Top 3 best wizards for speciall mission : \n");

                var queryResult = this.OrderByDescending(w => w.Level).Take(3).Select(w => new { 
                    Name = w.Name,
                    Level = w.Level,
                    RPS = w.ResistanceToIceDamage + w.ResistanceToFireDamage + w.ResistanceToPhysicalDamage + w.ResistanceToPoisonDamage,
                    ResistanceToIceDamage = w.ResistanceToIceDamage,
                    ResistanceToFireDamage = w.ResistanceToFireDamage,
                    ResistanceToPhysicalDamage = w.ResistanceToPhysicalDamage,
                    ResistanceToPoisonDamage = w.ResistanceToPoisonDamage
                });

                foreach (var spell in queryResult)
                {
                    sb.AppendLine(spell.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "This guild does not have any members yet. So we don't have any spells yet.";
            }
        }

    }
}
