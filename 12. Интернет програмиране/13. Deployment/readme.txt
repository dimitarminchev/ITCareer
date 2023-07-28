## 13. Deployment
[Работещ пример](https://aspnet-simple-chat-app.herokuapp.com/index.html) (Може да отнеме известно време докато се зареди)

### Какво ни трябва
* Акаунт в Heroku (който е безплатен)
* Акаунт в Github (който трябва да имате)
* Проект за качване

### Променяне на проекта да е готов за качване
1. Влезте в [примерния проект](https://github.com/dimitarminchev/ITCareer/tree/c64d596683ec8cc73e0a791e051417b3352a92a7/12.%20Internet%20Programming/15.%20Deployment/SimpleChatApp/README.md)
2. Копирайте добавеното в Program.cs към вашия проект
3. Влезте в Properties/launchSettings.json и се погрижете че стойността на ASPNETCORE\_ENVIRONMENT е променена на Production
4. Изтрийте appsettings.json ако го използвате
5. В Startup.cs премахнете Configuration и го заминете със Environment класа
6. Качете проекта си във Github

### Създаване на asp.net core проект в Heroku
1. Създадете акаунт ако нямате
2. Отидете на [този линк](https://dashboard.heroku.com/new-app) или натиснете New и Create new app
3. В приложението влезте в Settings, отидете на Buildpacks и добавете нов със този url [https://github.com/jincod/dotnetcore-buildpack](https://github.com/jincod/dotnetcore-buildpack)
4. Отидете на Deploy, изберете Github (ако не сте свързани се свържете), намерете вашето приложение и го качете със Deploy Branch
5. Изчакайте приложението да се качи
6. Ако имате проблеми отидете на More, View logs и от там се опитайте да намерите проблема

### Неща да си имаме на предвид
* Сменяме appsettings.json със Environment класа понеже от настройките на Heroku приложението можете да въведете 'Config Vars' които ще се дадат на програмата и можем да ги достъпим със Environment класа
*   Ако искате да включите приложението от Visual Studio просто трябва да смените приложението да използва Kastrel вместо IIS &#x20;

![Image file](https://i.imgur.com/o8yPFCl.png)

* Heorku ви предлага безплатни и платени 'Add-ons' който можете да достъпите като отидете на Resources, един от тях е Postgres който може да се свържи със Entity Framework
* Heroku ще изключи програмата когато не се използва за дълго време и после отново ще я включи ако някой се опита да я достъпи (това може да направи на програмата началното достъпване много бавно зависейки от големината на проекта)
* Heroku ще ви даде PORT към който ще трябва да се свържете във Environment със име PORT
* Примерния проект използва Sqlite за база данни който се свързва към app.db файла
