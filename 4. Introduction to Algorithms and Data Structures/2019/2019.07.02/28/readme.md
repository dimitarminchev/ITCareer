# Problem 28. Свързан стек
Имплементирайте стек чрез "свързан списък". 
Използвайте следния код като за начало:
```
public class LinkedStack<T>
{
    private Node<T> firstNode;
    public int Count { get; private set; }
    public void Push(T element) { … }
    public T Pop() { … }
    public T[] ToArray() { … }
    private class Node<T>
    {
        private T value;
        public Node<T> NextNode { get; set; }
        public Node(T value, Node<T> nextNode = null) { ... }
    }
}
```
- Push(element) операцията трябва да създаде нов Node<T> и да го зададе като firstNode: this.firstNode = new Node<T>(element, this.firstNode).
- Pop() операцията трябва да върне firstNode и да го замени с firstNode.NextNode. Ако стекът е празен, то трябва да се хвърли InvalidOperationException.

