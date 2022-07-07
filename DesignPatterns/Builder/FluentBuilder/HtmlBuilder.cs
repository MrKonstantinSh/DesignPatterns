namespace Builder.FluentBuilder
{
    public class HtmlBuilder
    {
        private HtmlElement _rootElement;

        public HtmlBuilder(string rootName)
        {
            _rootElement = new HtmlElement
            {
                Name = rootName
            };
        }

        public HtmlBuilder AddChild(string childName, string childContent)
        {
            var htmlElement = new HtmlElement(childName, childContent);
            _rootElement.HtmlElements.Add(htmlElement);

            return this;
        }

        public void Clear()
        {
            _rootElement = new HtmlElement();
        }

        public override string ToString()
        {
            return _rootElement.ToString();
        }
    }
}
