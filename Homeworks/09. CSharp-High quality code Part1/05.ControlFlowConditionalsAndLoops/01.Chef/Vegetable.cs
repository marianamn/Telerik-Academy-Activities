namespace _01.Chef
{
    public class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;

            // Task 2
            this.IsRotted = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        // Task 2
        public bool IsRotted { get; set; }

        public bool Peel()
        {
            return this.IsPeeled = true;
        }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Rotted()
        {
            this.IsRotted = true;
        }

        public override string ToString()
        {
            string peel = string.Empty;

            if (this.IsPeeled)
            {
                peel = "peeled";
            }
            else
            {
                peel = "not peeled";
            }

            string cut = string.Empty;

            if (this.IsCut)
            {
                cut = "cut";
            }
            else
            {
                cut = "not cut";
            }

            string name = GetType().Name;

            return string.Format("{0} is {1} and {2}", name, peel, cut);
        }
    }
}
