using WizardGuildLibrary;

namespace WizardGuildApplication
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ResetColor();

            WizardGuild wd = new WizardGuild();

            SpellBook SB1 = new SpellBook
            {
                new Spell("Fireball", SpellTypeEnum.Offensive, 10, 5, 100),
                new Spell("Heal", SpellTypeEnum.Defensive, 8, 3, 50),
                new Spell("Invisibility", SpellTypeEnum.Utility, 15, 10, 0),
                new Spell("Frostbolt", SpellTypeEnum.Offensive, 12, 6, 80),
                new Spell("Protective Barrier", SpellTypeEnum.Defensive, 20, 8, 0),
                new Spell("Teleport", SpellTypeEnum.Utility, 25, 15, 0),
                new Spell("Lightning Strike", SpellTypeEnum.Offensive, 18, 7, 120),
                new Spell("Regenerate", SpellTypeEnum.Defensive, 10, 5, 30),
                new Spell("Flight", SpellTypeEnum.Utility, 30, 20, 0),
                new Spell("Earthquake", SpellTypeEnum.Offensive, 15, 8, 150),
                new Spell("Ward", SpellTypeEnum.Defensive, 12, 4, 0),
                new Spell("Summon Familiar", SpellTypeEnum.Utility, 10, 12, 0),
                new Spell("Arcane Blast", SpellTypeEnum.Offensive, 20, 10, 110),
                new Spell("Reflect", SpellTypeEnum.Defensive, 15, 5, 0),
                new Spell("Time Warp", SpellTypeEnum.Utility, 40, 25, 0),
            };

            SpellBook mage2Spells = new SpellBook
            {
                // 10 additional spells for the second mage
                new Spell("Shadow Bolt", SpellTypeEnum.Offensive, 14, 6, 90),
                new Spell("Absorb", SpellTypeEnum.Defensive, 10, 4, 40),
                new Spell("Blink", SpellTypeEnum.Utility, 18, 12, 0),
                new Spell("Chain Lightning", SpellTypeEnum.Offensive, 22, 9, 130),
                new Spell("Mirror Shield", SpellTypeEnum.Defensive, 25, 10, 0),
                new Spell("Telekinesis", SpellTypeEnum.Utility, 28, 16, 0),
                new Spell("Soul Drain", SpellTypeEnum.Offensive, 16, 7, 110),
                new Spell("Revitalize", SpellTypeEnum.Defensive, 12, 6, 60),
                new Spell("Levitate", SpellTypeEnum.Utility, 32, 22, 0),
                new Spell("Mind Blast", SpellTypeEnum.Offensive, 20, 8, 120),
            };

            SpellBook mage3Spells = new SpellBook
            {
                // 20 spells for the third mage
                new Spell("Lava Burst", SpellTypeEnum.Offensive, 15, 7, 105),
                new Spell("Aegis", SpellTypeEnum.Defensive, 30, 12, 0),
                new Spell("Phase Shift", SpellTypeEnum.Utility, 40, 18, 0),
                new Spell("Poison Spray", SpellTypeEnum.Offensive, 8, 4, 70),
                new Spell("Life Link", SpellTypeEnum.Defensive, 14, 5, 35),
                new Spell("Summon Golem", SpellTypeEnum.Utility, 45, 25, 0),
                new Spell("Blizzard", SpellTypeEnum.Offensive, 28, 14, 140),
                new Spell("Mend", SpellTypeEnum.Defensive, 10, 3, 45),
                new Spell("Haste", SpellTypeEnum.Utility, 22, 8, 0),
                new Spell("Meteor Strike", SpellTypeEnum.Offensive, 50, 30, 200),
                new Spell("Venomous Sting", SpellTypeEnum.Offensive, 10, 4, 75),
                new Spell("Wings of Wind", SpellTypeEnum.Utility, 35, 20, 0),
                new Spell("Aqua Shield", SpellTypeEnum.Defensive, 18, 7, 0),
                new Spell("Cursed Flames", SpellTypeEnum.Offensive, 22, 9, 130),
                new Spell("Ethereal Form", SpellTypeEnum.Utility, 30, 15, 0),
                new Spell("Vital Surge", SpellTypeEnum.Defensive, 12, 5, 55),
                new Spell("Gravity Manipulation", SpellTypeEnum.Utility, 25, 12, 0),
                new Spell("Spiritual Reflection", SpellTypeEnum.Defensive, 14, 6, 0),
                new Spell("Thunderstorm", SpellTypeEnum.Offensive, 28, 14, 150),
                new Spell("Temporal Shift", SpellTypeEnum.Utility, 40, 18, 0),
            };

            WizardGuild Immortale = new WizardGuild
            {
                new Wizard("Gandalf", 10, 1000, 5, 15, 10, 80, 100, 150, 200, 20, 15, 10, 5, 8, SB1),
                new Wizard("Merlin", 12, 1500, 4, 4, 12, 90, 110, 180, 220, 18, 12, 15, 8, 6, mage2Spells),
                new Wizard("Morgana", 8, 800, 3, 6, 14, 70, 90, 170, 210, 15, 10, 8, 12, 10, mage3Spells)
            };

            
            Console.WriteLine(Immortale.PotentialOfAllOffensWizards());
            Console.WriteLine(Immortale.WizardsWhoHaveTheGreatestArsenalOfSpells(3));
            Console.WriteLine(Immortale.DisplyAllSpells());
            Console.WriteLine(Immortale.DisplyAllSpellsOfSpecifyType("Offensive"));
            Console.WriteLine(Immortale.DisplyCountOfAllSpellsByType());
            Console.WriteLine(Immortale.DisplyMostPowerfullWizards());
            Console.WriteLine(Immortale.DisplayTournamentPreparation());
            Console.WriteLine(Immortale.DisplayHealthCondition());
            Console.WriteLine(Immortale.DisplayBestWizardsForSpeciallMission());
        }
    }
}