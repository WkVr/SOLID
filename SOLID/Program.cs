// See https://aka.ms/new-console-template for more information
using SOLID;

var bar = new Bar("Foo", "Bar");
var foo = new Foo("Foo", "Bar");

Console.WriteLine("Bar");
Console.WriteLine(bar.generateFinal());

Console.WriteLine("Foo");
Console.WriteLine(foo.generateFinal());

//This list is using the Liskov Substitution Principle by accesing the FooBar class with the ICount interface.
var barList = new List<ICount>() {
new Bar("Foo", "Bar1"),
new Bar("Foo", "Ba"),
new Bar("Foo", "B"),
new Bar("Fo", "B"),
new Bar("F", "B"),
new Bar("F", "Ba"),
new Bar("Foo", "Bar")};

var dependency = new Dependency(bar);

//Because the Dependecy class is badly written due to not following the Single Prpose Principal the following line is used.
var list = dependency.generateFooBarCountList(barList);

foreach(var item in list)
    Console.WriteLine(item);