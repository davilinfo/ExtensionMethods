using System;

namespace ExtensionMethods
{
    public class UsingActivator
    {
        public string Name { get; set; }

        public UsingActivator()
        {

        }
    }

    public static class MyStringExtension
    {
        const string Added = "added";
        public static string CreateAnotherText(this string text, string url)
        {
            return $@"{url} {text} {Added}";
        }
    }

    class Program
    {        
        const string NewName = "new name";
        const string Confluence = "confluence";

        static void Main(string[] args)
        {
            var activator = Activator.CreateInstance(typeof(UsingActivator));
            (activator as UsingActivator).Name = "ok";

            string name = NewName;
            Console.WriteLine( name.CreateAnotherText($@"{Confluence} {(activator as UsingActivator).Name}"));            

            Console.ReadLine();
        }
    }
}
