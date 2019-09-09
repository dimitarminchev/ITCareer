# Unit Testing

## Visual Studio Team Tests (VSTT)
```
[TestClass] 
public class TheClassName
{
	[TestMethod] 
	public void TheTestName()
	{
		...
```

## AAA = Arrange + Act + Assert
```
[TestMethod] 
public void DespositMoneyTest()
{
	// Arrange
	BankAccount bank = new BankAccount();

	// Act
	bank.Deposit(50);

	// Assert
	Assert.IsTrue(bank.Balance == 50);
}
```

## Atributes
```
[TestClass] = denotes a class holding unit tests
[TestMethod] = denotes a unit test method
[ExpectedException] = test causes an exception
[Timeout] = sets a timeout for test execution
[Ignore] = temporary ignored test case
[ClassInitialize], [ClassCleanup] = setup / cleanup logic for the testing class
[TestInitialize], [TestCleanup] = setup / cleanup logic for each test case
```

## Asserts
```
AreEqual(expected value, calculated value [,message]) = compare two values for equality
AreSame(expected object, current object [,message]) = compare object references
IsNull(object [,message])
IsNotNull(object [,message])
IsTrue(condition)
IsFalse(condition)
Fail(message) = Forced test fail
```
