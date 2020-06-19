namespace Codenation.Challenge
{
    public class State
    {
        public State(string name, string acronym)
        {
            Name = name;
            Acronym = acronym;
        }

        public State(string name, string acronym, double territory) : this(name, acronym)
        {
            Territory = territory;
        }

        public string Name { get; set; }

        public string Acronym { get; set; }

        public double Territory { get; set; }
    }
}
