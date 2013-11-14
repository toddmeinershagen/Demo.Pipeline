using System;
using Newtonsoft.Json;
using Tamarack.Pipeline;

namespace Demo.Pipeline.CommandUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var pipeline = new Pipeline<Context, Context>()
                .Add<VisitHandler>()
                .Add<PatientHandler>()
                .Finally<Context, Context>(c =>
                    {
                        Console.WriteLine(JsonConvert.SerializeObject(c));
                        return c;
                    });

            pipeline.Execute(context);
            Console.ReadLine();
        }
    }
}
