namespace _01.Chef
{
    public class Chef
    {
        public Bowl Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.AddVegetableInBowl(potato);
            bowl.AddVegetableInBowl(carrot);

            return bowl;
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegitable)
        {
            vegitable.Cut();
        }

        private void Peel(Vegetable vegitable)
        {
            vegitable.Peel();
        }
    }
}