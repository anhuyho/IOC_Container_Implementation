// See https://aka.ms/new-console-template for more information
using IOC_Container.Container;
using IOC_Container.Types;

Console.WriteLine("Hello, World!");

var services = new DiServiceCollecion();

//services.RegisterSingleton<RandomGuiGenerator>();
services.RegisterSingleton(new RandomGuiGenerator());

var container = services.GenerateContainer();

var serviceFirst = container.GetService<RandomGuiGenerator>();

var serviceSecond = container.GetService<RandomGuiGenerator>();

Console.WriteLine(serviceFirst.RandomGuid);
Console.WriteLine(serviceSecond.RandomGuid);



