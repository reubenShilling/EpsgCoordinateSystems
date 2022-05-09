using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Hawaii_zone_3_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3759;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hawaii zone 3";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Hawaii zone 3 (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",21.16666666666667],PARAMETER[\"central_meridian\",-158],PARAMETER[\"scale_factor\",0.99999],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3759\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Hawaii zone 3 (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",21.16666666666667],PARAMETER[\"central_meridian\",-158],PARAMETER[\"scale_factor\",0.99999],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(21.2980248181819, -157.673327),
                    new Vector(21.3863328181818, -157.713476),
                    new Vector(21.4585938181819, -157.761644),
                    new Vector(21.4345098181819, -157.809821),
                    new Vector(21.5067528181818, -157.849961),
                    new Vector(21.6352098181818, -157.914185),
                    new Vector(21.6994338181819, -157.986428),
                    new Vector(21.6753588181819, -158.042624),
                    new Vector(21.5790138181819, -158.114894),
                    new Vector(21.5870418181819, -158.267435),
                    new Vector(21.5388828181818, -158.243342),
                    new Vector(21.4746588181819, -158.235314),
                    new Vector(21.3542388181818, -158.130959),
                    new Vector(21.2900058181818, -158.098838),
                    new Vector(21.3060618181818, -157.946306),
                    new Vector(21.3301458181818, -157.898138),
                    new Vector(21.2498658181819, -157.825877),
                    new Vector(21.281968818182, -157.721504),
                    new Vector(21.2739498181819, -157.681373),
                    new Vector(21.2980248181819, -157.673327)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries)
            {
                _boundingBox.Expand(linearRing.CalculateBounds());
            }

            return _boundingBox;
        }
    }
}