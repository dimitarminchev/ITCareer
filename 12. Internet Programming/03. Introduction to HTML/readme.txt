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
