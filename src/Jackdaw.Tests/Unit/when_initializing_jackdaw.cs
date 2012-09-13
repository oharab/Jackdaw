/*
 * User: ben
 * Date: 13/09/2012
 * Time: 23:06
 * 
 */
using System;
using System.IO;
using NUnit.Framework;

namespace Jackdaw.Tests.Unit
{

	[TestFixture]
	public class when_initializing_jackdaw
	{
		[Test]
		public void can_read_a_valid_shp_file_from_path()
		{
			var j=new Jackdaw();
			j.ShapeFile="../Data/Boundaries/county_region.shp";
			Assert.AreEqual(43,j.Boundaries,"Boundaries were not read from shp file.");
		}
	}
}
