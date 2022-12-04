namespace BehavioralDesignPatterns.State;

public class Notepad
{
    protected IWritingStyleState WritingStyle;
    public string Text { get; private set; } = string.Empty;

    public Notepad()
    {
        WritingStyle = new DefaultState();
    }

    public void ChangeState(IWritingStyleState state)
    {
        WritingStyle = state;
    }

    public void AddTextWithStyle(string message)
    {
        Text += WritingStyle.Write(message);
    }

    public void ResetText()
    {
        Text = string.Empty;
    }
}