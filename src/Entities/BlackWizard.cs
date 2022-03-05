namespace jogo.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP =MP;
        }
        public override string Attack()
        {
            return this.Name + " Lançou seu feitiço!";
        }
        public string Attack(int Bonus){
            if (Bonus >= 6){
                return "Lançou seu feitiço com alta efetividade com bonus de" + Bonus;
            }
            else{
                return "Foi fraco seu feitiço pois teve o bonus de " + Bonus;
            }
        }

    }
}