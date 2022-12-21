// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ResourceDemo.Resources;

var cultures = new[]
{
    CultureInfo.DefaultThreadCurrentCulture, 
    new("ja-jp"),
    new("zh-hans-cn"),
};
foreach (var culture in cultures)
{
    ExampleText.Culture = culture;
    Console.WriteLine(ExampleText.Message_Hello);
    Console.WriteLine(ExampleText.Message_About_Demo);
    Console.Write(ExampleText.Mutual_IntoNextMessage);
    Console.ReadLine();
    Console.Write(ExampleText.Mutual_TellMeYourName);
    var name = Console.ReadLine()!.Trim();
    Console.WriteLine(ExampleText.Message_HelloWithName, name);

    Console.WriteLine(ExampleText.Message_RepeatWithNextLanguage);
    Console.Write(ExampleText.Mutual_IntoNextMessage);
    Console.ReadLine();
    Console.WriteLine(new string('-', 50));
}