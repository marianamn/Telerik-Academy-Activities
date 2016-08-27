using System.Collections.Generic;

namespace _01.Chef
{
    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public List<Vegetable> Ingredients { get; set; }

        public void AddVegetableInBowl(Vegetable ingredient)
        {
            this.Ingredients.Add(ingredient);
        }

        public override string ToString()
        {
            return string.Join("; ", this.Ingredients);
        }
    }
}