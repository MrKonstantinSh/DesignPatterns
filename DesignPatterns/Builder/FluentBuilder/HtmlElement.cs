using System.Text;

namespace Builder.FluentBuilder
{
    public class HtmlElement
    {
        public const int IndentSize = 2;

        public string Name { get; set; }
        public string Content { get; set; }

        public IList<HtmlElement> HtmlElements { get; set; }

        public HtmlElement()
        {
            HtmlElements = new List<HtmlElement>();
        }

        public HtmlElement(string name, string content)
        {
            Name = name;
            Content = content;

            HtmlElements = new List<HtmlElement>();
        }

        public override string ToString()
        {
            return ToStringWithIndents(0);
        }

        private string ToStringWithIndents(int numberOfIndents)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{new string(' ', IndentSize * numberOfIndents)}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Content))
            {
                stringBuilder.Append(new string(' ', IndentSize * (numberOfIndents + 1)));
                stringBuilder.AppendLine(Content);
            }

            foreach (var element in HtmlElements)
            {
                stringBuilder.Append(element.ToStringWithIndents(numberOfIndents + 1));
            }

            stringBuilder.AppendLine($"{new string(' ', IndentSize * numberOfIndents)}</{Name}>");

            return stringBuilder.ToString();
        }
    }
}
