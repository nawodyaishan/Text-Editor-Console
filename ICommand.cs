namespace CommandDesignPattern;

public interface ICommand
{
    public string TextToExecute(string textToExecute);

    public string TextToUndo(string textToUndo);
}