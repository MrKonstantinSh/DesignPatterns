namespace Memento.MementoPattern
{
    public class TextEditorState
    {
        public TextEditorState(string content)
        {
            Content = content;
        }

        public string Content { get; }
    }
}