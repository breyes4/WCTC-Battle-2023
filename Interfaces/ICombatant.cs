namespace Class05.Interfaces
{
    public interface ICombatant
    {
        public string Name { get; set; }
        public IArmor Armor { get; set; }
        public IWeapon Weapon { get; set; }
        public IMagic Magic { get; set; }

        void Attack(ICombatant enemy);
    }
}
