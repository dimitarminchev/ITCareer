namespace AnimalFarm
{
    public abstract class Food
    {
        public int quantity { get; }

        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}