# Комуникация между обекти

## Делегати
Делегатът е специализиран клас, често наричан **указател към функция**.
```
// Делегат
public delegate void WorkPerformedHandler(int hours, WorkType workType);
// Инстанция
WorkPerformedHandler dele = new WorkPerformedHandler(WorkPerformed);
// Обработчик
static void WorkPerformed(int hours, WorkType workType)
{ Console.WriteLine("WorkPerformed called " + hours.ToString()); }
```
Присвяване на ламбда към делегат:
```
delegate int AddDelegate(int a, int b);
static void Main(string[] args)
{         
  AddDelegate ab = ( a, b ) => a + b;
  int result = ab(1, 1); // 1 + 1 = 2
} 
```

## Събития
Събитията  са специални инстанции на делегати, декларирани с ключовата дума event.
```
public event EventHandler WorkCompleted;
```
Известяване и отговор на събития
```
public delegate void WorkPerfHandler(int hours, WorkType workType); 
public class Worker 
{     
  public event WorkPerfHandler WorkPerformed;     
  public virtual void DoWork(int hours, WorkType workType)     
  {          
    OnWorkPerformed(hours, workType);     
  } 
  protected virtual void OnWorkPerformed (int hours, WorkType workType)
  {          
    WorkPerfHandler del = WorkPerformed as WorkPerfHandler; 
    if (del != null)  del(hours, workType);                 
  }
} 
```

## Аргументи на събития
```
public delegate void EventHandler(object sender, EventArgs e);
public event EventHandler<EventArgs> WorkPerformed
```
Закачване на обработчици на събития 
```
var worker = new Worker();
worker.WorkPerformed += new EventHandler<WorkPerfEventArgs>(worker_WorkPerformed);

var worker = new Worker();
worker.WorkPerformed += worker_WorkPerformed;
void worker_WorkPerformed(object sender, WorkPerfHandler e) { ... }  
```
Анонимни методи
```
var worker = new Worker();
worker.WorkPerformed += delegate(object sender, WorkPerfEventArgs e)     
{         
  Console.WriteLine(e.Hours.ToString());     
}; 
```

## Слушатели на събития
```
public interface ISubject
{
   void Attach(IObserver observer);
   void Detach(IObserver observer);
   void Notify();
}
class Lecture : ISubject
{
  private List<IObserver> observers;
  
  public void Attach(IObserver observer) 
  {
    this.observers.add(observer);
  }
  public void Detach(IObserver observer)
  {
	this.observers.remove(observer);
  }
  public void Notify()
  {
    foreach (IObserver observer in observers)
    observer.Update(this);
  }
}
public interface IObserver : ISubject
{
    void Update(ISubject sender);
}
public class Student : IObserver
{
    public string Name { get; set; }

    public void Update(ISubject sender)
    {
        var trainer = (sender as Lecture).Trainer;
        Console.WriteLine($"{this.Name} does not like the new trainer {trainer}!"); 
    }
}
```

## Упражнение
- [81](81). Реализация на Събитие 
- [82](82). Царски гамбит
- [83](83). Избягване на зависимостите
- [84](84). *Работна сила
- [85](85). *Царски гамбит (разширен)