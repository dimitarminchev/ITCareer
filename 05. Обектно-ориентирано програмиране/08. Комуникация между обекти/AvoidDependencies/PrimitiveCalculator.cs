namespace AvoidDependencies
{
    public class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator()
        {
            this.strategy = new Addition();
        }

        public void changeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.strategy = new Addition();
                    break;
                case '-':
                    this.strategy = new Subtraction();
                    break;
                case '/':
                    this.strategy = new Division();
                    break;
                case '*':
                    this.strategy = new Multiplying();
                    break;
            }
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            return strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
