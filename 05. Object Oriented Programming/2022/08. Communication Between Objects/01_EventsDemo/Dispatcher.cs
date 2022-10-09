/// <summary>
/// Делегат
/// </summary>
public delegate void NameChangeEventHandler();

/// <summary>
/// Диспечер
/// </summary>
public class Dispatcher
{
    private string name { get; set; }

    private event NameChangeEventHandler nameChangeEventHandler;

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            OnNameChange(new NameChangeEventArgs(name));
        }
    }

    public void OnNameChange(NameChangeEventArgs args)
    {
        Handler handler = new Handler();
        handler?.OnDispatcherNameChange(this, args);
    }
}