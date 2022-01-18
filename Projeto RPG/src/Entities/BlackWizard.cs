namespace Projeto_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, int HP, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }
    }
}