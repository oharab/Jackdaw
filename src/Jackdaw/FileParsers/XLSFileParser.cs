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
	public class XLSFileParser:IFileParser
	{
		
		public XLSFileParser(string fileName)
		{
		}
		
		public string[] Headers {
			get {
				throw new NotImplementedException();
			}
		}
	}
}
