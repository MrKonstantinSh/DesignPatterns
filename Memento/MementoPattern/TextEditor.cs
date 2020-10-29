namespace Memento.MementoPattern
{
    public class TextEditor
    {
        public string Content { get; set; }

        public TextEditorState CreateState()
        {
            return new TextEditorState(Content);
        }

        public void RestoreState(TextEditorState textEditorState)
        {
            Content = textEditorState.Content;
        }
    }
}