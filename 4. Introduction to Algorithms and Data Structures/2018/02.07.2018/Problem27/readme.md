# Problem 27. Свързана опашка
Имплементирайте опашката използвайки "двусвързан списък".
Използвайте този код като скелет:
```
public class LinkedQueue<T>
{
    public int Count { get; private set; }
    public void Enqueue(T element) { … }
    public T Dequeue() { … }
    public T[] ToArray() { … }

    private class QueueNode<T>
    {
        public T Value { get; private set; }
        public QueueNode<T> NextNode { get; set; }
        public QueueNode<T> PrevNode { get; set; }
    }
}
```
Разгледайте и модифицирайте кода за DoublyLinkedList<T> класа. 
Ако опашката е празна, Dequeue() трябва да хвърля InvalidOperationException.

