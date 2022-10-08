public class PrimitiveCalculator
{
	private IStrategy strategy;

	public PrimitiveCalculator()
	{
		this.strategy = new Addition(); // +
    }

	public void changeStrategy(char @operator)
	{
		switch (@operator)
		{
			case '+':
                this.strategy = new Addition(); // +
                break;
			case '-':
				this.strategy = new Subtraction(); // -
				break;
			case '*':
				this.strategy = new Multiplying(); // *
				break;
			case '/':
				this.strategy = new Division(); // /
				break;
		}
	}

    public int performCalculation(int a, int b)
    {
        return strategy.Calculate(a, b);
    }
}