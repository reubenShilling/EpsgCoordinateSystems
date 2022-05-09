using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83UtmUsFt
{
    internal class NAD83_UTM_zone_8N_ftUS : INad83UsFtCrs
    {
        private const int _srid = -1;

        private const string _ogcWkt =
            "PROJCS[\"UTM83-8F\",GEOGCS[\"LL83\",DATUM[\"NAD83\",SPHEROID[\"GRS1980\",6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",0.000],PARAMETER[\"central_meridian\",-135.00000000000000],PARAMETER[\"scale_factor\",0.9996],PARAMETER[\"latitude_of_origin\",0.000],UNIT[\"Foot_US\",0.30480060960122]]";

        private const string _esriWkt =
            "PROJCS[\"UTM83-8F\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"False_Easting\",1640416.667],PARAMETER[\"False_Northing\",0.000],PARAMETER[\"Central_Meridian\",-135.00000000000000],PARAMETER[\"Scale_Factor\",0.9996],PARAMETER[\"Latitude_Of_Origin\",0.000],UNIT[\"Foot_US\",0.30480060960122]]";

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEsriString(_esriWkt);
        public string Name => "UTM zone 8N ft";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US foot";
        public int Srid => _srid;
        public Category Category => Category.UtmNad83;
        public string OgcWkt => _ogcWkt;
        public string EsriWkt => _esriWkt;

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(BoundingBox.North, BoundingBox.West),
                    new Vector(BoundingBox.North, BoundingBox.East),
                    new Vector(BoundingBox.South, BoundingBox.East),
                    new Vector(BoundingBox.South, BoundingBox.West)
                })
            }
        };

        public BoundingBox BoundingBox => new BoundingBox(84, -1, -131.5, -138.5);
    }
}