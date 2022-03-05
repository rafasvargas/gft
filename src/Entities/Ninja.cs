namespace jogo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP =MP;
        }
        public override string Attack()
        {
            return this.Name + " Golpeou seu oponente!";
        }
    }
}