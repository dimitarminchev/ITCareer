public class Person
{
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set 
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("Can not be null or empty.");
			}
			firstName = value; 
		}
	}

	private string lastName;

	public string LastName
	{
		get { return lastName; }
		set 
		{
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can not be null or empty.");
            }
            lastName = value; 
		}
	}

	private int age;

	public int Age
	{
		get { return age; }
		set 
		{
			if (value <= 0 || value > 120)
			{
				throw new ArgumentOutOfRangeException("Can not be null or empty.");
            }
			age = value; 
		}
	}

	public Person(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}
}