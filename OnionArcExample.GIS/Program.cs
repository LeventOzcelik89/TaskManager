// See https://aka.ms/new-console-template for more information

using NetTopologySuite.IO;
using NetTopologySuite.Geometries;
//using NetTopologySuite.Features;
using GeoAPI.Geometries;
using OSGeo.OGR;
using System.Runtime.CompilerServices;
using OnionArcExample.GIS;
//using NetTopologySuite.IO.ShapeFile;

var dir = AppDomain.CurrentDomain.BaseDirectory.Split("\\bin")[0];
var townDir = dir + "\\Shape\\İl_Sınırı.prj";
var cityDir = dir + "\\Shape\\İlçe_Sınırı.prj";
var cityDbf = dir + "\\Shape\\İlçe_Sınırı.dbf";



var p1 = new GeoJsonParser().ReadShapeFile(townDir);
var p2 = new GeoJsonParser().ReadShapeFile(cityDir);
var p3 = new GeoJsonParser().ReadShapeFile(cityDbf);


var t1 = new GeoJsonParser().Parse(townDir);
var t2 = new GeoJsonParser().Parse(cityDir);



//var serializer = GeoJsonSerializer.Create();
//using (var stringReader = new StringReader(geoJson))
//{
//    using (var jsonReader = new Newtonsoft.Json.JsonTextReader(stringReader))
//    {

//    }
//}






//var read = new WKTReader();
//var rd = new WKTFileReader(dir, read);
//var rr = rd.Read();

//var cmk = "";


////var ff = c.Read(dir);




//var readerr = new NetTopologySuite.IO.WKTFileReader();
//readerr.Read();




//ShapefileDataReader shapeFileDataReader = new ShapefileDataReader


//var c = new WKTReader();
//var ff = c.Read(dir);




//GdalBase.ConfigureAll();


//var dir = AppDomain.CurrentDomain.BaseDirectory.Split("\\bin")[0] + "\\Shape\\İl_Sınırı.shp";

//using (var ds = Ogr.Open(dir, 0))
//{
//    var lc = ds.GetLayerCount();
//    var ly = ds.GetLayerByIndex(0);
//    var fc = ly.GetFeatureCount(1);

//    var f0 = ly.GetFeature(0);



//}









//var fileGdbDriver = Ogr.GetDriverByName("ESRI Shapefile");
//var dataSource = fileGdbDriver.Open(dir, 0);

//var layerCount = dataSource.GetLayerCount();
//for (var i = 0; i < layerCount; i++)
//{
//    var layer = dataSource.GetLayerByIndex(i);

//    Console.WriteLine($"Layer: {layer.GetName()}");
//}

//Console.WriteLine("asd");

