# Unit Testing

## Компонентно тестване на Телерик Академия
- Course: https://telerikacademy.com/student-courses/programming/unit-testing-with-csharp/about
- Video: https://www.youtube.com/watch?v=YDEq-SgJirs&index=1&list=PLF4lVL1sPDSnj0gf0XLEeFqJ0ODKNrgoE
- Repo: https://github.com/TelerikAcademy/Unit-Testing

## NUnit
```
[TextFixture] 
public class TheClassName
{
	[Test] 
	public void TheTestName()
	{
		...
```

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

## Атрибути
```
[TextFixture] // Клас компонентни тестове
public class TheClassName { ...

[Test] // Единичен компонентен тест
public void TheTestName() { ... }

[SetUp] // Изпълнение преди всеки тест
public void TestInit() { ... }

[TearDown] // Изпълнение след всеки тест
public void TestCleanUp() { ... }
```

## Твърдения
1. Условно 
```
Assert.IsTrue(bool condition, string message);
```
2. Сравнително 
```
Assert.AreEqual(expected value, actual value);
```
3. Проверка на изключение
```
Assert.Throws(Type expectedExceptionType, TestDelegate code);
```
4. Низово
```
StringAssert.Contains(string expected, string actual);
```
5. Колекция
```
CollectionAssert.Contains(IEnumerable expected, object actual);
```
6. Файлово 
```
FileAssert.AreEqual(FileInfo expected, FileInfo actual);
```