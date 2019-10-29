# Изключения (Exception)

## Прихващане на изключенията
```
try
{
    ...
}
catch (Exception)
{
    ...
}
finally
{
	...
}
```
**Типове**
- System.ArgumentException
- System.FormatException
- System.NullReferenceException
- System.OutOfMemoryException
- System.StackOverflowException

## Хвърляне на изключения
```
throw new ArgumentException("Invalid amount!");
```
**Типове**
- ArgumentException
- ArgumentNullException 
- ArgumentOutOfRangeException
- NotSupportedException
- NotImplementedException

## Упражнения
- [911](911) = Валидна личност
- [921](921) = Square Root
- [922](922) = Enter Numbers


# Потоци (Streams)
Четене от файл
```
StreamReader reader = new StreamReader("filename.txt");
string line = reader.ReadLine();
```
Запис във файл
```
StreamWriter writer = new StreamWriter("filename.txt");
reader.WriteLine("Hello World");
```
## Упражнения
- [1011](1011) = Нечетни редове
- [1012](1012) = Номера на редове
- [1013](1013) = Брой на думите