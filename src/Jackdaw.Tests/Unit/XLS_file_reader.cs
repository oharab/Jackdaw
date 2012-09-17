/*
 * User: ben
 * Date: 16/09/2012
 * Time: 21:36
 * 
 */
using System;
using System.Collections.Generic;
using Jackdaw.FileParsers;
using NUnit.Framework;

namespace Jackdaw.Tests.Unit
{
	[TestFixture]
	public class XLS_file_parser
	{
		
		[Test]
		public void can_read_file_headers()
		{
			IFileParser p=new XLSFileParser("../../Data/Input/ValidExcelFile.xlsx");
			var testHeaders=new[]{"id","street","postcode","X","Y"};
			
			CollectionAssert.AreEqual(testHeaders,p.Headers,"Excel parser cannot read expected headers.");
		}
	}
}
