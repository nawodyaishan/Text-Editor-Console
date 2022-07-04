namespace CommandDesignPattern;

public class BackSpace : ICommand
{
    private int toBeRemovedChars;

    public BackSpace(int toBeRemovedChars)
    {
        this.toBeRemovedChars = toBeRemovedChars;
    }

    public string TextToExecute(string textToExecute)
    {
        if (textToExecute.Length >= toBeRemovedChars || toBeRemovedChars != 0)
        {
            return (textToExecute.Remove((textToExecute.Length) - (toBeRemovedChars), toBeRemovedChars));
        }
        else
        {
            return ($"Please enter a number below \n>>:{textToExecute.Length}");
            
        }
    }
}