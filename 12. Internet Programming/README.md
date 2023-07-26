# Модул 12. Интернет програмиране
[Материали](Материали.zip) |
[Видео](https://youtube.com/playlist?list=PL-w_n7hgFuN30PVkwHBxg1cAjovEOf0jH)

## Съдържание
01. Internet and Sockets 
02. HTTP
03. Introduction to HTML
04. HTTP Server 
05. Introduction to MVC 
06. Database
07. Template Language
08. State Management
09. Authentication and Authorization
10. Security
11. REST API
12. Consuming REST API
13. Deployment
14. Exam Preparation

## 1. Internet and Sockets

### 1. Какво ще направим?
Ще създадем конзолно приложение - чат, като изпратените съобщения чрез клиента ще получаваме съответно на сървъра, а комуникацията ще се осъществява посредством сокети.

### 2. Архитектура на проекта
Проектът, ще се състои от два подпроекта, като съответно единият ще служи за нашият socket сървър, а другият за socket клиент. Ще поставим и двата проекта под един solution на име ChatServer.

![01. Internet and Sockets/Pictures/01.png](<01. Internet and Sockets/Pictures/01.png>)

За да се запази проекта в прост вид и да се наблегне върху новите знания за сокети, а не върху шаблони за дизайн, ще поставяме нашият код директно в Main() методите.

### 3. Сървър
Първо ще изградим имплементацията на нашия сървър. За такъв ще използваме конзолно приложение, което отваря нов socket, като се свързва на определен порт и започва да слуша за приидващи данни.

Приложението, което ще създадем ще работи само локално. Нека започнем с вземането на адрес данните за хоста ни. Ще използваме статичният клас Dns и в частност метода му GetHostName(), намиращ се в библиотеката System.Net, за да вземем името на текущия хост. След като разполагаме с името на хоста ще използваме метода GetHostEntry(), с параметър името на хоста, на същия клас, за да разглеждаме хоста като IPHostEntry – клас, който служи като контейнер за информация относно интернет хост адрес.

Тази информация ще използваме, за да вземем IPAddress-а на хоста (от списъка с адреси, който IPHostEntry-то съдържа).

IP адресът, който имаме, ще използваме за да създадем нова крайна точка (endpoint), към който трябва да се обърне клиента. Нека създадем нова иснтанция на класа System.Net.IPEndPoint, като за параметри ще подадем IP адреса и порта, към който искаме да се свържем. Нека изберем за порт 11000.

Какво имаме досега:
```cs
string hostname = Dns.GetHostName();
IPHostEntry ipHostInfo = Dns.GetHostEntry(hostname);
IPAddress ipAddress = ipHostInfo.AddressList[0];
IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
```

След като сме създали нашия endpoint е време да създадем и сокет, който да слуша на този IP адрес. Ще създадем нова инстанция на класа Socket, който се намира в библиотеката System.Net.Sockets. За тип на сокета ще изберем Steam – това е типът, който поддържа надеждни, двустранни, базирани на връзка (connection-based) байтови потоци. Този тип сокети използват TCP.

Нека свържем сокета си към крайната ни точка, след което окажем на сокета да започне да слуша. Параметърът backlog, който получава метода Listen() е максималната дължина на опашката от висящи връзки. С масив от байтове ще създадем нашия буфер – размера на данни, който ще получаваме. Нека масивът ни е с размер 1024 байта. Върху вече създаденият ни сокет, който слуша за новоизискани връзки, ще създадем нов сокет, който приема първата заявка за свързване от вече споменатата опашка от висящи връзки.

С два вложени безкрайни цикъла ще проверяваме дали е пристигнало съобщение по нашия сокет. Ако това се е случило, ще го изпишем на екрана (конзолата). За край на съобщението ще приемаме , което е съкращение стоящо за end of file. Текста получаван по сокета ще четем като ASCII енкодиран. Начинът, по който сокета ще поучава данните е чрез метода си Receive(), а като параметър се подава буфер – ние вече разполагаме с такъв.

Край на изпълнението на програма ще слага въвеждането на съобщение **exit**, за което ще проверяваме и при което ще прекъсваме действието цикъла си. Преди да направим това обаче е нужно да затворим сокета си, което става чрез методите Shutdown() – с параметър SocketShutDown.Both (затваря както за четене, така и за писане) и Close(). Преди да спрем изпълнението на сървъра ще изпишем на конзолата **Goodbye**.

Как изглежда това:
```cs
Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
string message = "";
try
{
    byte[] buffer = new byte[1024];
    listener.Bind(localEndPoint);
    listener.Listen(100);
    Socket handle = listener.Accept();
    while (true)
    {
        message = "";
        while (true)
        {
            int messageSize = handle.Receive(buffer);
            message += Encoding.ASCII.GetString(buffer, 0, messageSize);
            if (message.Contains("<EOF>"))
            {
                message = message.Replace("<EOF>", "");
                break;
            }
        }
        Console.WriteLine("> " + message);
        if (message == "exit")
        {
            handle.Shutdown(SocketShutdown.Both);

            handle.Close();
            break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.Clear();
Console.WriteLine("Goodbye");
Console.ReadKey(true);
```

С това имплементацията на нашия сокет сървър е завършена.

### 4. Клиент
След като разполагаме със сокет сървър, е време да изградим и нашия сокет клиент.

По аналогичен начин ще създадем сокет, но този път той ще служи за изпращане на данни.
```cs
IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
IPAddress ipAddress = ipHostInfo.AddressList[0];
IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
```
В този случай ще използваме съответните методи на сокета за изпращане на данни. Съобщението ще четем от конзолата като потребителски вход, след което ще го преобразуваме в масив от байтове, като накрая на всяко съобщение ще долепваме , за да окажем, че това е краят му (при натискане на enter).

Методът на сокета .Connect(), приемащ крайна точка осъществява връзката със сървъра ни, а методът Send(), приемащ масив от байтове изпраща съобщението към него. Отново ако съобщението е **exit** изпълнението на програмата приключва.

Как излежда това:
```cs
try
{
    sender.Connect(remoteEP);
    Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
    while (true)
    {
        Console.Write("> ");
        string message = Console.ReadLine();
        byte[] msg = Encoding.ASCII.GetBytes(message + "<EOF>");
        int bytesSent = sender.Send(msg);
        if (message == "exit") break;
    }
    sender.Shutdown(SocketShutdown.Both);
    sender.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
```

### 5. Как да използваме приложението
За да използваме приложението, трябва сървърът да е пуснат преди клиента. В противен случай връзката не може да бъде осъществена. За целта ще се възползваме от инструментите на Visual Studio и ще настроим при старт на програта да се пускат едноврменно и сървърът и клиентът, като сървърът да е първи.

![01. Internet and Sockets/Pictures/02.png](<01. Internet and Sockets/Pictures/02.png>)

От solution explorer-а ще изберем опцията Set StartUp Projects…, която можем да открием в падащото меню след десен клик върху името на solution-а ни.

![01. Internet and Sockets/Pictures/03.png](<01. Internet and Sockets/Pictures/03.png>)

От появилото се меню ще изберем опцията Multiple startup projects, и ще създадем последователността, в която проектите трябва да стартират – в нашия случай отгоре ще сложим сървърът. За Action съответно изберете start/start without debugging.

![01. Internet and Sockets/Pictures/04.png](<01. Internet and Sockets/Pictures/04.png>)

При стартиране на проекта би трябвало да се отворят две конзолни приложения – нашият сървър и нашият клиент. В клиентското приложение ще се изпише адреса, на който се е свързал сокета ни, както и съответния порт. На този етап всяко съобщение ще бъде изпратено от клиента на сървъра. Нека тестваме:

![01. Internet and Sockets/Pictures/05.png](<01. Internet and Sockets/Pictures/05.png>)

За да приключи изпълнението, както на нашия сървър, така и на нашия клиент въвеждаме като съобщение “exit”. Съответно преди да се затвори сървъра изчиства изпратените съобщения и изписва “Goodbye”.

![01. Internet and Sockets/Pictures/06.png](<01. Internet and Sockets/Pictures/06.png>)

Това е финалната стъпка – вече разполагаме със собствен чат сървър.

## 2. HTTP протокол

### Инсталиране на необходимия софтуер

#### Postman

Можете да изтеглите Postman от тук: [https://www.getpostman.com/downloads/](https://www.getpostman.com/downloads/)

### Направете основни HTTP заявки

#### 1. Kinvey

Трябва да въведем следната заявка "GET" в Postman: [https://baas.kinvey.com/appdata/kid\_S1rDXLP4N](https://baas.kinvey.com/appdata/kid\_S1rDXLP4N)

Първо, отидете на **Authorization** в **Postman** и изберете "Basic Auth". Въведете потребителско име: "guest" и парола: "guest":

Заявка: ![02. HTTP/Pictures/01.png](<02. HTTP/Pictures/01.png>)

Отговор: ![02. HTTP/Pictures/02.png](<02. HTTP/Pictures/02.png>)

#### 2. Вземете всички песни

Отидете на **Authorization** в **Postman** и изберете "Basic Auth". Въведете потребителско име: " guest" и парола: " guest". След това изброяването на всички песни трябва да е лесно със следната заявка: [https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs](https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs)

Заявка: ![02. HTTP/Pictures/03.png](<02. HTTP/Pictures/03.png>)

Отговор: ![02. HTTP/Pictures/04.png](<02. HTTP/Pictures/04.png>)

#### 3. Създайте нова песен

Отново отидете на **Authorization** в **Postman** и изберете " Basic Auth". Въведете потребителско име: " guest" и парола: " guest". Сега трябва да създадем нова песен:

Заявка: ![02. HTTP/Pictures/05.png](<02. HTTP/Pictures/05.png>)

Отговор: ![02. HTTP/Pictures/06.png](<02. HTTP/Pictures/06.png>)

#### 4. Изтрийте песен

Сега нека изтрием новосъздадената песен. Заявка "DELETE": [https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs/postId](https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs/postId). PostId може да се намери в JSON отговора на предишната задача:

![02. HTTP/Pictures/07.png](<02. HTTP/Pictures/07.png>)

Заявката "DELETE" трябва да генерира отговор, който ни казва колко публикации сме изтрили:

![02. HTTP/Pictures/08.png](<02. HTTP/Pictures/08.png>)

Сега, когато получим всички песни, можем да забележим, че песента "Back In Black" не е в списъка.

#### 5. Редактиране на песен

Редактирайте песен с PUT заявка. [https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs/5c5adb00c892215f50bd6761](https://baas.kinvey.com/appdata/kid\_S1rDXLP4N/songs/5c5adb00c892215f50bd6761)

Променете следните колони:

* name: "Dani California"
* album: "Stadium Arcadium"
* time: "4:43"
* year: "2006"
* добавете допълнителна колона: genre: "Rock"

Заявка: ![02. HTTP/Pictures/09.png](<02. HTTP/Pictures/09.png>)

Отговор: ![02. HTTP/Pictures/10.png](<02. HTTP/Pictures/10.png>)

#### 6. Вход

Отново отидете на Authorization в Postman и изберете "Basic Auth" и въведете потребителско име: "guest" и парола: "guest".

Влизането се извършва със заявка "POST" на следния URL адрес: [https://baas.kinvey.com/user/kid\_S1rDXLP4N/login](https://baas.kinvey.com/user/kid\_S1rDXLP4N/login)

Също трябва да изпратите своите идентификационни данни чрез JSON тялото:: ![02. HTTP/Pictures/11.png](<02. HTTP/Pictures/11.png>)

След успешно влизане трябва да получите следния отговор: ![02. HTTP/Pictures/12.png](<02. HTTP/Pictures/12.png>)

Запазете **authtoken**, защото ще ви е необходим за крайната задача.

#### 7\*. Бонус: Излез от профила си

И накрая, трябва да излезем от приложението. Променете Authorization на "No Auth". За целта трябва да изпратим заявка "POST" на следния URL адрес: [https://baas.kinvey.com/user/kid\_S1rDXLP4N/\_logout](https://baas.kinvey.com/user/kid\_S1rDXLP4N/\_logout)

Спомняте ли си този дълъг authorization token? Сега трябва да го копираме и да го поставим в секцията "Headers" на Postman: ![02. HTTP/Pictures/13.png](<02. HTTP/Pictures/13.png>)

След като щракнете върху "Send", отговорът трябва да бъде празен. Ако го направите отново, трябва да предизвика грешка. ![02. HTTP/Pictures/14.png](<02. HTTP/Pictures/14.png>)

#### 8\*\*. Реализация на GET и POST в C\#

GET
```cs
public string Get(string uri)
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

    using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    using(Stream stream = response.GetResponseStream())
    using(StreamReader reader = new StreamReader(stream))
    {
        return reader.ReadToEnd();
    }
}
```

GET async
```cs
public async Task<string> GetAsync(string uri)
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

    using(HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
    using(Stream stream = response.GetResponseStream())
    using(StreamReader reader = new StreamReader(stream))
    {
        return await reader.ReadToEndAsync();
    }
}
```

POST
```cs
public string Post(string uri, string data, string contentType, string method = "POST")
{
    byte[] dataBytes = Encoding.UTF8.GetBytes(data);

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
    request.ContentLength = dataBytes.Length;
    request.ContentType = contentType;
    request.Method = method;

    using(Stream requestBody = request.GetRequestStream())
    {
        requestBody.Write(dataBytes, 0, dataBytes.Length);
    }

    using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    using(Stream stream = response.GetResponseStream())
    using(StreamReader reader = new StreamReader(stream))
    {
        return reader.ReadToEnd();
    }
}
```

POST async
```cs
public async Task<string> PostAsync(string uri, string data, string contentType, string method = "POST")
{
    byte[] dataBytes = Encoding.UTF8.GetBytes(data);

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
    request.ContentLength = dataBytes.Length;
    request.ContentType = contentType;
    request.Method = method;

    using(Stream requestBody = request.GetRequestStream())
    {
        await requestBody.WriteAsync(dataBytes, 0, dataBytes.Length);
    }

    using(HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
    using(Stream stream = response.GetResponseStream())
    using(StreamReader reader = new StreamReader(stream))
    {
        return await reader.ReadToEndAsync();
    }
}
```

## 3. Introduction to HTML

### 1. Основи на HTML

#### Какво е HTML?

* HTML = HyperText Markup Language
* Нотация за описание: структура на документа, форматиране (презентация)
* Tаговете предоставят метаинформация за съдържанието на страницата и определят нейната структура
* Един HTML документ се състои от много тагове, които се влагат

#### HTML терминология

* **Тагове** = най-малкият елемент в HTML
* **Атрибути** = свойсвтвата на таговете - размер, цвят и т.н
* **Елементи** = комбинация от отварящ, затварящ таг и атрибути

#### Вашата първа HTML страница

```html
<!DOCTYPE html> <!-- Дефинира документа да бъде HTML5 -->
<html> <!-- Основният елемент на една HTML страница -->
    <head>
        <title>HTML Example</title> <!-- Определя заглавието на документа -->
    </head>
    <body> <!-- Съдържа видимото съдържание на страницата -->
        <h1>Hello HTML!</h1> <!-- Дефинира голямо заглавие -->
        <p>HTML describes formatted text using tags.</p> <!-- Дефинира параграф -->
    </body>
</html> <!-- Забележка: Повечето HTML тагове трябва да бъдат затваряни -->
```

#### Семантични тагове в HTML5

В HTML5 има семантични тагове за оформление: \<header>, \<footer>, \<nav>, \<aside>, \<section>.

```html
<html>
  <head> … </head>
  <body>
    <header> … </header>
    <nav> … </nav>
    <aside> … </aside>
    <section> … </section>
    <footer> … </footer>
  </body>
</html>
```

### 2. Често използвани тагове

#### Заглавия

```html
<h1>First Heading (Biggest)</h1>
<h2>Second Heading (Smaller)</h2>
<h3>Third Heading (Even Smaller)</h3>
<h4>Fourth Heading (Smallest)</h4>
```

Заглавията помагат при структурата на страниците, както в Microsoft Word. Html има шест различни HTML заглавия:

* **\<h1>** определя най-важното заглавие.
* **\<h6>** определя най-малко важното заглавие.

#### Параграфи

```html
<p>First paragraph</p>
<p>Second paragraph</p>
<br/> <!-- empty line -->
<p>Third paragraph</p>
```

Тагът **\<p>** дефинира параграф. Тагът **\<br/>** дефинира нов ред.

#### Булети и номерирани списъци

```html
<ul>
  <li>First item</li>
  <li>Second item</li>
  <li>Third item</li>
</ul>
```

Номериран списък

```html
<ol>
  <li>One</li>
  <li>Two</li>
  <li>Three</li>
</ol>
```

#### Хипервръзки

```html
<a href="https://google.bg">Google</a>
```

#### Локални хипервръзки

Локалните връзки могат да сочат към една и съща страница.

```html
<h1 id="top">Heading</h1>
... <!– голямо съдържание -->
Go to <a href="#top" target="_self">top</a>
```

#### Снимки

```html
<img src="images/google-logo.png" alt="Google logo (blue)" width="400" height="313" />
```

#### Таблици

```html
<table border="1"> <!-- Таблиците са дефинирани с тага <table> -->
    <tr> <!-- Дефинира ред в таблицата -->
        <th>Firstname</th> <!-- Дефинира заглавна клетка -->
        <th>Lastname</th> 
        <th>Age</th>
    </tr>
    <tr>
        <td>Jill</td> <!-- Дефинира клетка от таблицатаа -->
        <td>Smith</td>
        <td>50</td>
    </tr>
</table>
```

#### Атрунути на таблицата

Обединяване на колони

```html
<h2>Cell that spans two columns:</h2>
<table>
  <tr>
    <th>Name</th>
    <th colspan="2">Telephone</th> <!-- Дефинира колко колони ще обхваща клетката -->
  </tr>
  <tr>
    <td>Bill Gates</td>
    <td>55577854</td>
    <td>55577855</td>
  </tr>
</table>
```

Обединяване на редове

```html
<table>
    <tr>
        <th>Name:</th>
        <td>Bill Gates</td>
    </tr>
    <tr>
    <th rowspan="2">Telephone:</th> <!-- Определя колко редове ще обхваща клетката -->
        <td>55577854</td>
    </tr>
    <tr>
        <td>55577855</td>
    </tr>
</table>
```

### 3. Формуляри в HTML

* HTML формите позволяват на потребителя да попълва данни и да ги изпраща до сървъра.
* Полетата за вход може да съдържат текст, номер, дата, радио бутон, ...
*   Създаване на форма за контакт:

```html
<form>
First name: <input type="text" name="firstname"><br>
Last name: <input type="text" name="lastname"><br>
<input type="submit" value="Submit">
</form>
```

#### Tипове вход

```html
<form>
    <p>First name:</p>
    <input type="text" <!-- Определя поле за въвеждане на текст -->
        value="First Name" /> <!-- Текстът по подразбиране се показва в полето за въвеждане -->

    <p>Last name:</p>
    <input type="text"  
        placeholder="Last Name" /> <!-- Текст, който се визуализира, но се премахва при въвеждане от потребителя -->

    <p>Password:</p>
    <input type="password"  placeholder="Password" /> <!-- Определя поле за въвеждане на парола(текстът се маскира с ● или *) -->

    <p>Gender:</p>
    <input type="radio" name="gender"/> Male <br/> <!-- Дефинира радио бутон -->
    <input type="radio" name="gender"/> Female <br/>
    <input type="radio" name="gender"/> Other <br/>
    <!-- ЗАБЕЛЕЖКА: Всички радио бутони на група ТРЯБВА да споделят едно и също име -->

    <p>What transport do you use:</p>
    <input type="checkbox"/> I have a bike <!-- Дефинира отметка --><br />
    <input type="checkbox"/> I have a car <br/>

    <input type="submit" value="Send"/> <!-- Дефинира бутон за изпращане -->
</form>
```

#### Падащ списък

* Падащите списъци се дефинират с тага **\<select>**
*   **\<option>** елементите определят опции, които могат да бъдат избирани

```html
<form>
  <select>
    <option>Volvo</option>
    <option>Saab</option>
    <option>Fiat</option>
    <option>Audi</option>
  </select>
</form>
```

#### Тексови полета

* Многоредови полета за въвеждане на текс
* Дефинира се с тага **\<textarea>**
*   Атрибутите **row** и **col** дефинират колко реда и колони ще обхване текстовата област

```html
<form>
  <textarea rows="10" cols="30">
    The cat was playing in the garden.
  </textarea>
</form>
```

### 4. CSS

CSS определя стила на HTML елементите:

* Определя шрифтове, цветове, полета, размери, позициониране ...

CSS се декларира в следния формат: **свойство:стойност**

* Вграденият CSS дефинира правила за форматиране на определен HTML елемент:

```html
<p style="color: red;">I am a RED text paragraph</p>
```

#### Шрифтове - семейство шрифтове, размер и цветове

* **color:** определя цвета на буквите
* **font-family:** трябва да съдържа няколко шрифта. Ако браузърът не поддържа първия, той ще опита следващия
*   **font-size:** задава размера

```html
<p style="color: #AA77FF;
    font-family: Consolas, monospace;
    font-size: 24pt;">Purple 24pt</p>
```

#### Блокови елементи

* Блокови елементи (\<div>;\<h1>;\<p>): Винаги започвайте на нов ред. Заемат цялата налична ширина.
*   **\<div>** елемента: често се използва като контейнер за други HTML елементи

```html
<div style="background-color:#AA77FF;color:white;">
  <h2>London</h2>
  <div style="background-color:red;color:white;">
    <p>London is the capital city of England.<p>
  </div>
</div>
```

#### Вградени елементи

* Вградени елементи (\<span>;\<a>;\<img>): Не започват на нов ред. Заемат само толкова ширина, колкото е необходима.
*   **\<span>** елемент: Често е използван за контейнер за текст

```html
<p>This is a very <span style="background-color:red; color: white;">important</span> message.</p>
```

#### Граници и фонове

* **border:** определя типа, дебелината, цвета
* **border-radius:** закръгля граничните краища
*   **background:** задава фона

```html
<p style="border: 2px solid red;
    text-align: center;
    border-radius: 10px;
    background: lightgray;">Red Border</p>
```

#### Външни отстояния

* Използва се за генериране на пространство около елементи
*   **margin** свойсвото задава размера на празното пространство извън границата

```html
<p style="border: 5px solid black; margin: 30px;">This page demonstrates margins.</p>
```

#### Вътрeшни отстояния

* Използва се за генериране на пространство около съдържанието
*   Свойството **padding** задава размера на празното пространство вътре в границата

```html
<p style="border: 5px solid black; padding: 20px;">This page demonstrates padding.</p>
```

#### Отделяне на съдържание и оформление

* **.class** = избира група елементи с посочения клас
* **#id** = избира уникален елемент
* **tag** = избира всички посочени тагове

document.html

```html
<!DOCTYPE html>
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="style.css">
  </head>
  <body id="content">
  <p>This is a <span class="special"> special beer</span> for <span class= "special">special drinkers</span>.</p>
  </body>
</html>
```

style.css

```css
#content {
  background: #EEE;
}
p {
  font-size: 24pt;
}
.special {
  font-style: italic;
  font-weight: bold;
  color: blue;
}
```

## 4. HTTP Server

С помощта на този документ, вие ще създаде малък HTTP сървър, който изпраща и приема заявки. В последствие ще създадаем малък MVC Framework, който ще работи с нашият HTTP сървър.

### 1. Архитектура

Първо нека да създадем архитектурата на нашият проект. Създайте нов Solution и го кръстете **MiniServer**. Добавете два проекта към него:

* **MiniServer.HTTP**
* **MiniServer.WebServer**

### 2. MiniServer.HTTP Архитектура

HTTP проекта ще съдържа всички класове (и техните интерфейси), които ще бъда изпозлвани да имплементираме HTTP комуникацията с TCP Link между клиента и нашият сървър. Можем да работим само с низове и байт масиви, но ще следваме добрите практики и ще го направим кода да бъде лесно четим и преизползваем.

Създайте следните папки в проекта **MiniServer.HTTP**

![04. HTTP Server/Pictures/01.png](<04. HTTP Server/Pictures/01.png>)

Както виждате архитектурата на папките е много добре разделена. Нека сега да започнем със създаването на класовете.

#### Common папка

Common папката, ще съдържа класове, които се изпозлват в целият проект. Ще имаме два класа: GlobalConstants и CoreValidator.

##### GlobalConstants

Създайте статичен клас GlobalConstants, който ще бъде използван за споеделните константи:

```cs
public static class GlobalConstants
{
    public const string HttpOneProtocolFragment = "HTTP/1.1";
    public const string HostHeaderKey = "Host";
    public const string HttpNewLine = "\r\n";
}
```

Това са единствените константи, от които имаме нужда засега.

##### CoreValidator

Създайте клас CoreValidator, който ще има два метода, за проверка за null стойности или празни стрингове:

```cs
public class CoreValidator
{
    public static void ThrowIfNull(object obj, string name)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(name);
        }
    }

    public static void ThrowIfNullOrEmpty(string text, string name)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException($"{name} cannot be null or empty.", name);
        }
    }
}
```

#### Enums папка

Enums папката ще съдържа enumerations. Има два енъма, от които сървърът ще се нуждае: HttpRequestMethod и HttpResponseStatusCode.

##### HttpRequestMethod

Създайте Enum, с името HttpRequestMethod. Той ще дефинира, метода ,които сървъра получава

```cs
public enum HttpRequestMethod
{
    Get, Post, Put, Delete
}
```

Нашият сървър, ще поддържа само GET, POST, PUT и DELETE и заявки. Нямаме нужда от по-сложни заявки засега.

##### HttpResponseStatusCode

Създайте Enum, с името HttpResponseStatusCode. Той ще дефинира статус кода от отговора на нашият сървър. Този Enum, ще съдържа стойности, които са стутусите и цели числа, които ще представляват статус кода.

```cs
public enum HttpResponseStatusCode
{
    Ok = 200,
    Created = 201,
    Found = 302,
    SeeOther = 303,
    BadRequest = 400,
    Unauthorized = 401,
    Forbidden = 403,
    NotFound = 404,
    InternalServerError = 500
}
```

За сега нашият малък сървър, няма нужда да съдържа всички други статус кодове. Тези достатъчно сървъра и клиента да си комуникират.

#### Exceptions папка

Exceptions папката ще съдържа класове, които отговорят за правилното менажиране на грешките в сървъра. За начало ще имаме класа, които ще отговарят за грешките: BadRequestException и InternalServerErrorException. Тези грешки, ще помагат, така, че сървъра винаги да връща отговор, дори в случай на Runtime Error.

Сървърът първо ще хваща грешки, които са от тип BadRequestException. Ако хване грешка от този тип, сървъра трябва да върне **400 Bad Request Response** и съобщение са грешката.

Всички други грешки ще бъдат от тип InternalServerErrorException или от базовия клас "Exception". Ако прихванем една от тези грешки, сървъра трябва да върне a **500 Internal Server Error**" и съобщение за грешката.

##### BadRequestException

Създайте клас, който се казва BadRequestException. Тази грешка ще бъде хвърлена, когато сървъра не успее да парсне HttpRequest, като Unsupported HTTP Protocol, Unsupported HTTP Method, Malformed Request и т.н. Класът трябва да наследява, Exception класа и трябва да има съобщение по подразбиране: **The Request was malformed or contains unsupported elements.**

##### InternalServerErrorException

Създайте клас, който се казва InternalServerErrorException. Тази грешка ще бъде хвърлена, когато не се е предполагало сървъра да се справи с нея. Класът трябва да наследява, Exception класа и трябва да има съобщение по подразбиране: **The Server has encountered an error.**

#### Extensions папка

Extensions папката, ще съдържа extension методи, които ще ни помагат в разработката на нашият сървър. Ще има един клас StringExtensions.

##### StringExtensions

В този клас, имплементирайте низ extension метод, който се казва Capitalize(). Той трябва да направи първата буква главна и всички други малки.

#### Headers папка

Headers папката, ще съдържа класове и интерфейси, които ще съхраняват данни за HTTP Headers на заявката и отговора.

##### HttpHeader

Създайте клас, който се казва HttpHeader. Той ще съхранява данните за HTTP Request/Response Header.

```cs
public HttpHeader(string key, string value)
{
    CoreValidator.ThrowIfNullOrEmpty(value, nameof(value));
    this.Key = key;
    this.Value = value;
}
public string Key { get; }
public string Value { get; }
public override string ToString()
{
    return $"{this.Key}: {this.Value}";
}
```

Пропъртито "Key", ще се използва за името на Header-a и пропъртито "Value", ще съдържа стойността. Имаме и в помощ "ToString()" метода, който ще връща добре форматиран и готов за използване Header.

##### IHttpHeaderCollection

Създайте интерфейс, който се казва IHttpHeaderCollection, който ще опише действията на "Repository-like object" за HttpHeaders.

```cs
public interface IHttpHeaderCollection
{
    void AddHeader(HttpHeader header);
    bool ContainsHeader(string key);
    HttpHeader GetHeader(string key);
}
```

##### HttpHeaderCollection

Създайте клас, който се казва HttpHeaderCollection, който имплементира IHttpHeaderCollection интерфейса. Този клас е като "Repository". Трябва да има Dictionary колекция на всички Headers и трябва да имплементирате всички методи на интерфейса.

```cs
class HttpHeaderCollection : IHttpHeaderCollection
{
    private readonly Dictionary<string, HttpHeader> headers;
    public HttpHeaderCollection()
    {
        this.headers = new Dictionary<string, HttpHeader>();
    }
    public void AddHeader(HttpHeader header) ...
    public bool ContainsHeader(string key) ...
    public HttpHeader GetHeader(string key) ...
    public override string ToString() ...
}
```

Имплементирайте всеки един от тези методи със следните функционалности:

*   **AddHeader()** = Добавя Header-a. в речника с ключ – ключа на Header-a и стойност самият Header.

    – **ContainsHeader()** = Главна причина да използва Dictionary. Позволява ни бързо търсене. Трябва върнем boolean, в зависимост от това дали колекцията съдържа даденият ключ.
* **GetHeader()** = Връща Header-a от колекцията с дадения ключ. Ако не съществува такъв Header, метода трябва да върне null.
* **ToString()** = Връща всички Headers, като низ, разделени с нов ред - ("/r/n") или Environment.NewLine

#### Responses папка

Responses папката ще съдържа класове и интерфейси, които съдържат и манипулират информация за "HTTP Responses".

##### IHttpResponse

Създайте интерфейс, който се казва IHttpResponse и ще се съдържа следните пропъртита и методи:

```cs
public interface IHttpResponse
{
    HttpResponseStatusCode StatusCode { get; set; }
    IHttpHeaderCollection Headers { get; }
    byte[] Content { get; set; }
    void AddHeader(HttpHeader header);
    byte[] GetBytes();
}
```

##### HttpResponse

Създайте клас, който се казва HttpResponse и имплементира IHttpResponse интерфейса.

```cs
public class HttpResponse : IHttpResponse
{
    public HttpResponse()
    {
        this.Headers = new HttpHeaderCollection();
        this.Content = new byte[0];
    }
    public HttpResponse(HttpResponseStatusCode statusCode) : this()
    {
        CoreValidator.ThrowIfNull(statusCode, nameof(statusCode));
        this.StatusCode = statusCode;
    }
    public HttpResponseStatusCode StatusCode { get; set; }
    public IHttpHeaderCollection Headers { get; }
    public byte[] Content { get; set; }
    public void AddHeader(HttpHeader header) ...
    public byte[] GetBytes() ...
    public override string ToString() ...
}
```

Както виждате HttpResponse съдържа: StatusCode, Headers, Content и т.н. Това са единствените неща, от които ние се нуждаем за сега. HttpResponse се инициализира с обект с Null ли по подразбиране стойности.

Сървърът получава Requests в текстов формат и трябва върне Responses в същият формат.

Репрезентацията на низа от HTTP Responses са в следният формат:

```
{protocol} {statusCode} {status}
{header1key}: {header1value}
{header2key}: {header2value}
...
<CRLF>
{content}
```

ЗАБЕЛЕЖКА: Както вече знаете, съдържанието (Response body) не е задължително.

Сега, докато изграждаме нашият HttpResponse обект, може да присвоим стойност за нашият StatusCode или може да го оставим за напред. Най-често ще присвояваме стойностите чрез конструктора.

##### AddHeader() метод

We can add Headers to it, gradually with the processing of the Request, using the AddHeader() method. Можем добавяме Headers, като използваме AddHeader() метода.

```cs
public void AddHeader(HttpHeader header)
{
    CoreValidator.ThrowIfNull(header, nameof(header));
    this.Headers.Add(header);
}
```

Другите пропъртита, StatusCode и Content могат да бъдат присвоени стойности от "външният свят", като използват публичните им сетъри.

Сега нека да видим ToString() и GetBytes() какво правят.

##### ToString() метод

ToString() метода формира Response реда – този ред съдържа протокола, статус кода, статус и Response Headers, като завършва с празен ред. Тези пропъртита са съединени в един низ и върнати в края.

```cs
public override string ToString()
{
    StringBuilder result = new StringBuilder();
    result
    .Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode.ToString()}")
    .Append(GlobalConstants.HttpNewLine)
    .Append(this.Headers)
    .Append(GlobalConstants.HttpNewLine)
    .Append(GlobalConstants.HttpNewLine);
    return result.ToString();
}
```

И точно сега се нуждаем от GetBytes() метода.

##### GetBytes() метод

And with that we are finished with the HTTP work for now. We can proceed to the main functionality of the Server.

GetBytes() метода конвертира резултата от ToString() метода до byte\[] масив, и долепя към него Content bytes, затова формираме целият Response до байт формат. Точна това, което трябва да изпратим до сървъра.

И вече приключихме с работата по нашият HTTP сървър за сега.

#### Requests папка

Сега е време да съберем всичко написано до момента в главните функциониращи класове.

Requests папката ще съдържа класове и интерфейси за съхранение и манипулиране данни за HTTP заявките.

##### IHttpRequest

Създайте интерфейс, който се казва IHttpRequest, който ще описва поведението на Request обекта.

```cs
public interface IHttpRequest
{
    string Path { get; }
    string Url { get; }
    Dictionary<string, object> FormData { get; }
    Dictionary<string, object> QueryData { get; }
    IHttpHeaderCollection Headers { get; }
    HttpRequestMethod RequestMethod { get; }
}
```

##### HttpRequest

Създайте клас, който се казва HttpRequest, който имплементира IHttpRequest интерфейса. Класът трябва да имплементира и методите на интерфейса.

```cs
public class HttpRequest : IHttpRequest
{
    public HttpRequest(string requestString)
    {
        CoreValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));
        this.FormData = new Dictionary<string, object>();
        this.QueryData = new Dictionary<string, object>();
        this.Headers = new HttpHeaderCollection();
    }
    public string Path { get; private set; }
    public string Url { get; private set; }
    public Dictionary<string, object> FormData { get; }
    public Dictionary<string, object> QueryData { get; }
    public IHttpHeaderCollection Headers { get; }
    public HttpRequestMethod RequestMethod { get; private set; }
}
```

Както виждате HttpRequest, съдържа: Path, Url, RequestMethod, Headers, Data. Тези данни идвам променлива requestString, която се подава в констуктора. Това е начина, по които HttpRequest ще се инициализира. requestString ще изглежда по този начин:

```
{method} {url} {protocol}
{header1key}: {header1value}
{header2key}: {header2value}
...
<CRLF>
{bodyparameter1key}={bodyparameter1value}&{bodyparameter2key}={bodyparameter2value}...
```

ВНИМАНИЕ: Както вече знаете, че body parameters не за задължителни. Нека да разбием една нормална заявка и да видим как тя трябва да се мапне към нашите пропъртита.

Сега е време да имплементираме повече логика, което означава много методи, ако искаме да спазваме принципите за High-Quality Code. Имплементирайте следните методи.

```cs
private bool IsValidRequestLine(string[] requestLine)
private bool IsValidRequestQueryString(string queryString, string[] queryParameters)
private void ParseRequestMethod(string[] requestLine)
private void ParseRequestUrl(string[] requestLine)
private void ParseRequestPath()
private void ParseHeaders(string[] requestContent)
private void ParseCookies()
private void ParseQueryParameters()
private void ParseFormDataParameters(string formData)
private void ParseRequestParameters(string formData)
private void ParseRequest(string requestString)
```

**ParseRequest()** е метода откъдето започва всичко:

```cs
public HttpRequest(string requestString)
{
    CoreValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));

    this.FormData = new Dictionary<string, object>();
    this.QueryData = new Dictionary<string, object>();
    this.Headers = new HttpHeaderCollection();

    this.ParseRequest(requestString);
}
```

Нека да видим как изглежда той:

```cs
private void ParseRequest(string requestString)
{
    string[] splitRequestContent = requestString.Split(new[] { GlobalConstants.HttpNewLine }, StringSplitOptions.None);

    string[] requestLine = splitRequestContent[0].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    if (!this.IsValidRequestLine(requestLine))
    {
        throw new BadRequestException();
    }

    this.ParseRequestMethod(requestLine);
    this.ParseRequestUrl(requestLine);
    this.ParseRequestPath();

    this.ParseHeaders(splitRequestContent.Skip(1).ToArray());
    this.ParseCookies();
    this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
}
```

Както виждате requestString е разделен на нови редове в масив. Взимаме първият ред (The Request Line) и го разделяме. След това следват серия от проверки и присвояване не стойности към пропъртита.

Ще се наложи вие да имплементирате тези методи. Разбира се, ще ви бъдат дадени насоки, как да се справите с тях.

##### IsValidRequestLine() метод

Този метод проверя дали, разделеният requestLine съдържа точно 3 елемента и също така дали последният елемент е равен на "HTTP/1.1". Метода връща булев резултат.

##### IsValidRequestQueryString() метод

Този метод се използва в ParseQueryParameters() метода. Проверява дали Query низа е NOT NULL или празен и също така дали има поне един или много queryParameters.

##### ParseRequestMethod() метод

RequestMethod присвоя стойността, като преобразуваме първият елемент от разделеният requestLine.

##### ParseRequestUrl() метод

Url присвоява стойността от вторият елемент на разделеният requestLine.

##### ParseRequestPath() метод

Path присвоява стойността, като разделим Url и вземем само пътя от него.

##### ParseHeaders() метод

Пропускаме първият ред от requestLine и обхождаме всички останали редове, докато не стигнем празен ред. Всеки ред представлява header, който трябва да бъде разделен и преобразуван към правилният тип. След това информацията от низа е прехвърлена към HttpHeader обекта и е добавен към Headers пропертито на Request. Хвърлете BadRequestException, ако Host липсва след преобразуването.

##### ParseQueryParameters() метод

Извадете Query низа, като разделите "Request's Url" и вземете само query от него. След това разделете Query низа в различни параметри и го прехвърлете към "Query Data Dictionary". Валидирайте Query низа, като извикате IsValidrequestQueryString() метода. Ако в Request's Url липсва Query низа, не предприемайте действия. Хвърлете BadRequestException, ако Query не е валиден.

##### ParseFormDataParameters() метод

Разделете Request's Body в различни параметри и го добавате към Form Data Dictionary. Не предприемайте действия, ако Request не съдържа тяло.

##### ParseRequestParameters() метод

Този метод извиква ParseQueryParameters() и ParseFormDataParameters() методите. Това е просто wrapping метод.

Ако сте имплементирали всички правилно, би трябвало да преобразувате дори и много сложни заявки без проблем.

### 3. MiniServer.WebServer Архитектура

WebServer проекта ще съдържа информация за класовете, които изграждат връзка с TCP. Тези класове ще комуникират с класовете от HTTP Project. Проекта ще изнася няколко класа, които ще служат за външния свят, за да създаваме приложния.

Създайте следните папки в проекта **MiniServer.WebServer**

![04. HTTP Server/Pictures/02.png](<04. HTTP Server/Pictures/02.png>)

#### Results папка

Results папката ще съдържа няколко класа, които са наследени от HttpResponse класа. Тези класове, ще използват за имплементираме прости приложения с MiniServer. Трябва да създадем три класа вътре: TextResult, HtmlResult и RedirectResult.

##### TextResult

Създаден е така, че да връща текст, като отговор. Трябва да има Content-Type и header text/plain.

```cs
public class TextResult : HttpResponse
{
    public TextResult(string content, HttpResponseStatusCode responseStatusCode, string contentType = "text/plain; charset=utf-8") : base(responseStatusCode)
    {
        this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, contentType));
        this.Content = Encoding.UTF8.GetBytes(content);
    }

    public TextResult(byte[] content, HttpResponseStatusCode responseStatusCode, string contentType = "text/plain; charset=utf-8") : base(responseStatusCode)
    {
        this.Content = content;
        this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, contentType);
    }
}
```

#### HtmlResult

Създаваме този клас, да връща HTML в себе си. Така чрез този клас, ние можем да върнем HTML или просто съобщение. Трябва да има Content-Type и header text/html.

```cs
public class HtmlResult : HttpResponse
{
    public HtmlResult(string content, HttpResponseStatusCode responseStatusCode) : base(responseStatusCode)
    {
        this.Headers.AddHeader(new HttpHeader(HttpHeader.ContentType, "text/html; charset=utf-8"));
        this.Content = Encoding.UTF8.GetBytes(content);
    }
}
```

#### RedirectResult

Този клас, не трябва да има Content. Единствената задача е да бъде пренасочен. Този Response има локация. Статуса трябва да бъде SeeOther.

```cs
public class RedirectResult : HttpResponse
{
    public RedirectResult(string location) : base(HttpResponseStatusCode.SeeOther)
    {
        this.Headers.AddHeader(new HttpHeader(HttpHeader.Location, location));  
    }
}
```

#### Routing папка

В папката, ще съдържа логиката за рутиране и конфигурация на сървъра. Ще съдържа един интерфейс и един клас: IServerRoutingTable and ServerRoutingTable.

```cs
public interface IServerRoutingTable
{
    void Add(HttpRequestMethod method, string path, Func<IHttpRequest, IHttpResponse> func);
    bool Contains(HttpRequestMethod requestMethod, string path);
    Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path);
}
```

Този клас съдържа големи колекции от насложени асоциативни масиви, които ще се използват за рутиране.

```cs
public class ServerRoutingTable : IServerRoutingTable
{
    private readonly Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>> routes;

    public ServerRoutingTable()
    {
        this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>>
        {
            [HttpRequestMethod.Get] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
            [HttpRequestMethod.Post] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
            [HttpRequestMethod.Put] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
            [HttpRequestMethod.Delete] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
        };
    }
    public void Add(HttpRequestMethod method, string path, Func<IHttpRequest, IHttpResponse> func) ...
    public bool Contains(HttpRequestMethod requestMethod, string path) ... 
    public Func<IHttpRequest, IHttpResponse> Get(HttpRequestMethod requestMethod, string path) ...
}
```

Това е главният алгоритъм за Request Handling. Request Handler се конфигурира, като настройва Request Method и Path на заявката. Handler сам по себе си е функция, която приема Request параметър и генерира Response параметър.

```
<Method, <Path, Func>>
```

Ще видим по-надолу в примерите как работи.

#### Server клас

Server класа е обвивка за TCP connection. Използва TcpListener , за да запише връзката с клиента и да я подаде на ConnectionHandler, която го изпълнява.

```cs
public class Server
{
    private const string LocalhostIpAddress = "127.0.0.1";
    private readonly int port;
    private readonly TcpListener listener;
    private readonly IServerRoutingTable serverRoutingTable;
    private bool isRunning;

    public Server(int port, IServerRoutingTable serverRoutingTable) ...
    public void Run() ...
    private async Task Listen(Socket client) ...
}
```

Конструкторът се използва, за да бъде инициализиран Listener и RoutingTable.

```cs
public Server(int port, IServerRoutingTable serverRoutingTable)
{
    this.port = port;
    this.listener = new TcpListener(IPAddress.Parse(LocalhostIpAddress), port);
    this.serverRoutingTable = serverRoutingTable;
}
```

Този метод се използва за процеса на слушане. Процесът трябва да бъде асинхронен, за да подсигури функционалността, когато двама клиенти изпратят заявка.

```cs
public void Run()
{
    this.listener.Start();
    this.isRunning = true;
    Console.WriteLine($"Server started at http://{LocalhostIpAddress}:{this.port}");
    while (this.isRunning)
    {
        Console.WriteLine("Waitying for client ...");
        var client = this.listener.AcceptSocketAsync().GetAwaiter().GetResult();
        Task.Run(() => this.Listen(client));
    }
}
```

Listen() метода е главният процес при свързване с клиента.

```cs
private async Task Listen(Socket client)
{
    var connectionHandler = new ConnectionHandler(client, this.serverRoutingTable);
    await connectionHandler.ProcessRequestAsync();
}
```

Както виждате, ние създаваме нов ConnectionHandler, за всяка нова връзка и я подаваме на ConnectionHandler, заедно с routing table, така че заявката да бъде изпълнена.

#### ConnectionHandler клас

ConnectionHandler е клас, който произвежда връзката с клиента. Приема връзката, изважда заявката, като низ и минава процес през routing table, като я изпраща обратно на "Response" в байт формат, чрез TCP link.

```cs
public class ConnectionHandler
{
    private readonly Socket client;
    private readonly IServerRoutingTable serviceRoutingTable;
    public ConnectionHandler(Socket client, IServerRoutingTable serviceRoutingTable) ...
    public void ProcessRequest() ...
    private IHttpRequest ReadRequest() ...
    private IHttpResponse HandleResponse(IHttpRequest httpRequest) ...
    private void PrepareResponse(IHttpResponse httpResponse) ...
}
```

Конструктора се използва, за да се инициализира socket и routing table.

```cs
public ConnectionHandler(Socket client, IServerRoutingTable serviceRoutingTable)
{
    CoreValidator.ThrowIfNull(client, nameof(client));
    CoreValidator.ThrowIfNull(serviceRoutingTable, nameof(serviceRoutingTable));
    this.client = client;
    this.serviceRoutingTable = serviceRoutingTable;
}
```

ProcessRequestAsync() метода е асинхронен метод, който съдържа главната функционалност на класа. Използва и други методи да чете заявки, да ги обработва и да създава Response, Който да бъде върнат на клиента и най-накрая да затвори връзката.

```cs
public async Task ProcessRequestAsync()
{
    try
    {
        var httpRequest = this.ReadRequest();

        if (httpRequest != null)
        {
            Console.WriteLine($"Processing: {httpRequest.Result.RequestMethod} {httpRequest.Result.Path}");
            var httpResponse = this.HandleRequest(httpRequest.Result);
            await this.PrepareResponse(httpResponse);
        }
    }
    catch (BadRequestException e)
    {
        await this.PrepareResponse(new TextResult(e.ToString(), HttpResponseStatusCode.BadRequest));
    }
    catch (Exception e)
    {
        await this.PrepareResponse(new TextResult(e.ToString(), HttpResponseStatusCode.InternalServerError));
    }
}
```

ReadRequest() метода е асинхронен метод, който чете байт данни, от връзката с клиента, изважда низа от заявката и след това го обръща в HttpRequest обект.

```cs
private async Task<IHttpRequest> ReadRequest()
{
    var result = new StringBuilder();
    var data = new ArraySegment<byte>(new byte[1024]);
    while (true)
    {
        int numberOfBytesRead = await this.client.ReceiveAsync(data.Array, SocketFlags.None);

        if (numberOfBytesRead == 0)
        {
            break;
        }
        var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
        result.Append(bytesAsString);
        if (numberOfBytesRead < 1023)
        {
            break;
        }
    }
    if (result.Length == 0)
    {
        return null;
    }
    return new HttpRequest(result.ToString());
}
```

HandleRequest() метода проверява ако routing table има handler за дадената заявка, като използва Request's Method и Path

* Ако няма такъв handler Not Found отговор е върнат.
*   Ако има такъв handler, функцията е извикана и резултата е върнат.

```cs
    private IHttpResponse HandleRequest(IHttpRequest httpRequest)
    {
      if (!this.serverRoutingTable.Contains(httpRequest.RequestMethod, httpRequest.Path))
      {
          return new TextResult($"Route with method {httpRequest.RequestMethod} and path \"{httpRequest.Path}\" not found.", HttpResponseStatusCode.NotFound);
      }
      return this.serverRoutingTable.Get(httpRequest.RequestMethod, httpRequest.Path).Invoke(httpRequest);
    }
    ```

    PrepareResponse() метода изважда байт данни от отговора и ги изпраща на клиента.

    ```
    private async Task PrepareResponse(IHttpResponse httpResponse)
    {
      byte[] byteSegments = httpResponse.GetBytes();
      await this.client.SendAsync(byteSegments, SocketFlags.None);
    }
```

Това е финалният вид на нашия ConnectionHandler и WebServer проект.&#x20;

### 4. Hello, World!

Създайте трети проект, който да се казва **MiniServer.Demo**. Той трябва да реферира и двата проекта **MiniServer.HTTP** и **MiniServer.WebServer**.

Създайте следните класове:

#### HomeController клас

HomeController класа трябва да има един метод – Index(), който да изглежда по този начин:

```cs
public class HomeController
{
    public IHttpResponse Index(IHttpRequest request)
    {
        string content = "<h1>#1 WEB PAGE</h1><p>The Number One Web Page.</p>";
        return new HtmlResult(content, HttpResponseStatusCode.Ok);
    }
}
```

#### Launcher клас

Launcher класа трябва да съдържа Main метода, който инстанциира Server и го конфигурира да се справя със заявките, като използва ServerRoutingTable.

Конфигурирайте само пътя "/", като използва ламбда функция, която извиква HomeController.Index метода.

```cs
public static void Main(string[] args)
{
    IServerRoutingTable serverRoutingTable = new ServerRoutingTable();
    serverRoutingTable.Add
    (
        HttpRequestMethod.Get,
        path: "/",
        request => new HomeController().Index(request)
    );
    Server server = new Server(port: 8080, serverRoutingTable);
    server.Run();
}
```

Сега стартирайте **MiniServer.Demo** проекта и трябва да видите това на конзолата, ако всичко е наред:

![04. HTTP Server/Pictures/03.png](<04. HTTP Server/Pictures/03.png>)

Отворете браузъра и отидете на **localhost:8000** и трябва да видите това:

![04. HTTP Server/Pictures/04.png](<04. HTTP Server/Pictures/04.png>)

Поздравления! Завършихте първото си приложение с MiniServer.

## 5.