/*
 * User: ben
 * Date: 16/09/2012
 * Time: 22:54
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;

using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;

namespace Jackdaw.FileParsers
{
	/// <summary>
	/// Description of ExcelFileParser.
	/// </summary>
	public class XLSFileParser:IFileParser
	{
		private readonly string fileName;
		private readonly HSSFWorkbook workbook;
		
		private ISheet worksheet;
		
		public XLSFileParser(string fileName)
		{
			this.fileName=fileName;
			using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				this.workbook = new HSSFWorkbook(file);
			}
		}
		
		private string[] headers;
		public string[] Headers {
			get {
				initializeWorkbook();
				return headers;
			}
		}
		private bool isinitialized;
		private void initializeWorkbook()
		{
			if(isinitialized)
				return;
			this.worksheet=this.workbook.GetSheetAt(0);
			var headerRow=this.worksheet.GetRow(
				this.worksheet.FirstRowNum
			);
			List<string> headerlist=new List<string>();
			foreach (var cell in headerRow.Cells) {
				headerlist.Add(cell.ToString());
			}
			headers=headerlist.ToArray();
			isinitialized=true;
		}
	}
}
