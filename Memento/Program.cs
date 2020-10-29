using System;
using Memento.MementoPattern;

namespace Memento
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var textEditor = new TextEditor();
            var textEditorHistory = new TextEditorHistory();

            textEditor.Content = "Hello";
            textEditorHistory.Push(textEditor.CreateState());
            Console.WriteLine(textEditor.Content);

            textEditor.Content = "world";
            textEditorHistory.Push(textEditor.CreateState());
            Console.WriteLine(textEditor.Content);

            textEditor.Content = "restore";
            Console.WriteLine(textEditor.Content);
            
            textEditor.RestoreState(textEditorHistory.Pop());
            Console.WriteLine(textEditor.Content);
            
            textEditor.RestoreState(textEditorHistory.Pop());
            Console.WriteLine(textEditor.Content);
        }
    }
}