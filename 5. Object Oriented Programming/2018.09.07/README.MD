# Работа с обекти
## Итератори
### IEnumerable<T>
Интерфейс за обхождане на колекция
```
public interface IEnumerable<T> : IEnumerable
{
    IEnumerator<T> GetEnumerator();
}
```
### IEnumerator<T>
Предоставя последователно, еднопосочно обхождане на колекция от произволен тип
```
public interface IEnumerator<T> : IEnumerator
{
    bool MoveNext();
    void Reset();
    T Current { get; }
}

public interface IEnumerator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}
```
- **MoveNext()** = премества итератора към следваща позиция 
- **Reset()** = връща итератора на начална позиция 
- **Current** = връща елемента от колекцията на текущата позиция на итератора

### Упражнения
- [611](611) = Библиотека
- [612](612) = Итератор за библиотека
- [613](613) = ListyIterator
- [614](614) = Колекция
- [615](615) = Стек
- [616](616) = Жабче
- [617](617) = Клиника за домашни любимци
- [618](618) = Обхождане на свързан списък

## Компаратори
### IComparable<T>
```
class Point : IComparable<Point>
{
    public int CompareTo(Point otherPoint)
    {
        ...
    }
}
```
### IComparer<T>
```
class CatComparer : IComparer<Cat>
{
    public int Compare(Cat x, Cat y)
    {
        ...
    }
}
```
### Упражнения
- [621](621) = Сравнима книга
- [622](622) = Сравняващият книги
- [623](623) = Сравняване на обекти
- [624](624) = Шаблон Strategy 
- [625](625) = *Логика за еднаквост
