namespace Projeto_RPG.src.Entities
{
    public class Hero
    {
        public string Name ;

        public int Level;

        public int HP;

        public string HeroType;

        public string Weapon;

        public Hero(string Name, int Level, int HP, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return $"\n {this.Name}\n --------------------\n LV. - {this.Level}\n Hp  - {this.HP}\n Tp. - {this.HeroType}\n Wp. - {this.Weapon}\n ---------------------";          
              
        }

        public virtual string Attack()
        {
            return $"\n {this.Name} atacou com sua {this.Weapon}";
        }

        public virtual string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return $"\n {this.Name} atacou de forma critica com sua {this.Weapon}! Bônus +{bonus}";
            }

            return $"\n {this.Name} atacou de forma fraca com sua {this.Weapon}. Bônus +{bonus}";
        }
    }
    
}