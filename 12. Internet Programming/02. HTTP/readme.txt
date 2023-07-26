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
