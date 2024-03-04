namespace WizardGuildLibrary
{
    public class Wizard
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int NumOfActualHealthPoints { get; set; }
        public int NumOfMaxHealthPoints { get; set; }
        public int NumOfActualManaPoints { get; set; }
        public int NumOfMaxManaPoints { get; set; }
        public int Damage { get; set; }
        public int ResistanceToPhysicalDamage { get; set; }
        public int ResistanceToFireDamage { get; set; }
        public int ResistanceToIceDamage { get; set; }
        public int ResistanceToPoisonDamage { get; set; }
        public SpellBook Spells { get; set; }

        public Wizard(string name, int level, int experience, int strength, int dexterity, int intelligence, int numOfActualHealthPoints, int numOfMaxHealthPoints, int numOfActualManaPoints, int numOfMaxManaPoints, int damage, int resistanceToPhysicalDamage, int resistanceToFireDamage, int resistanceToIceDamage, int resistanceToPoisonDamage, SpellBook spells)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            NumOfActualHealthPoints = numOfActualHealthPoints;
            NumOfMaxHealthPoints = numOfMaxHealthPoints;
            NumOfActualManaPoints = numOfActualManaPoints;
            NumOfMaxManaPoints = numOfMaxManaPoints;
            Damage = damage;
            ResistanceToPhysicalDamage = resistanceToPhysicalDamage;
            ResistanceToFireDamage = resistanceToFireDamage;
            ResistanceToIceDamage = resistanceToIceDamage;
            ResistanceToPoisonDamage = resistanceToPoisonDamage;
            Spells = spells;
        }

        public override string ToString()
        {
            return $"+++++++++++++ {Name} +++++++++++++\n" +
                $"Poziom: {Level} \n" +
                $"Punkty doświadczenia: {Experience} \n" +
                $"Siła: {Strength} \n" +
                $"Zręczność: {Dexterity} \n" +
                $"Inteligencja: {Intelligence} \n" +
                $"HP: {NumOfActualHealthPoints}/{NumOfMaxHealthPoints}\n" +
                $"PE: {NumOfActualManaPoints}/{NumOfMaxManaPoints}\n" +
                $"Obrażenia: {Damage}\n" +
                $"Odporność na obrażenia fizyczne: {ResistanceToPhysicalDamage}\n" +
                $"Odporność na ogień: {ResistanceToFireDamage}\n" +
                $"Odporność na mróz: {ResistanceToIceDamage}\n" +
                $"Odporność na trucizny: {ResistanceToPoisonDamage}\n" +
                $"{Spells}";
        }
    }
}
