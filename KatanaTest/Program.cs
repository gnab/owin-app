using Microsoft.Owin.Hosting;
using System;

namespace KatanaTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var port = 8080;
			if (args.Length > 0)
			{
				int.TryParse(args[0], out port);
			}

			using (WebApp.Start<Startup>(port))
			{
				Console.WriteLine("Started");
				Console.ReadKey();
				Console.WriteLine("Stopping");
			}
		}
	}
}
