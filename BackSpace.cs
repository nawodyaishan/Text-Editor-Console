namespace CommandDesignPattern;

public class BackSpace : ICommand
{
    private int toBeRemovedChars;

    private string OriginalString;

    public BackSpace(int toBeRemovedChars, string originalString)
    {
        this.toBeRemovedChars = toBeRemovedChars;
        this.OriginalString = originalString;
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

    public string TextToUndo(string textToUndo)
    {
        return OriginalString.Substring(0, textToUndo.Length + toBeRemovedChars);
    }
}