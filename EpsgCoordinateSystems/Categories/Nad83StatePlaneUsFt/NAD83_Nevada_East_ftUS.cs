using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    public class NAD83_Nevada_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3421;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nevada East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Nevada East (ft US)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",34.75],PARAMETER[\"central_meridian\",-115.5833333333333],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",656166.6667],PARAMETER[\"false_northing\",26246666.66670001],AUTHORITY[\"EPSG\",\"3421\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Nevada East (ft US)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",34.75],PARAMETER[\"central_meridian\",-115.5833333333333],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",656166.6667],PARAMETER[\"false_northing\",26246666.66670001],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(37.5984828181818, -114.047267),
                    new Vector(38.1376548181818, -114.047276),
                    new Vector(38.5710948181818, -114.045089),
                    new Vector(38.6789958181819, -114.044261),
                    new Vector(39.5386848181819, -114.040112),
                    new Vector(39.9087828181819, -114.039842),
                    new Vector(40.1110488181818, -114.038105),
                    new Vector(40.9976838181818, -114.038159),
                    new Vector(41.9953878181819, -114.039077),
                    new Vector(41.9959278181818, -114.269486),
                    new Vector(41.9965128181819, -115.024865),
                    new Vector(41.9945958181819, -115.947545),
                    new Vector(41.994793818182, -116.992319),
                    new Vector(40.9935168181818, -117.007025),
                    new Vector(40.9942008181818, -116.583953),
                    new Vector(39.1591728181818, -116.583188),
                    new Vector(39.1618008181818, -115.899575),
                    new Vector(39.1559058181819, -115.900259),
                    new Vector(38.6808408181818, -114.994166),
                    new Vector(38.0461968181818, -114.99566),
                    new Vector(38.0448108181819, -115.884113),
                    new Vector(36.8389008181819, -115.881377),
                    new Vector(36.0012258181819, -115.885769),
                    new Vector(35.7957018181818, -115.6262),
                    new Vector(34.9989138181818, -114.621071),
                    new Vector(35.0418618181819, -114.633779),
                    new Vector(35.0760528181818, -114.595637),
                    new Vector(35.1186588181819, -114.635912),
                    new Vector(35.1339048181817, -114.626444),
                    new Vector(35.1325638181818, -114.582614),
                    new Vector(35.1400608181818, -114.572255),
                    new Vector(35.1743418181818, -114.561032),
                    new Vector(35.2201788181818, -114.559574),
                    new Vector(35.3047698181819, -114.587888),
                    new Vector(35.358382818182, -114.58958),
                    new Vector(35.4507678181819, -114.645398),
                    new Vector(35.5157568181819, -114.672218),
                    new Vector(35.5466358181819, -114.64979),
                    new Vector(35.5848408181818, -114.653138),
                    new Vector(35.6113458181819, -114.639863),
                    new Vector(35.6465808181819, -114.654065),
                    new Vector(35.6563998181819, -114.668483),
                    new Vector(35.6931018181819, -114.66509),
                    new Vector(35.7325938181818, -114.688814),
                    new Vector(35.7646968181819, -114.682739),
                    new Vector(35.8474428181819, -114.689867),
                    new Vector(35.8709598181819, -114.662462),
                    new Vector(35.8804728181819, -114.661598),
                    new Vector(35.9116128181818, -114.699272),
                    new Vector(35.9876448181819, -114.736208),
                    new Vector(36.0367578181818, -114.717677),
                    new Vector(36.0587538181819, -114.728963),
                    new Vector(36.0859608181818, -114.728153),
                    new Vector(36.1051848181818, -114.712754),
                    new Vector(36.1419678181819, -114.621611),
                    new Vector(36.1383408181818, -114.59894),
                    new Vector(36.1550898181819, -114.530576),
                    new Vector(36.124705818182, -114.466622),
                    new Vector(36.1210518181818, -114.443942),
                    new Vector(36.1509948181818, -114.380798),
                    new Vector(36.1374858181819, -114.34424),
                    new Vector(36.1114398181818, -114.316088),
                    new Vector(36.0871128181819, -114.303848),
                    new Vector(36.0622368181819, -114.307592),
                    new Vector(36.0183258181819, -114.233477),
                    new Vector(36.0172548181819, -114.206774),
                    new Vector(36.0417258181818, -114.129023),
                    new Vector(36.1210878181819, -114.107774),
                    new Vector(36.1939788181818, -114.045107),
                    new Vector(36.2160288181818, -114.037394),
                    new Vector(36.8418438181819, -114.04373),
                    new Vector(36.9965358181818, -114.043937),
                    new Vector(37.5984828181818, -114.047267)
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