namespace Character
{
    //Object to hold buffs/debuffs of stats for race and class
    public class Buff
    {
        public Buff(string t, int v) { this.Type = t; this.Value = v; }
        public string Type { get; set; }
        public int Value { get; set; }
    }
}
