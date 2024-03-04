namespace WizardGuildLibrary
{
    public class Spell
    {
        public string Name { get; set; }
        public SpellTypeEnum Type { get; set; }
        public int Price { get; set; }
        public int Cooldown { get; set; }
        public int Effect { get; set; }

        public Spell(string name, SpellTypeEnum type, int price, int cooldown, int effect)
        {
            Name = name;
            Type = type;
            Price = price;
            Cooldown = cooldown;
            Effect = effect;
        }

        public override string ToString()
        {
            

            return $"*** {Name} ***\n" +
                $"Typ czaru: {Type} \n" +
                $"Liczba punktów manny potrzebna do rzucenia czaru: {Price} \n" +
                $"Okres czasu jaki musi upłynąć aby móc rzucić klejne zaklęcie: {Cooldown} sec" +
                $"Efekt rzucenia czaru: {Effect}" +
                $"\n";

            
        }

        public override bool Equals(object? obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}