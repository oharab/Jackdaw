/*
 * User: 721116
 * Date: 18/09/2012
 * Time: 16:47
 * 
 *  */
using System;
using NMaier.GetOptNet;
namespace Jackdaw.Shell
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	[GetOptOptions(OnUnknownArgument = UnknownArgumentsAction.Ignore, UsageEpilog = "That's all, folks")]
	internal class Options:GetOpt
	{
		[Argument]
		[ShortArgument('h')]
		[FlagArgument(true)]
		public bool Help;
		
		[Argument]
		[ShortArgument('v')]
		[FlagArgument(true)]
		public bool Version;
	}
}
