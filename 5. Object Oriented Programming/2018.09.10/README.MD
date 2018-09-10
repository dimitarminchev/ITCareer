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

# Стандартни потоци
**File Stream**
```
var fileStream = new FileStream("filename.txt",FileMode.Create);
byte[] bytes = Encoding.UTF8.GetBytes(text);
fileStream.Write(bytes, 0, bytes.Length);
fileStream.Close();
```
**Memory Stream**
```
var memoryStream = new MemoryStream(bytes)
int readByte = memoryStream.ReadByte();
```
**Network Stream**
```
var tcpListener = new TcpListener(IPAddress.Any, PortNumber);
tcpListener.Start();

NetworkStream stream = tcpListener.AcceptTcpClient().GetStream()
stream.Read(request, 0, 4096);
Console.WriteLine(Encoding.UTF8.GetString(request));

byte[] html = Encoding.UTF8.GetBytes("Hello World");
stream.Write(html, 0, html.Length);
```
## Упражнения
- [1021](1021) = Копиране на двоичен файл
- [1022](1022) = Разделяне на файл на части
- [1023](1023) = Компресиране на нарязаните файлове
- [1024](1024) = Претърсване на директория
- [1025](1025) = *Пълно претърсване на директория
- [1026](1026) = **HTTP сървър