using System.Collections.Generic;

namespace Memento.MementoPattern
{
    public class TextEditorHistory
    {
        private readonly Stack<TextEditorState> _states = new Stack<TextEditorState>();

        public void Push(TextEditorState textEditorState)
        {
            _states.Push(textEditorState);
        }

        public TextEditorState Pop()
        {
            return _states.Pop();
        }
    }
}