// See https://aka.ms/new-console-template for more information
using IOC_Container.Container;
using IOC_Container.Types.Implementations;
using IOC_Container.Types.Interfaces;

Console.WriteLine("\n\nDependency Injection, Building DI Container ...\n\n");

var services = new DiServiceCollecion();


//services.RegisterSingleton(new RandomGuiGenerator());
//services.RegisterSingleton<RandomGuiGenerator>();

//services.RegisterTransient<RandomGuiGenerator>();
//services.RegisterTransient(new RandomGuiGenerator());

//services.RegisterTransient<IMyService, MyService>();

services.RegisterTransient<IMyService, MyService>();
services.RegisterTransient<IRandomGuidProvider, RandomGuidProvider>();



var container = services.GenerateContainer();

var serviceFirst = container.GetService<IMyService>();

var serviceSecond = container.GetService<IMyService>();

serviceFirst.DoSomeThing();
serviceSecond.DoSomeThing();



