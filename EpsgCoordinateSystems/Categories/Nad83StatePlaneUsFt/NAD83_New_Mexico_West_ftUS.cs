using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_New_Mexico_West_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2259;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Mexico West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / New Mexico West (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",31],PARAMETER[\"central_meridian\",-107.8333333333333],PARAMETER[\"scale_factor\",0.999916667],PARAMETER[\"false_easting\",2723091.667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2259\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / New Mexico West (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",31],PARAMETER[\"central_meridian\",-107.8333333333333],PARAMETER[\"scale_factor\",0.999916667],PARAMETER[\"false_easting\",2723091.667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.3920358181818, -106.328012),
                    new Vector(33.3923418181819, -106.360997),
                    new Vector(33.4783818181818, -106.362518),
                    new Vector(33.4790118181818, -107.701223),
                    new Vector(33.8315148181819, -107.70422),
                    new Vector(33.8329818181818, -107.71304),
                    new Vector(34.2684468181818, -107.711384),
                    new Vector(34.2690048181819, -107.720825),
                    new Vector(34.5843108181818, -107.718404),
                    new Vector(34.5835728181819, -107.195423),
                    new Vector(34.6109328181819, -107.195486),
                    new Vector(34.6135248181819, -107.204333),
                    new Vector(34.963723818182, -107.217932),
                    new Vector(34.9634718181819, -107.054312),
                    new Vector(35.2252728181818, -107.18078),
                    new Vector(35.3117988181819, -107.228309),
                    new Vector(35.3123298181818, -107.294801),
                    new Vector(36.0018108181818, -107.302055),
                    new Vector(36.0032418181819, -107.62448),
                    new Vector(36.2209878181818, -107.623364),
                    new Vector(36.8110728181819, -107.625182),
                    new Vector(36.8158518181819, -107.607263),
                    new Vector(36.8406288181819, -107.592998),
                    new Vector(36.9064908181819, -107.453615),
                    new Vector(36.9661788181818, -107.441447),
                    new Vector(36.9975258181818, -107.41082),
                    new Vector(36.9987768181817, -107.47247),
                    new Vector(36.9994698181819, -108.37247),
                    new Vector(36.9966438181818, -109.048478),
                    new Vector(35.9966628181818, -109.047857),
                    new Vector(34.9546428181818, -109.046642),
                    new Vector(34.5917808181819, -109.048658),
                    new Vector(33.7833018181819, -109.050341),
                    new Vector(33.2051598181819, -109.050521),
                    new Vector(32.7795588181818, -109.051349),
                    new Vector(32.4420498181818, -109.049495),
                    new Vector(31.3434558181819, -109.045616),
                    new Vector(31.3438518181818, -108.210641),
                    new Vector(31.7869038181819, -108.203252),
                    new Vector(31.7850858181818, -107.28356),
                    new Vector(32.6072358181819, -107.286503),
                    new Vector(32.7812148181819, -107.285477),
                    new Vector(32.7893868181818, -106.878227),
                    new Vector(32.8294818181819, -106.878803),
                    new Vector(33.0596118181819, -106.323386),
                    new Vector(33.3920358181818, -106.328012)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries) _boundingBox.Expand(linearRing.CalculateBounds());

            return _boundingBox;
        }
    }
}