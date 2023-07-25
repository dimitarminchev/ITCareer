# Модул 8. Въведение в операционни и вградени системи

[Материали](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8.%20%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8.zip) | [Видео](https://youtube.com/playlist?list=PL-w\_n7hgFuN3jhJvjfG5OCN\_WEeh4c2j5)

## Операционни системи

**Операционната система** взаимодейства пряко с хардуера и служи за платформа на други приложения, които в повечето случаи се използват от крайния потребител.

### Работна среда

Работната среда се състои от един Линукс сървър с реален Интернет протокол адрес **46.10.253.12** и множество Windows клиенти. Достъпа на клиентите до сървъра се осъществява посредством [Telnet](https://en.wikipedia.org/wiki/Telnet) използвайки [SSH](https://bg.wikipedia.org/wiki/SSH).

Telnet е разработен през 1969 г., като се започне с [RFC 15](https://tools.ietf.org/html/rfc15), разширен в [RFC 854](https://tools.ietf.org/html/rfc854) и стандартизиран като интернет стандарт [STD 8](https://en.wikipedia.org/wiki/STD\_8) на [Internet Engineering Task Force](https://en.wikipedia.org/wiki/Internet\_Engineering\_Task\_Force), един от първите интернет стандарти. Telnet осигурява достъп до интерфейс на командния ред на отдалечен хост до мрежови устройства и/или операционни системи. Поради сериозните опасения за сигурността при използването на Telnet през отворена мрежа като Интернет, използването му за тази цел значително намаля в полза на SSH.

SSH използва криптография с публичен ключ, за да удостовери отдалечения компютър и да му позволи да удостовери потребителя, ако е необходимо. Протоколът обикновено се използва за влизане в отдалечена машина и изпълнение на команди. Той може да прехвърля файлове, като използва свързаните протоколи за прехвърляне на файлове (SFTP) или защитени копия (SCP).

Системният софтуер включва шелл (shell), текстов редактор (text editor), компилатор (compiler) и дебъгер (debugger), инструменти (tools) и демони (daemons) на операционната система. Тези компоненти са изцяло системен софтуер, базиран на ядрото и библиотеката C.

### Oтдалечен достъп

За осъществяване на отдалечен достъп до сървъра се изполва програмата **PuTTY**, която се разпространява като софтуер с отворен код и може да бъде изтеглена безплатно от Интернет на адрес: https://putty.org/

![putty.png](Linux/putty.png)

### Как да получите помощ в Линукс?

Повечето системни приложения и команди, работещи в конзолен режим на операционната система Линукс, имат съпътстваща документация във формата на страници от ръководства - **manual pages**. За достъп до тях можете да използвате програмата **man**, със следния формат:

```
man <команда>
```

където _<команда>_ е името на приложението, за което искате да получите информация. Ако съществува ръководство за избраната команда, man ще отпечата първата страница на екрана и ще предостави на потребителя средства за навигация в останалата част. Подробно описание на функциите, съответно можете да видите със следната команда:

```
man man
```

![man.png](<Linux/man.png>)

По-важните клавиши, които можете да изполвате при работа в програмата са **PgUp** за прелистване на страница нагоре, **PgDn** за прелистване на страница надолу и клавиша **q** за изход.

### Файлове, директории и файлови системи

**Файловете** са базово понятие във всички популярни операционни системи. Това напълно се отнася и за ОС Линукс, която се характеризира с това, че в нея "всичко е файл" ("everything is a file"). Файловете се групират в **директории**, които от своя страна могат да съдържат други под-директории и по този начин се създава дървовидна структура.

[Файловата система](https://github.com/fosscourse/wiki/wiki/%D0%A4%D0%B0%D0%B9%D0%BB%D0%BE%D0%B2%D0%B0\_%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B0\_%D0%B2\_%D0%9B%D0%B8%D0%BD%D1%83%D0%BA%D1%81\_-\_%D1%81%D1%82%D1%80%D1%83%D0%BA%D1%82%D1%83%D1%80%D0%B0\_%D0%B8\_%D0%BE%D1%81%D0%BD%D0%BE%D0%B2%D0%BD%D0%B8\_%D0%BF%D0%BE%D0%BD%D1%8F%D1%82%D0%B8%D1%8F) е начина за структуриране и организация на данните в компютъра. Тя представлява служебна таблица записана на диска, която операционната система използва, за да получи достъп до файловете. Записите в таблицата се наричат **inode** и накратко могат да се определят като сериен номер на файла.

Основни команди за работа с файловата система под Линукс са представени в таблицата по-долу:

| Команда | Описание                                             |
| ------- | ---------------------------------------------------- |
| pwd     | Отпечава името на текущата директория                |
| ls      | Списък на съдържанието на директорията               |
| mkdir   | Създава директория                                   |
| cd      | Смяна на работната директория                        |
| rmdir   | Изтриване на директория                              |
| cp      | Копиране на файлове и директории                     |
| mv      | Преместване и/или преименуване на файлове            |
| rm      | Изтриване на файлове и/или директории                |
| ln      | Създава връзка между файлове                         |
| cat     | Конкатенира файлове и отпечатва на стандартния изход |

### Потребители и групи

За да получи достъп до функциите на Линукс, всеки потребител трябва да премине през процес на идентификация (**login**), където се въвежда потребителско име и парола. След въвеждане на правилна комбинация, потребителят се регистрира в операционната система и се асоциира с уникален идентификатор наречен **`uid`**, който представлява цяло положително число. Тъй като имената също трябва да са уникални, в практиката те се използват по-често от **`uid`** за идентифициране на потребителите.

От своя страна, всеки потребител принадлежи към една или повече потребителски групи. По този начин едни и същи атрибути или права могат да се задават едновременно на множество потребители, в зависимост от тяхната роля в системата.

Авторизацията за достъп до ресурсите в Линукс се осигурява, чрез тази концепция за потребители и групи. Например, операциите, които може да извършвате с файловете в ОС, зависят от правата, които притежава Вашият потребител и групата, към която принадлежи.

### Файлови права

Традиционните файлови системи поддържат три **режима** за използване на файловете: четене (_**read**_), запис (_**write**_) или изпълнение (_**execute**_).

От друга страна, всеки файл в Линукс принадлежи на **потребител** и **група**, като по подразбиране, това са създателя на файла и първичната му група. На базата на това са дефинирани три **нива** на правата за достъп до файлови операции: за собственика (_**owner**_), за групата (_**group**_) и общо (_**public**_).

Чрез комбинирането на трите нива и трите режима се получават 9 възможни характеристики на файловете, които могат да се представят със следната битова маска (първият флаг показва дали полето описва директория или файл):

![permissions.png](<Linux/permissions.png>)

На горния пример, притежателят на файла има пълни права над файла, членовете на групата на файла имат права за четене и изпълнение, а всички останали потребители имат само право за четене.

В конзолен режим на Линукс може да разгледаме правата на елементите в текущата директория с помощта на командата:

```
ls -la
```

### Управление на потребители и групи

В таблицата по-долу са дадени команди от операционната система, които се използват за управление на потребители и групи:

| Команда | Пояснение                                                           |
| ------- | ------------------------------------------------------------------- |
| id      | отпечатва реални и ефективни потребителски и групови идентификатори |
| chmod   | промяна на бита на файловия режим                                   |
| umask   | задаване на маска за създаване на файлов режим                      |
| chown   | промяна на собственика на файла и групата                           |
| chgrp   | промяна на собствеността на групата                                 |
| passwd  | промяна на потребителската парола                                   |

### Пренасочване на потоци

Линукс поддържа различни средства за работа с входно-изходните потоци, например:

* Операторът "по-голямо" **`>`** пренасочва изхода на програмите към файл, вместо да бъдат отпечатани на екрана. Ако файлът вече съществува, съдържанието му ще бъде изтрито и версия с новото съдържание ще бъде запазена.
* Операторът "двойно по-голямо" **`>>`** пренасочва изхода и го добавя към файл, ако вече съществува.
* Операторът "конвейер" **`|`** пренасочва изхода на програмата отляво като вход на програмата отдясно.

### Текстовият редактор Nano

Текстовите файлове са често използвано средство за съхранение и обмен на информация в Линукс. Поради това, почти всяка една дистрибуция предлага средства за работа с тях. В нашата работна среда ще използваме текстовия редактор **Nano**:

![nano.png](<Linux/nano.png>)

Oсновни функции на **Nano**:

| Клавиш          | Пояснение                            |
| --------------- | ------------------------------------ |
| nano readme.txt | Отваря или съдава файл readme.txt    |
| Ctrl-o Y Enter  | Запазва промените                    |
| Ctrl-r Alt-f    | Отваря нов файл                      |
| Alt->           | Превключва към следващ отворен файл  |
| Alt-<           | Превключва към предишен отворен файл |
| Ctrl-x          | Изход от редактора                   |

Полезна информация:

* [The Beginner’s Guide to Nano, the Linux Command-Line Text Editor](https://www.howtogeek.com/howto/42980/the-beginners-guide-to-nano-the-linux-command-line-text-editor/)
* [Nano text editor command cheatsheet](http://www.codexpedia.com/text-editor/nano-text-editor-command-cheatsheet/)

### Webminal

Webminal е безплатна онлайн платформа, с която може да изпробвате част от възможностите на Linux без да е необходимо да инсталитрате ОС на вашата машина.

http://webminal.org/

### Linux Bash Scripting

Bash script e скриптов език за програмиране под Linux. С негова помощ може да създавате цялостни програми с използване на различни команди. Той е мощен инструмент за автоматизация на системното администриране. Опитайте се да създадете и изпълните елементатни bash скриптове.

https://ryanstutorials.net/bash-scripting-tutorial/.

## Вградени системи

### Arduino Uno Board

![Arduino Uno Board](<Arduino/ArduinoUnoBoard.png>)

### Arduino Uno Pinout

![Arduino Uno Pinout](<Arduino/ArduinoUnoPinout.png>)

### Autodesk IDE

https://www.tinkercad.com/

### Arduino IDE

https://www.arduino.cc/

### Project Blinker

![Blinker.jpg](Arduino/Blinker.jpg)

```c
// put your setup code here, to run once:
void setup() 
{
  // Set Digital Pin 10 as Output Pin
  pinMode(10, OUTPUT);
}

// put your main code here, to run repeatedly:
void loop() 
{
  // Turn Pin 10 to HIGH
  digitalWrite(10, HIGH);
  
  // Wait 1000 milliseconds
  delay(1000); 

  // Turn Pin 10 to HIGH
  digitalWrite(10, LOW);

  // Wait 1000 milliseconds
  delay(1000); 
}

```

### Project Buttoner

![Buttoner.jpg](Arduino/Buttoner.jpg)

```c
// put your setup code here, to run once:
void setup()
{
  // Set Digital Pin 5 as Input Pin
  pinMode(5, INPUT);
  
  // Set Digital Pin 10 as Output Pin
  pinMode(10, OUTPUT);
}

// put your main code here, to run repeatedly:
void loop()
{
  // Read The Button State
  int buttonState = digitalRead(5);

  // Check the Button State
  if (buttonState == HIGH) 
  {
    // Turn Pin 10 to HIGH
    digitalWrite(10, HIGH);
  } 
  else 
  {
    // Turn Pin 10 to LOW
    digitalWrite(10, LOW);
  }
  
  // Delay a little bit to improve simulation performance
  delay(10); 
}
```

## Мобилен робот

Arduino мобилен робот задвижван от два правотокови двигателя и управляван през bluetooth посредством Android мобилно устройство.

### Shematics

Електрическа схема на свързване компонентите на робота: ![Shematics.png](Robot/Shematics.png)

### Arduino

Изходен програмен код в интегрираната среда за разработка Arduino IDE: ![Arduino.png](Robot/Arduino.png)

```c
// Control 2 DC motors with Smartphone via bluetooth
int state = 0;
int flag = 0;    
 
int motor1Pin1 = 4; // pin 4 on L293D IC
int motor1Pin2 = 5; // pin 5 on L293D IC
int motor2Pin1 = 6; // pin 6 on L293D IC
int motor2Pin2 = 7; // pin 7 on L293D IC

void setup() 
{
    // sets the pins as outputs:
    pinMode(motor1Pin1, OUTPUT);
    pinMode(motor1Pin2, OUTPUT);
    pinMode(motor2Pin1, OUTPUT);
    pinMode(motor2Pin2, OUTPUT);    
    // initialize serial communication at 9600 bits per second:
    Serial.begin(9600);
}

void loop() 
{
    // if some date is sent, reads it and saves in state
    if(Serial.available() > 0)
    {     
      state = Serial.read();   
      flag = 1;
      if(flag == 1) Serial.println(state);
    }       
    // Forward
    if (state == 'F') 
    {
        digitalWrite(motor1Pin1, HIGH);
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, HIGH);
        if(flag == 1) Serial.println("FORWARD");
    }
    // Backward
    else if (state == 'B') 
    {
        digitalWrite(motor1Pin1, LOW); 
        digitalWrite(motor1Pin2, HIGH);
        digitalWrite(motor2Pin1, HIGH);
        digitalWrite(motor2Pin2, LOW);
        if(flag == 1) Serial.println("BACKWARD");
    }
    // Stop
    else if (state == 'S') 
    {
        digitalWrite(motor1Pin1, LOW); 
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, LOW);
        if(flag == 1) Serial.println("STOP");
    }
    // Right
    else if (state == 'R') 
    {
        digitalWrite(motor1Pin1, LOW); 
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, HIGH);
        if(flag == 1) Serial.println("RIGHT");
        delay(1500);
    }
    // Left
    else if (state == 'L') 
    {
        digitalWrite(motor1Pin1, HIGH); 
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, LOW);
        if(flag == 1) Serial.println("LEFT");
        delay(1500);
    }
    flag = 0;
}
```

Изтегли цялата програма: [Arduino.ino](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Robot/Arduino.ino)

### Android

Android мобилното приложение е разработено с помоща на продукта [MIT App Inventor](http://ai2.appinventor.mit.edu/). Изтеглете готовият пакет на мобилното приложение [Android.apk](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Robot/Android.apk) и го качете на вашето Android устройство.

### Източник

[Arduino Control 2 DC Motors Via Bluetooth](https://randomnerdtutorials.com/arduino-control-2-dc-motors-via-bluetooth/)

## Проекти

### 2019

* [ArduinoBoy](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2019/ArduinoBoy.zip), https://github.com/cakasa/ArduinoBoy
* [KURU](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2019/KURU.zip), https://github.com/Bojidar1308/K.U.R.U
* [HandGestures](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2019/HandGestures.zip)
* [IceCreamTruck](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2019/IceCreamTruc.zip)
* [RFIDControl](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2019/RFIDControl.zip)

### 2022

* [Car Project](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/CarProject.zip), https://github.com/Konstantinn56/ArduinoCarProject
* [Fire Alarm](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/FireAlarm.zip), https://github.com/StanimirRaykov/ArduinoFireAlarm
* [Pet Feeder](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/PetFeeder.zip), https://github.com/saltyyul/PetFeeder
* [Memory Game](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/MemoryGame.zip), https://github.com/Martin-Georgiev-21/Memory\_Game\_Repo
* [Car Game](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/CarGame.zip), https://github.com/banano-man/Car-Game
* [Smart Irrigation System](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2022/SmartIrrigationSystem.zip), https://github.com/jacquelinegg/SmartIrrigationSystemSimulation

### 2023

* [Rover](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2023/Rover.zip), https://github.com/mirkataa/Rover
* [RoboHand](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2023/RoboHand.zip), https://github.com/KaterinaSlavova/RoboHand
* [IrrigationSystem](../08.%20%D0%9E%D0%BF%D0%B5%D1%80%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D0%B8%20%D0%B8%20%D0%B2%D0%B3%D1%80%D0%B0%D0%B4%D0%B5%D0%BD%D0%B8%20%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/Projects/2023/IrrigationSystem.zip), https://github.com/machev24/IrrigationSystem
