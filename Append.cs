namespace CommandDesignPattern;

public class Append : ICommand
{
    private string toAppend;

    public Append(string toStore)
    {
        this.toAppend = toStore;
    }

    public string TextToExecute(string textToExecute)
    {
        return (textToExecute += toAppend);
    }
}