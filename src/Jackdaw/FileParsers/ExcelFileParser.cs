/*
 * User: ben
 * Date: 16/09/2012
 * Time: 22:54
 * 
 */
using System;

namespace Jackdaw.FileParsers
{
	/// <summary>
	/// Description of ExcelFileParser.
	/// </summary>
	public class ExcelFileParser:IFileParser
	{
		
		public ExcelFileParser(string fileName)
		{
		}
		
		public string[] Headers {
			get {
				throw new NotImplementedException();
			}
		}
	}
}
