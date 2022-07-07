using Builder.FacededBuilder;
using Builder.FluentBuilder;
using Builder.FluentBuilderInheritanceWithRecursiveGenerics;
using Builder.FunctionalBuilder;
using Builder.StepwiseBuilder;

// Fluent Builder
var htmlBuilder = new HtmlBuilder("ul");
htmlBuilder.AddChild("li", "Option 1")
    .AddChild("li", "Option 2")
    .AddChild("li", "Option 3");

Console.WriteLine(htmlBuilder.ToString());

// Fluent Builder Inheritance With Recursive Generics
var person = Person.Builder.AddName("Bob")
    .AddPosition(".NET developer")
    .Build();

Console.WriteLine(person);

// Stepwise Builder
var car = CarBuilder.Create()
    .OfType(CarType.Coupe)
    .WithWheelSize(17)
    .Build();

Console.WriteLine(car);

// Functional Builder
var anotherPerson = new FunctionalPersonBuilder()
    .AddName("Rob")
    .AddPosition("C++ developer")
    .Build();

Console.WriteLine(anotherPerson);

// Faceded Builder
var finalPersonBuilder = new FinalPersonBuilder();
FinalPerson finalPerson = finalPersonBuilder
    .AddressBuilder
        .In("UK")
        .At("Street address")
        .WithPostcode("123456")
    .WorkBuilder
        .At("Company name")
        .AsA(".NET developer");

Console.WriteLine(finalPerson);
