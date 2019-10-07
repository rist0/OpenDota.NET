namespace OpenDotaDotNet.Models.Records
{
    public class RecordField
    {
        public string Value { get; set; }

        private RecordField(string value)
        {
            Value = value;
        }

        public static RecordField Duration => new RecordField("duration");
        public static RecordField Kills => new RecordField("kills");
        public static RecordField Deaths => new RecordField("deaths");
        public static RecordField Assists => new RecordField("assists");
        public static RecordField GoldPerMin => new RecordField("gold_per_min");
        public static RecordField XPPerMin => new RecordField("xp_per_min");
        public static RecordField LastHits => new RecordField("last_hits");
        public static RecordField Denies => new RecordField("denies");
        public static RecordField HeroDamage => new RecordField("hero_damage");
        public static RecordField TowerDamage => new RecordField("tower_damage");
        public static RecordField HeroHealing => new RecordField("hero_healing");
    }
}
