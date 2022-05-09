using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Texas_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2279;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Texas South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Texas South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",27.83333333333333],PARAMETER[\"standard_parallel_2\",26.16666666666667],PARAMETER[\"latitude_of_origin\",25.66666666666667],PARAMETER[\"central_meridian\",-98.5],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",16404166.667],AUTHORITY[\"EPSG\",\"2279\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Texas South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",27.83333333333333],PARAMETER[\"standard_parallel_2\",26.16666666666667],PARAMETER[\"latitude_of_origin\",25.66666666666667],PARAMETER[\"central_meridian\",-98.5],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",16404166.667],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.2022128181819, -100.21442),
                    new Vector(28.1545578181819, -100.097258),
                    new Vector(28.0037358181819, -99.993641),
                    new Vector(27.98716681818181, -99.94218799999999),
                    new Vector(27.7979688181818, -99.875066),
                    new Vector(27.780391818182, -99.81605299999998),
                    new Vector(27.6618438181818, -99.714821),
                    new Vector(27.6129198181819, -99.549509),
                    new Vector(27.5045778181819, -99.527063),
                    new Vector(27.4910508181819, -99.49081099999999),
                    new Vector(27.3189528181819, -99.54391099999998),
                    new Vector(27.2701818181818, -99.465593),
                    new Vector(27.1994958181818, -99.43747699999999),
                    new Vector(27.0289548181819, -99.455378),
                    new Vector(26.9958618181818, -99.393035),
                    new Vector(26.9469468181819, -99.390839),
                    new Vector(26.8576848181818, -99.285836),
                    new Vector(26.58021481818181, -99.16612700000002),
                    new Vector(26.5460598181818, -99.16898900000001),
                    new Vector(26.4886758181819, -99.10178599999999),
                    new Vector(26.4198708181818, -99.107033),
                    new Vector(26.3956518181818, -98.93957),
                    new Vector(26.3606688181819, -98.909204),
                    new Vector(26.3754108181818, -98.82013999999999),
                    new Vector(26.2423998181819, -98.67821899999998),
                    new Vector(26.2607958181818, -98.600261),
                    new Vector(26.2018908181818, -98.48881399999999),
                    new Vector(26.2212678181819, -98.45368700000002),
                    new Vector(26.1563778181819, -98.38481899999989),
                    new Vector(26.1590328181819, -98.347478),
                    new Vector(26.1119988181819, -98.328227),
                    new Vector(26.1331668181818, -98.2925599999999),
                    new Vector(26.1212418181819, -98.27164399999999),
                    new Vector(26.0984628181819, -98.292236),
                    new Vector(26.0557398181819, -98.200985),
                    new Vector(26.0661078181818, -98.08349899999999),
                    new Vector(26.034985818182, -98.076623),
                    new Vector(26.0597538181819, -98.04035300000001),
                    new Vector(26.0605008181819, -97.8677059999999),
                    new Vector(26.0237988181818, -97.64823199999999),
                    new Vector(25.9623648181818, -97.613195),
                    new Vector(25.9545258181819, -97.575197),
                    new Vector(25.9335918181819, -97.59035299999989),
                    new Vector(25.8455538181819, -97.43460800000001),
                    new Vector(25.8457158181819, -97.38590000000001),
                    new Vector(25.9173828181818, -97.381247),
                    new Vector(25.9390188181819, -97.30469299999999),
                    new Vector(25.9654788181819, -97.307402),
                    new Vector(25.9549308181818, -97.17247399999999),
                    new Vector(26.0094258181819, -97.21334299999999),
                    new Vector(26.0026398181819, -97.276577),
                    new Vector(26.06867281818189, -97.25337500000001),
                    new Vector(26.1828018181819, -97.353617),
                    new Vector(26.3594088181819, -97.368953),
                    new Vector(26.3854098181819, -97.42144099999999),
                    new Vector(26.4771558181819, -97.47496400000001),
                    new Vector(26.5185738181819, -97.42612099999999),
                    new Vector(26.6013288181818, -97.45195100000001),
                    new Vector(26.7941178181819, -97.495835),
                    new Vector(26.8463898181818, -97.558322),
                    new Vector(26.9781948181818, -97.568834),
                    new Vector(26.9968338181818, -97.479266),
                    new Vector(27.0818748181818, -97.503764),
                    new Vector(27.2654568181818, -97.42748),
                    new Vector(27.23052781818191, -97.54843099999999),
                    new Vector(27.2880378181818, -97.785014),
                    new Vector(27.294688818182, -97.68028100000001),
                    new Vector(27.4199778181818, -97.75034599999998),
                    new Vector(27.3004578181818, -97.60037900000002),
                    new Vector(27.3444138181818, -97.52865799999998),
                    new Vector(27.4395258181818, -97.507805),
                    new Vector(27.3199878181817, -97.50070399999998),
                    new Vector(27.321346818182, -97.412531),
                    new Vector(27.5626368181819, -97.3317289999999),
                    new Vector(27.6891498181819, -97.250063),
                    new Vector(27.7081758181819, -97.30948100000001),
                    new Vector(27.6317568181819, -97.34777599999998),
                    new Vector(27.6335028181818, -97.39948099999999),
                    new Vector(27.6411078181819, -97.3536349999999),
                    new Vector(27.6909498181818, -97.32028100000001),
                    new Vector(27.7156368181818, -97.349783),
                    new Vector(27.7125408181819, -97.31806700000001),
                    new Vector(27.7711488181819, -97.396826),
                    new Vector(27.8317278181819, -97.388807),
                    new Vector(27.8205858181819, -97.480085),
                    new Vector(27.843544818182, -97.499813),
                    new Vector(27.8639298181818, -97.52197099999999),
                    new Vector(27.8757738181819, -97.496951),
                    new Vector(27.8532648181819, -97.479626),
                    new Vector(27.8734788181819, -97.34589499999998),
                    new Vector(27.8402508181819, -97.361321),
                    new Vector(27.8714448181818, -97.283759),
                    new Vector(27.83142181818179, -97.213613),
                    new Vector(27.8226288181819, -97.24729100000002),
                    new Vector(27.8125308181818, -97.195739),
                    new Vector(27.91568881818189, -97.11489199999991),
                    new Vector(27.8974998181819, -97.136366),
                    new Vector(28.0408158181818, -97.236482),
                    new Vector(28.0262268181819, -97.270565),
                    new Vector(28.0489428181819, -97.24150400000001),
                    new Vector(28.0650168181819, -97.26055700000001),
                    new Vector(28.0803348181819, -97.263158),
                    new Vector(28.0895148181819, -97.28038399999998),
                    new Vector(28.1034468181817, -97.28509099999999),
                    new Vector(28.0981998181817, -97.29608),
                    new Vector(28.1063718181819, -97.309742),
                    new Vector(28.1163618181819, -97.304783),
                    new Vector(28.1358558181819, -97.31138),
                    new Vector(28.1342358181819, -97.3202),
                    new Vector(28.1134818181818, -97.31828299999999),
                    new Vector(28.1234988181819, -97.33239500000001),
                    new Vector(28.11358081818179, -97.340441),
                    new Vector(28.1313648181819, -97.3708249999999),
                    new Vector(28.1192238181819, -97.38253399999999),
                    new Vector(28.124164818182, -97.39631300000001),
                    new Vector(28.1125368181819, -97.39099400000001),
                    new Vector(28.1020788181819, -97.396466),
                    new Vector(28.1100618181818, -97.42198999999999),
                    new Vector(28.1321388181818, -97.42131499999989),
                    new Vector(28.1313288181819, -97.445066),
                    new Vector(28.1441628181819, -97.44314),
                    new Vector(28.1544408181818, -97.469123),
                    new Vector(28.1705418181819, -97.469168),
                    new Vector(28.1592288181819, -97.49632099999999),
                    new Vector(28.1443158181818, -97.508111),
                    new Vector(28.1546298181818, -97.516058),
                    new Vector(28.1563668181818, -97.53147500000001),
                    new Vector(28.1215368181819, -97.557233),
                    new Vector(28.1698848181819, -97.81322900000001),
                    new Vector(28.1108538181818, -97.89721700000001),
                    new Vector(28.0588788181819, -97.89799099999999),
                    new Vector(28.0609398181819, -98.238938),
                    new Vector(28.0616238181818, -98.33936),
                    new Vector(28.0610028181818, -98.807045),
                    new Vector(28.0360368181818, -99.390227),
                    new Vector(28.2039048181817, -99.39263900000002),
                    new Vector(28.2032838181819, -100.110731),
                    new Vector(28.2022128181819, -100.21442)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(27.5814468181818, -97.248938),
                    new Vector(27.4411368181819, -97.33577),
                    new Vector(27.2849598181818, -97.376351),
                    new Vector(27.2107818181818, -97.379645),
                    new Vector(27.2840328181819, -97.35938599999999),
                    new Vector(27.5743278181818, -97.22398099999999),
                    new Vector(27.8307828181819, -97.053836),
                    new Vector(27.81951481818181, -97.113299),
                    new Vector(27.8115858181819, -97.07556200000001),
                    new Vector(27.7077708181818, -97.170449),
                    new Vector(27.6123798181818, -97.20384799999998),
                    new Vector(27.6520608181818, -97.25894600000001),
                    new Vector(27.5814468181818, -97.248938)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(26.4196548181819, -97.25150299999999),
                    new Vector(26.3488968181819, -97.2265639999999),
                    new Vector(26.2508868181819, -97.20916699999999),
                    new Vector(26.0722728181819, -97.17958400000001),
                    new Vector(26.0780688181819, -97.172042),
                    new Vector(26.2595898181818, -97.195244),
                    new Vector(26.41849381818171, -97.23236),
                    new Vector(26.6010048181818, -97.29608899999998),
                    new Vector(26.8030008181818, -97.35827900000001),
                    new Vector(26.9493588181819, -97.38158900000001),
                    new Vector(27.0975708181818, -97.3871869999999),
                    new Vector(27.2047698181819, -97.378799),
                    new Vector(27.2019708181818, -97.38905900000002),
                    new Vector(27.1115568181819, -97.40117300000001),
                    new Vector(26.9223138181819, -97.39557499999999),
                    new Vector(26.8207128181818, -97.38158900000001),
                    new Vector(26.7069798181819, -97.35827900000001),
                    new Vector(26.6013648181819, -97.3013899999999),
                    new Vector(26.5403088181819, -97.2788),
                    new Vector(26.4792528181819, -97.26749599999989),
                    new Vector(26.4196548181819, -97.25150299999999)
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