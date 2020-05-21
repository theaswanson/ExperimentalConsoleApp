using System;
using McMaster.Extensions.CommandLineUtils;

//https://github.com/natemcmaster/CommandLineUtils

namespace ConsoleApp
{
    public class ProgramMcMaster
    {
        //private static int Main(string[] args)
        //    => CommandLineApplication.Execute<Program>(args);

        //[Option(Description = "The subject")]
        //public string Subject { get; }

        //[Option(ShortName = "n")]
        //public int Count { get; }

        //private void OnExecute()
        //{
        //    var subject = Subject ?? "world";
        //    for (var i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine($"Hello {subject}!");
        //    }
        //}

        //public static int Main(string[] args)
        //{
        //    var app = new CommandLineApplication();

        //    app.HelpOption();
        //    var optionSubject = app.Option("-s|--subject <SUBJECT>", "The subject", CommandOptionType.SingleValue);
        //    var optionRepeat = app.Option<int>("-n|--count <N>", "Repeat", CommandOptionType.SingleValue);

        //    app.OnExecute(() =>
        //    {
        //        var subject = optionSubject.HasValue()
        //            ? optionSubject.Value()
        //            : "world";

        //        var count = optionRepeat.HasValue() ? optionRepeat.ParsedValue : 1;
        //        for (var i = 0; i < count; i++)
        //        {
        //            Console.WriteLine($"Hello {subject}!");
        //        }
        //        return 0;
        //    });

        //    return app.Execute(args);
        //}
    }
}
