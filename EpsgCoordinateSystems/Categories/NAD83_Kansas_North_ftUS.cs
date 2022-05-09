using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_Kansas_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3419;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kansas North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Kansas North (ft US)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",39.78333333333333],PARAMETER[\"standard_parallel_2\",38.71666666666667],PARAMETER[\"latitude_of_origin\",38.33333333333334],PARAMETER[\"central_meridian\",-98],PARAMETER[\"false_easting\",1312333.3333],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3419\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Kansas North (ft US)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",39.78333333333333],PARAMETER[\"standard_parallel_2\",38.71666666666667],PARAMETER[\"latitude_of_origin\",38.33333333333334],PARAMETER[\"central_meridian\",-98],PARAMETER[\"false_easting\",1312333.3333],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.7302058181819, -95.49502699999998),
                    new Vector(38.7338868181818, -95.05429700000001),
                    new Vector(38.7372168181819, -94.61314400000001),
                    new Vector(38.8371078181818, -94.61246899999999),
                    new Vector(39.0446658181818, -94.60928300000002),
                    new Vector(39.1127958181818, -94.60814000000001),
                    new Vector(39.141226818182, -94.60122800000001),
                    new Vector(39.1516488181819, -94.61265800000001),
                    new Vector(39.1584258181818, -94.64640799999998),
                    new Vector(39.1749138181819, -94.67551400000002),
                    new Vector(39.1712508181819, -94.730531),
                    new Vector(39.1968828181819, -94.790048),
                    new Vector(39.2110038181818, -94.820819),
                    new Vector(39.2617638181819, -94.833473),
                    new Vector(39.2860458181819, -94.88111000000001),
                    new Vector(39.3230268181818, -94.90767799999999),
                    new Vector(39.3401178181819, -94.91134099999989),
                    new Vector(39.3806358181819, -94.89828199999998),
                    new Vector(39.3812658181818, -94.92574100000002),
                    new Vector(39.4114428181818, -94.95849200000001),
                    new Vector(39.4394598181819, -94.986203),
                    new Vector(39.4629408181818, -95.04050899999999),
                    new Vector(39.4853238181819, -95.047601),
                    new Vector(39.532843818182, -95.10203300000001),
                    new Vector(39.5606898181819, -95.10899000000001),
                    new Vector(39.5867718181819, -95.05361299999988),
                    new Vector(39.6256878181819, -95.056016),
                    new Vector(39.6619128181819, -95.02828700000001),
                    new Vector(39.6849888181818, -94.978571),
                    new Vector(39.7320408181819, -94.96178600000002),
                    new Vector(39.7364958181819, -94.953146),
                    new Vector(39.7270278181819, -94.930853),
                    new Vector(39.7267578181819, -94.90568),
                    new Vector(39.7393128181819, -94.877861),
                    new Vector(39.7541178181819, -94.87118300000002),
                    new Vector(39.7606788181819, -94.87706),
                    new Vector(39.7578438181818, -94.92179899999999),
                    new Vector(39.7754298181819, -94.93511900000001),
                    new Vector(39.7827738181818, -94.93326500000001),
                    new Vector(39.7937718181819, -94.899326),
                    new Vector(39.8173968181818, -94.88850799999999),
                    new Vector(39.8283408181819, -94.89832699999999),
                    new Vector(39.8331288181819, -94.9238689999999),
                    new Vector(39.8493828181819, -94.936505),
                    new Vector(39.8960838181819, -94.93824199999999),
                    new Vector(39.9008268181819, -94.96502599999998),
                    new Vector(39.8969838181819, -95.021771),
                    new Vector(39.8778498181819, -95.033507),
                    new Vector(39.8665368181819, -95.063243),
                    new Vector(39.8698668181819, -95.100719),
                    new Vector(39.9080538181819, -95.15055199999999),
                    new Vector(39.9101778181818, -95.1939679999999),
                    new Vector(39.9381768181819, -95.20760300000001),
                    new Vector(39.9421098181819, -95.240966),
                    new Vector(39.9994128181819, -95.3087),
                    new Vector(39.9925908181818, -95.3296969999999),
                    new Vector(39.9934908181818, -95.78069600000001),
                    new Vector(39.9951648181818, -96.00125900000002),
                    new Vector(39.9944988181817, -96.24059599999991),
                    new Vector(39.9941748181819, -96.45404000000001),
                    new Vector(39.9944718181818, -96.80142199999999),
                    new Vector(39.9961548181818, -96.908288),
                    new Vector(39.9973788181819, -97.361906),
                    new Vector(39.9997278181818, -97.81659500000002),
                    new Vector(39.9984588181819, -97.92959),
                    new Vector(39.998440818182, -98.26416500000001),
                    new Vector(39.9971268181818, -98.50448299999999),
                    new Vector(39.9984678181819, -98.720636),
                    new Vector(39.9983328181819, -99.064742),
                    new Vector(39.9995838181819, -99.178196),
                    new Vector(40.0029948181818, -99.627863),
                    new Vector(40.0004838181819, -100.180913),
                    new Vector(40.0005828181819, -100.19111),
                    new Vector(39.9991698181819, -100.735043),
                    new Vector(40.0001958181819, -100.754861),
                    new Vector(40.0018158181818, -101.322149),
                    new Vector(40.0009968181819, -101.407388),
                    new Vector(39.9989178181818, -102.051536),
                    new Vector(39.5686908181818, -102.049448),
                    new Vector(39.5627958181818, -102.0488),
                    new Vector(39.1267548181818, -102.047873),
                    new Vector(39.0369978181819, -102.04898),
                    new Vector(38.6925588181819, -102.047567),
                    new Vector(38.6932878181819, -101.563529),
                    new Vector(38.6946648181818, -101.478623),
                    new Vector(38.6954568181818, -101.122511),
                    new Vector(38.6963928181818, -100.814738),
                    new Vector(38.6946828181819, -100.683257),
                    new Vector(38.6937108181818, -100.242824),
                    new Vector(38.6945568181818, -100.150826),
                    new Vector(38.6913168181819, -99.59543600000001),
                    new Vector(38.6893188181818, -99.58310600000002),
                    new Vector(38.6931798181819, -99.033962),
                    new Vector(38.6916498181819, -99.02516),
                    new Vector(38.6877348181819, -98.48210000000002),
                    new Vector(38.6884818181819, -98.475584),
                    new Vector(38.5152588181818, -98.475683),
                    new Vector(38.5158888181819, -97.92362300000002),
                    new Vector(38.601649818182, -97.924739),
                    new Vector(38.5981848181818, -97.36389500000001),
                    new Vector(38.5967268181818, -96.9242629999999),
                    new Vector(38.5190388181818, -96.921464),
                    new Vector(38.5159608181818, -96.81565999999999),
                    new Vector(38.5147458181818, -96.35284399999999),
                    new Vector(38.7325638181818, -96.35165600000001),
                    new Vector(38.7347778181818, -95.94203899999999),
                    new Vector(38.8632258181819, -95.941121),
                    new Vector(38.8615338181819, -95.4966289999999),
                    new Vector(38.7302058181819, -95.49502699999998)
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