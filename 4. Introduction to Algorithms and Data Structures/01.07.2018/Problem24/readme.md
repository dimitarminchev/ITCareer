# Статична имплементация на стек
Имплементирайте статично стек Stack<T>, който пази елементите  си в масив:
```
public class ArrayStack<T>
{
    private T[] elements;
    public int Count { get; private set; }
    private const int InitialCapacity = 16;
    public ArrayStack(int capacity = InitialCapacity) { … }
    public void Push(T element) { … }
    public T Pop() { … }
    public T[] ToArray() { … }
    private void Grow() { … }
}
```
Подсказки:
- Капацитета на стека е this.elements.Length
- Пазете размера на стека (брой елементи) в this.Count
- Push(element) запазва елемента в elements[this.Count] и увеличава this.Count
- Push(element) трябва да извика Grow(), в случай че this.Count == this.elements.Length
- Pop() намаля this.Count и връща this.elements[this.Count]
- Grow() заделя нов масив newElements с размер 2 * this.elements.Length и копира първите this.Count елемента от this.elements до newElements. Накрая, присвоете this.elements = newElements
- ToArray() създава и връща масив от this.elements[0…this.Count-1]
- Pop() трябва да хвърля InvalidOperationException (или IllegalArgumentException) при празен стек
