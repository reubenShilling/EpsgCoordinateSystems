using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_South_Dakota_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3454;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "South Dakota North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / South Dakota North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",44.4],PARAMETER[\"standard_parallel_2\",42.83333333333334],PARAMETER[\"latitude_of_origin\",42.33333333333334],PARAMETER[\"central_meridian\",-100.3333333333333],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3454\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / South Dakota North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",44.4],PARAMETER[\"standard_parallel_2\",42.83333333333334],PARAMETER[\"latitude_of_origin\",42.33333333333334],PARAMETER[\"central_meridian\",-100.3333333333333],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.1995508181819, -98.9296609999999),
                    new Vector(44.1994248181818, -98.70429199999998),
                    new Vector(44.1980028181819, -98.33786600000001),
                    new Vector(44.1953118181818, -97.856483),
                    new Vector(44.1954288181819, -97.37471300000001),
                    new Vector(44.1936288181819, -97.1326669999999),
                    new Vector(44.1946368181819, -96.89157499999999),
                    new Vector(44.1990648181819, -96.45739700000001),
                    new Vector(44.5383468181819, -96.45511099999999),
                    new Vector(44.6288058181818, -96.456722),
                    new Vector(44.8013448181819, -96.455219),
                    new Vector(44.9719938181819, -96.45608300000001),
                    new Vector(45.2751948181819, -96.454499),
                    new Vector(45.2988558181819, -96.457604),
                    new Vector(45.3285108181819, -96.47759299999998),
                    new Vector(45.3751398181819, -96.53254700000001),
                    new Vector(45.3965238181818, -96.60507800000001),
                    new Vector(45.4106358181818, -96.69316999999999),
                    new Vector(45.4581918181818, -96.738035),
                    new Vector(45.51748381818189, -96.76924699999989),
                    new Vector(45.5840928181818, -96.8430919999999),
                    new Vector(45.6091218181819, -96.85499),
                    new Vector(45.65069281818191, -96.832796),
                    new Vector(45.7389738181819, -96.65739499999999),
                    new Vector(45.8082648181819, -96.60460999999989),
                    new Vector(45.8178588181819, -96.58795099999999),
                    new Vector(45.9341118181819, -96.566918),
                    new Vector(45.9364968181819, -97.233305),
                    new Vector(45.9308178181818, -97.97872099999999),
                    new Vector(45.9315018181818, -98.014712),
                    new Vector(45.93826981818189, -98.73043700000001),
                    new Vector(45.9395568181819, -99.00683600000001),
                    new Vector(45.9427608181819, -99.717341),
                    new Vector(45.9435438181818, -99.87578600000001),
                    new Vector(45.9403938181819, -100.514408),
                    new Vector(45.94250881818191, -102.002774),
                    new Vector(45.941662818182, -102.946397),
                    new Vector(45.9411138181818, -102.994826),
                    new Vector(45.94299481818179, -104.048915),
                    new Vector(45.88305481818179, -104.049518),
                    new Vector(45.2128698181819, -104.043857),
                    new Vector(44.9978058181819, -104.043074),
                    new Vector(44.9973378181819, -104.059841),
                    new Vector(44.5743558181818, -104.059472),
                    new Vector(44.1818298181819, -104.061038),
                    new Vector(44.1458298181818, -104.059724),
                    new Vector(44.1456408181818, -103.455815),
                    new Vector(44.1470898181818, -102.395678),
                    new Vector(44.1608598181818, -102.404282),
                    new Vector(44.1844038181819, -102.390341),
                    new Vector(44.1840978181818, -102.403733),
                    new Vector(44.1936648181818, -102.402869),
                    new Vector(44.2149858181818, -102.394715),
                    new Vector(44.2356408181818, -102.368705),
                    new Vector(44.2653048181818, -102.371828),
                    new Vector(44.3556738181818, -102.342821),
                    new Vector(44.3820798181819, -102.303806),
                    new Vector(44.4431988181819, -102.304832),
                    new Vector(44.4543138181818, -102.2828),
                    new Vector(44.4576978181818, -102.227666),
                    new Vector(44.4471498181819, -102.222815),
                    new Vector(44.4330738181819, -102.193754),
                    new Vector(44.4304368181819, -102.1676),
                    new Vector(44.4444228181818, -102.156971),
                    new Vector(44.4469518181818, -102.142184),
                    new Vector(44.4402198181818, -102.116777),
                    new Vector(44.4843378181818, -102.076484),
                    new Vector(44.4908718181819, -102.055802),
                    new Vector(44.5075308181817, -102.040592),
                    new Vector(44.5165308181818, -102.001244),
                    new Vector(44.5277448181819, -101.989382),
                    new Vector(44.5389858181819, -101.948036),
                    new Vector(44.5366458181819, -101.828912),
                    new Vector(44.5300578181819, -101.816933),
                    new Vector(44.5426218181819, -101.803721),
                    new Vector(44.5436928181819, -101.786369),
                    new Vector(44.5591728181818, -101.75702),
                    new Vector(44.5744098181818, -101.741126),
                    new Vector(44.5799088181819, -101.688989),
                    new Vector(44.5896468181818, -101.671988),
                    new Vector(44.5770468181819, -101.529401),
                    new Vector(44.5888548181819, -101.501393),
                    new Vector(44.6086188181819, -101.485265),
                    new Vector(44.6104908181819, -101.463386),
                    new Vector(44.6462478181818, -101.447906),
                    new Vector(44.6448708181818, -101.424218),
                    new Vector(44.6582178181818, -101.406362),
                    new Vector(44.6602608181819, -101.370983),
                    new Vector(44.6893758181818, -101.365988),
                    new Vector(44.6933718181818, -101.337575),
                    new Vector(44.6840298181818, -101.32637),
                    new Vector(44.7031098181818, -101.210594),
                    new Vector(44.7494418181819, -101.135381),
                    new Vector(44.7452028181818, -101.066117),
                    new Vector(44.7303978181819, -101.015969),
                    new Vector(44.7535998181819, -100.971869),
                    new Vector(44.766163818182, -100.962293),
                    new Vector(44.7669648181817, -100.937165),
                    new Vector(44.7788628181819, -100.918616),
                    new Vector(44.7714288181818, -100.893227),
                    new Vector(44.7816708181819, -100.862519),
                    new Vector(44.7705288181818, -100.81607),
                    new Vector(44.7749838181818, -100.792058),
                    new Vector(44.7624558181819, -100.765004),
                    new Vector(44.7748218181819, -100.747679),
                    new Vector(44.7672708181819, -100.737752),
                    new Vector(44.7709248181819, -100.718915),
                    new Vector(44.7368328181819, -100.633136),
                    new Vector(44.6871168181819, -100.616963),
                    new Vector(44.6216778181818, -100.646573),
                    new Vector(44.5752918181818, -100.634756),
                    new Vector(44.5597848181818, -100.598963),
                    new Vector(44.5635378181818, -100.567355),
                    new Vector(44.5576428181819, -100.533668),
                    new Vector(44.5486698181818, -100.521932),
                    new Vector(44.5505778181819, -99.6809719999999),
                    new Vector(44.5500828181818, -99.665609),
                    new Vector(44.2213758181819, -99.66170299999999),
                    new Vector(44.2146978181818, -99.611699),
                    new Vector(44.1967158181819, -99.57839899999999),
                    new Vector(44.1994788181818, -99.29993),
                    new Vector(44.1995508181819, -98.9296609999999)
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