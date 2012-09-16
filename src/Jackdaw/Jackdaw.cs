/*
 * User: ben
 * Date: 13/09/2012
 * Time: 23:22
 * 
 */
using System;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;

namespace Jackdaw
{
	/// <summary>
	/// Description of Jackdaw.
	/// </summary>
	public class Jackdaw
	{
		private string shapeFile;
		private IGeometryCollection boundaries;
		
		public string ShapeFile {
			get{ return shapeFile;}
			set{
				shapeFile=value;
				var shp= new ShapefileReader(this.ShapeFile);
				boundaries=shp.ReadAll();
				
			}
		}
		public double Boundaries { 
			get { return boundaries.Count; }
		}
		
		public string InputFile { get; set; }
	}
}
