# Отражение на типове (Reflection)

Техника на програмиране, при която компютърни програми мога да третират други програми като свои данни.

### Type
Основен начин за достъп до метаданните.
```
Type myType = typeof(ClassName);
```
### Name
Предоставя  името на класа.
```
string fullName = typeOf(SomeClass).FullName;
string simpleName = typeOf(SomeClass).Name;
```
### Class and Interface
```
Type baseClassType = testClass.BaseType;
Type[] classInterfaces = testClass.GetInterfaces();
```
### CreateInstance 
Създава екземпляр от класа чрез извикване на конструктора, който най-добре пасва на указаните параметри.
```
Type sbType = Type.GetType("System.Text.StringBuilder");
StringBuilder sbInstance = (StringBuilder) Activator.CreateInstance(sbType);
StringBuilder sbInstCapacity = (StringBuilder)Activator.CreateInstance(sbType, new object[] {10});
```
### Fields
Предоставя публичните полета
```
FieldInfo field = type.GetField("name"); FieldInfo[] publicFields = type.GetFields();
```
Предоставя всички полета
```
FieldInfo[] allFields = type.GetFields(
BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); 
```
### Field Type
Получаване на името и типа на полето
```
FieldInfo field = type.GetField("fieldName");
string fieldName = field.Name;
Type fieldType = field.FieldType;
```
### Access Modifiers
```
field.IsPrivate     // частен
field.IsPublic      // публичен
field.IsNonPublic   // не е публичен
field.IsFamily      // защитен (protected)
field.IsAssembly    // вътрешен (internal)
```
### Constructors
```
ConstructorInfo[] publicCtors = type.GetConstructors();
```
### Create New Object Instances
```
StringBuilder builder = (StringBuilder)constructor.Invoke(new object[] params);
```
### Methods
```
MethodInfo[] publicMethods = sbType.GetMethods();
```
Достъп до параметрите на метод и връщания тип данни
```
ParameterInfo[] appendParameters = appendMethod.GetParameters();
Type returnType = appendMethod.ReturnType;
```
Извиква методи
```
appendMethod.Invoke( builder, new object[] { "hi!" });
```

### Упражнение
- [631](631) = Крадец 
- [632](632) = Висококачествени грешки
- [633](633) = Мисия "Частно" невъзможна
- [634](634) = Колектор
- [635](635) = Поля за жътва
- [636](636) = Black Box Integer
- [637](637) = BarracksWars – Нова фабрика
- [638](638) = BarracksWars – Командите отвръщат на удара
- [639](639) = BarracksWars - Завръщане на Зависимостите

# Функционално програмиране
### Lambda Expressions
```
msg => Console.WriteLine(msg);
(String msg) => { Console.WriteLine(msg); }
() => { Console.WriteLine("hi"); }
(int x, int y) => { return x + y; }
```
### Lambda Functions
| израз         | еквивален                                     |
|---------------|-----------------------------------------------|
| x => x / 2    | static int Func(int x) { return x / 2; }      |
| x => x != 0   | static bool Func(int x) { return x != 0; }    |
| () => 42      | static int Func() { return 42; }              |
| (x, y) => x+y | static int Func(int x, int y) { return x+y; } |

### LINQ & Collcetions
```
ToArray(), ToList()
Select(), Where(), OrderBy()
Min(), Max(), Sum(), Average(), Count()
First(), Last() , Single()
Skip(), Take()
Distinct() 
Reverse()
Concat()
```

### Lab
- [721](721) = Сортиране на нечетни числа
- [722](722) = Сбор на числа
- [723](723) = Брой думи  главна буква
- [724](724) = Начисляване не  ДДС(VAT)
- [725](725) = Филтриране по възраст

### Упражнение
- [711](711) = Action 
- [712](712) = Рицари на честта
- [713](713) = Собствена Min функция 
- [714](714) = Намерете четно или нечетно
- [715](715) = Приложна аритметика
- [716](716) = Обърни и изпълни
- [717](717) = Предикати за имена
- [718](718) = Потребителски сравнител
- [719](719) = Списък от предикати
- [7110](7110) = Предикатно парти!
- [7111](7111) = Модул Филтър за резервация на парти 
- [7112](7112) = Inferno III
- [7113](7113) = TriFunction