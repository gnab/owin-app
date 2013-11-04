using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinApp.Middleware
{
    public class Logger : OwinMiddleware
    {
        public Logger(OwinMiddleware next) : base(next) {}

        public override Task Invoke(OwinRequest request, OwinResponse response)
        {
            Console.WriteLine(request.Method + " " + request.Uri.ToString());

            return Next.Invoke(request, response);
        }
    }
}
