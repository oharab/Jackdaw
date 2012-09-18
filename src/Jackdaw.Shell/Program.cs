/*
 * User: 721116
 * Date: 18/09/2012
 * Time: 16:42
 * 
 *  */
using System;
using System.Reflection;

namespace Jackdaw.Shell
{
	class Program
	{
		public static void Main(string[] args)
		{
			var opts=new Options();
			opts.Parse(args);
			
			if(opts.Version)
			{
				var ass=Assembly.GetExecutingAssembly().GetName().Version;
				Console.WriteLine(
					string.Format("Jackdaw version {0}.{1}.{2}.{3}",
					              ass.Major,ass.Minor,ass.Build,ass.Revision
					             )
				);
			}
			
			if(opts.Help)
			{
				opts.PrintUsage();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}