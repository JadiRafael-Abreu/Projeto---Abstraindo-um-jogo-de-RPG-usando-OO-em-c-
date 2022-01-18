namespace Projeto_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HP, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }
    }
}