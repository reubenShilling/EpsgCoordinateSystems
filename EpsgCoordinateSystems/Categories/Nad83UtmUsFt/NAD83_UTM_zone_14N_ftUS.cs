using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83UtmUsFt
{
    public class NAD83_UTM_zone_14N_ftUS : INad83UsFtCrs
    {
        private const int _srid = -1;

        private const string _ogcWkt =
            "PROJCS[\"UTM83-14F\",GEOGCS[\"LL83\",DATUM[\"NAD83\",SPHEROID[\"GRS1980\",6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",0.000],PARAMETER[\"central_meridian\",-99.00000000000000],PARAMETER[\"scale_factor\",0.9996],PARAMETER[\"latitude_of_origin\",0.000],UNIT[\"Foot_US\",0.30480060960122]]";

        private const string _esriWkt =
            "PROJCS[\"UTM83-14F\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"False_Easting\",1640416.667],PARAMETER[\"False_Northing\",0.000],PARAMETER[\"Central_Meridian\",-99.00000000000000],PARAMETER[\"Scale_Factor\",0.9996],PARAMETER[\"Latitude_Of_Origin\",0.000],UNIT[\"Foot_US\",0.30480060960122]]";

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEsriString(_esriWkt);
        public string Name => "UTM zone 14N ft";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US foot";
        public int Srid => _srid;
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
                    new Vector(BoundingBox.South, BoundingBox.West),
                })
            }
        };

        public BoundingBox BoundingBox => new BoundingBox(84, -1, -95.5, -102.5);
    }
}