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
var tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 22);
tcpListener.Start();
NetworkStream stream = tcpListener.AcceptTcpClient().GetStream();

byte[] request = new byte[1024];
stream.Read(request, 0, request.Length);
Console.WriteLine(Encoding.UTF8.GetString(request));

byte[] response = Encoding.UTF8.GetBytes("Hello World");
stream.Write(response, 0, response.Length);
```
## Упражнения
- [1021](1021) = Копиране на двоичен файл
- [1022](1022) = Разделяне на файл на части
- [1023](1023) = Компресиране на нарязаните файлове
- [1024](1024) = Претърсване на директория
- [1025](1025) = *Пълно претърсване на директория
- [1026](1026) = **HTTP сървър