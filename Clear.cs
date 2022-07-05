namespace CommandDesignPattern;

public class Clear : ICommand
{
    private string previousText;

    public Clear(string value)
    {
        this.previousText = value;
    }

    public string TextToExecute(string textToExecute)
    {
        previousText = textToExecute;
        return ("");
    }

    public string TextToUndo(string textToUndo)
    {
        return previousText;
    }
}