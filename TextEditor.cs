namespace CommandDesignPattern;

public class TextEditor
{
    string _currentText;
    string _pastText;

    public void DisplayCurrentText()
    {
        Console.WriteLine($"\nCurrent text is >> {_currentText}\n");
    }

    public void SaveText()
    {
        _pastText = _currentText;
    }

    public void UndoText()
    {
        _currentText = _pastText;
        Console.WriteLine("Undo Done! \nCurrent Text >>");
        Console.Write($">>:{_currentText}\n");
    }

    public TextEditor(string currentText)
    {
        _currentText = currentText;
    }

    public void ExecuteICommand(ICommand textAction)
    {
        _currentText = textAction.TextToExecute(_currentText);
    }

    public void DisplayProcessed()
    {
        Console.WriteLine($"\nProcessed Text >>{_currentText}\n");
    }
}