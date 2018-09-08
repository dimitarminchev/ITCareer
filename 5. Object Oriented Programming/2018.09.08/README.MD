# Отражение на типове (Reflection)

Техника на програмиране, при която компютърни програми мога да третират други програми като свои данни.

## Type
Основен начин за достъп до метаданните.
```
Type myType = typeof(ClassName);
```
## Name
Предоставя  името на класа.
```
string fullName = typeOf(SomeClass).FullName;
string simpleName = typeOf(SomeClass).Name;
```
## Class and Interface
```
Type baseClassType = testClass.BaseType;
Type[] classInterfaces = testClass.GetInterfaces();
```
## CreateInstance 
Създава екземпляр от класа чрез извикване на конструктора, който най-добре пасва на указаните параметри.
```
Type sbType = Type.GetType("System.Text.StringBuilder");
StringBuilder sbInstance = (StringBuilder) Activator.CreateInstance(sbType);
StringBuilder sbInstCapacity = (StringBuilder)Activator.CreateInstance(sbType, new object[] {10});
```
## Fields
Предоставя публичните полета
```
FieldInfo field = type.GetField("name"); FieldInfo[] publicFields = type.GetFields();
```
Предоставя всички полета
```
FieldInfo[] allFields = type.GetFields(
BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); 
```
## Field Type
Получаване на името и типа на полето
```
FieldInfo field = type.GetField("fieldName");
string fieldName = field.Name;
Type fieldType = field.FieldType;
```
## Access Modifiers
```
field.IsPrivate     // частен
field.IsPublic      // публичен
field.IsNonPublic   // не е публичен
field.IsFamily      // защитен (protected)
field.IsAssembly    // вътрешен (internal)
```
## Constructors
```
ConstructorInfo[] publicCtors = type.GetConstructors();
```
## Create New Object Instances
```
StringBuilder builder = (StringBuilder)constructor.Invoke(new object[] params);
```
## Methods
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

# Упражнение
- [631](631) = Крадец 
- [632](632) = Висококачествени грешки
- [633](633) = Мисия "Частно" невъзможна
- [634](634) = Колектор
- [635](635) = Поля за жътва
- [636](636) = Black Box Integer
- [637](637) = BarracksWars – Нова фабрика
- [638](638) = BarracksWars – Командите отвръщат на удара
- [639](639) = BarracksWars - Завръщане на Зависимостите