namespace WizardGuildLibrary
{
    public class SpellBook : List<Spell>
    {
        public override string ToString()
        {
            string result = "--- Księga Czarów ---\n";
            foreach (Spell czar in this)
            {
                result += czar.ToString() + "\n";
            }
            return result;
        }
    }
}
