using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.IO.ShapeFile.Extended;
using NetTopologySuite.IO.ShapeFile.Extended.Entities;

namespace OnionArcExample.GIS
{




    


    public class GeoJsonParser
    {

        public List<IShapefileFeature> ReadShapeFile(string path)
        {
            ShapeDataReader reader = new ShapeDataReader(path);
            var mbr = reader.ShapefileBounds;
            var result = reader.ReadByMBRFilter(mbr);
            var coll = result.GetEnumerator();
            var res = new List<IShapefileFeature>();
            while (coll.MoveNext())
            {
                var item = coll.Current;
                res.Add(item);
            }

            return res;
        }


        public FeatureCollection Parse(string dir)
        {

            var geoJson = File.ReadAllText(dir);
            var reader = new NetTopologySuite.IO.GeoJsonReader();
            return reader.Read<NetTopologySuite.Features.FeatureCollection>(geoJson);

        }


    }
}
