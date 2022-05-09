using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_Kansas_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3420;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kansas South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Kansas South (ft US)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",38.56666666666667],PARAMETER[\"standard_parallel_2\",37.26666666666667],PARAMETER[\"latitude_of_origin\",36.66666666666666],PARAMETER[\"central_meridian\",-98.5],PARAMETER[\"false_easting\",1312333.3333],PARAMETER[\"false_northing\",1312333.3333],AUTHORITY[\"EPSG\",\"3420\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Kansas South (ft US)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",38.56666666666667],PARAMETER[\"standard_parallel_2\",37.26666666666667],PARAMETER[\"latitude_of_origin\",36.66666666666666],PARAMETER[\"central_meridian\",-98.5],PARAMETER[\"false_easting\",1312333.3333],PARAMETER[\"false_northing\",1312333.3333],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(36.9990648181818, -98.347145),
                    new Vector(36.9986688181819, -98.104523),
                    new Vector(36.9985608181818, -97.80425600000001),
                    new Vector(36.9964638181819, -97.465406),
                    new Vector(36.9998118181818, -97.13768899999998),
                    new Vector(37.0001628181819, -96.74870000000001),
                    new Vector(37.0005858181819, -96.51919099999999),
                    new Vector(36.9983358181819, -96.006056),
                    new Vector(37.0000818181819, -95.95795999999999),
                    new Vector(36.9981198181819, -95.78574500000001),
                    new Vector(37.0010178181819, -95.526014),
                    new Vector(37.0006218181818, -95.40662),
                    new Vector(37.0014858181819, -95.07192799999999),
                    new Vector(37.0007838181819, -95.0327419999999),
                    new Vector(36.997048818182, -94.62038),
                    new Vector(37.0601478181819, -94.62066799999988),
                    new Vector(37.3277358181819, -94.618976),
                    new Vector(37.3607658181819, -94.61875999999999),
                    new Vector(37.6503768181819, -94.61900300000001),
                    new Vector(37.6798698181818, -94.619291),
                    new Vector(38.030392818182, -94.61673500000001),
                    new Vector(38.0557818181817, -94.6173289999999),
                    new Vector(38.3920398181818, -94.619057),
                    new Vector(38.4714738181819, -94.61871500000001),
                    new Vector(38.7372168181819, -94.61314400000001),
                    new Vector(38.7338868181818, -95.05429700000001),
                    new Vector(38.7302058181819, -95.49502699999998),
                    new Vector(38.8615338181819, -95.4966289999999),
                    new Vector(38.8632258181819, -95.941121),
                    new Vector(38.7347778181818, -95.94203899999999),
                    new Vector(38.7325638181818, -96.35165600000001),
                    new Vector(38.5147458181818, -96.35284399999999),
                    new Vector(38.5159608181818, -96.81565999999999),
                    new Vector(38.5190388181818, -96.921464),
                    new Vector(38.5967268181818, -96.9242629999999),
                    new Vector(38.5981848181818, -97.36389500000001),
                    new Vector(38.601649818182, -97.924739),
                    new Vector(38.5158888181819, -97.92362300000002),
                    new Vector(38.5152588181818, -98.475683),
                    new Vector(38.6884818181819, -98.475584),
                    new Vector(38.6877348181819, -98.48210000000002),
                    new Vector(38.6916498181819, -99.02516),
                    new Vector(38.6931798181819, -99.033962),
                    new Vector(38.6893188181818, -99.58310600000002),
                    new Vector(38.6913168181819, -99.59543600000001),
                    new Vector(38.6945568181818, -100.150826),
                    new Vector(38.6937108181818, -100.242824),
                    new Vector(38.6946828181819, -100.683257),
                    new Vector(38.6963928181818, -100.814738),
                    new Vector(38.6954568181818, -101.122511),
                    new Vector(38.6946648181818, -101.478623),
                    new Vector(38.6932878181819, -101.563529),
                    new Vector(38.6925588181819, -102.047567),
                    new Vector(38.6155008181819, -102.047585),
                    new Vector(38.263348818182, -102.045542),
                    new Vector(38.2538178181819, -102.046064),
                    new Vector(37.7344008181819, -102.043976),
                    new Vector(37.6414758181819, -102.044453),
                    new Vector(37.3862808181818, -102.042005),
                    new Vector(36.9889938181818, -102.037208),
                    new Vector(36.9888768181819, -102.024518),
                    new Vector(36.9966888181818, -101.553674),
                    new Vector(36.9974628181819, -101.071598),
                    new Vector(36.9966618181819, -100.950593),
                    new Vector(36.9978408181819, -100.634243),
                    new Vector(36.9976518181817, -100.088573),
                    new Vector(36.9954198181818, -99.99926600000001),
                    new Vector(36.9954648181818, -99.54464000000002),
                    new Vector(36.9945558181819, -99.43747699999999),
                    new Vector(36.9980748181819, -98.99951899999999),
                    new Vector(36.9983718181818, -98.540222),
                    new Vector(36.9990648181818, -98.347145)
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