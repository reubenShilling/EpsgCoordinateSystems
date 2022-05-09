using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83UtmUsFt
{
    public class NAD83_BLM_15N_ftUS : INad83UsFtCrs
    {
        private const int _srid = 32165;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "BLM 15N";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / BLM 15N (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",-93],PARAMETER[\"scale_factor\",0.9996],PARAMETER[\"false_easting\",1640416.67],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"32165\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / BLM 15N (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",-93],PARAMETER[\"scale_factor\",0.9996],PARAMETER[\"false_easting\",1640416.67],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

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

        public BoundingBox BoundingBox => new BoundingBox(50.3834, 24.6, -89.534, -96.3167);
    }
}