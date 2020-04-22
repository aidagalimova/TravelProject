using System;
using AspectInjector.Broker;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.AOP
{
    [Aspect(Scope.Global)]
    [Injection(typeof(TraceAspectAttribute))]
    public sealed class TraceAspectAttribute : Attribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public void TraceStart(
            [Argument(Source.Type)] Type type,
            [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] Method {type.Name}.{name} started");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void TraceFinish(
            [Argument(Source.Type)] Type type,
            [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] Method {type.Name}.{name} finished");
        }
    }
}
