namespace CommandDesignPattern;

public class Append : ICommand
{
    private string _toAppend;

    private int tempVar;

    public Append(string toStore)
    {
        this._toAppend = toStore;
        this.tempVar = _toAppend.Length;
    }

    public string TextToExecute(string textToExecute)
    {
        return (textToExecute += _toAppend);
    }

    public string TextToUndo(string textToUndo)
    {
        return textToUndo.Remove(textToUndo.Length - tempVar, tempVar);
    }
}