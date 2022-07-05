namespace CommandDesignPattern;

public class TextEditor
{
    public string currentText = "";

    // To Store Undo Vars
    string _pastText;

    private List<ICommand> _usedCommands = new List<ICommand>();

    public TextEditor(string currentText)
    {
        this.currentText = currentText;
    }

    public void Undo()
    {
        if (_usedCommands.Count >= 1)
        {
            currentText = _usedCommands[_usedCommands.Count - 1].TextToUndo(currentText);
            _usedCommands.RemoveAt(_usedCommands.Count - 1);
        }
        else
        {
            Console.WriteLine("No more actions exist!! \n");
        }
    }

    public void DisplayCurrentText()
    {
        Console.WriteLine($"\nCurrent text is >> {currentText}\n");
    }

    public void ExecuteICommand(ICommand textAction)
    {
        _pastText = currentText;
        currentText = textAction.TextToExecute(currentText);
        _usedCommands.Add(textAction);
    }

    public void DisplayProcessed()
    {
        Console.WriteLine($"\nProcessed Text >>{currentText}\n");
    }
}