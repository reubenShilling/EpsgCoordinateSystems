using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_South_Dakota_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3454;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "South Dakota North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / South Dakota North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44.4],PARAMETER[standard_parallel_2,42.83333333333334],PARAMETER[latitude_of_origin,42.33333333333334],PARAMETER[central_meridian,-100.3333333333333],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,3454],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / South Dakota North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,44.4],PARAMETER[standard_parallel_2,42.83333333333334],PARAMETER[latitude_of_origin,42.33333333333334],PARAMETER[central_meridian,-100.3333333333333],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-98.9296609999999, 44.1995508181819, 0),
                    new Vector(-98.70429199999998, 44.1994248181818, 0),
                    new Vector(-98.33786600000001, 44.1980028181819, 0),
                    new Vector(-97.856483, 44.1953118181818, 0),
                    new Vector(-97.37471300000001, 44.1954288181819, 0),
                    new Vector(-97.1326669999999, 44.1936288181819, 0),
                    new Vector(-96.89157499999999, 44.1946368181819, 0),
                    new Vector(-96.45739700000001, 44.1990648181819, 0),
                    new Vector(-96.45511099999999, 44.5383468181819, 0),
                    new Vector(-96.456722, 44.6288058181818, 0),
                    new Vector(-96.455219, 44.8013448181819, 0),
                    new Vector(-96.45608300000001, 44.9719938181819, 0),
                    new Vector(-96.454499, 45.2751948181819, 0),
                    new Vector(-96.457604, 45.2988558181819, 0),
                    new Vector(-96.47759299999998, 45.3285108181819, 0),
                    new Vector(-96.53254700000001, 45.3751398181819, 0),
                    new Vector(-96.60507800000001, 45.3965238181818, 0),
                    new Vector(-96.69316999999999, 45.4106358181818, 0),
                    new Vector(-96.738035, 45.4581918181818, 0),
                    new Vector(-96.76924699999989, 45.51748381818189, 0),
                    new Vector(-96.8430919999999, 45.5840928181818, 0),
                    new Vector(-96.85499, 45.6091218181819, 0),
                    new Vector(-96.832796, 45.65069281818191, 0),
                    new Vector(-96.65739499999999, 45.7389738181819, 0),
                    new Vector(-96.60460999999989, 45.8082648181819, 0),
                    new Vector(-96.58795099999999, 45.8178588181819, 0),
                    new Vector(-96.566918, 45.9341118181819, 0),
                    new Vector(-97.233305, 45.9364968181819, 0),
                    new Vector(-97.97872099999999, 45.9308178181818, 0),
                    new Vector(-98.014712, 45.9315018181818, 0),
                    new Vector(-98.73043700000001, 45.93826981818189, 0),
                    new Vector(-99.00683600000001, 45.9395568181819, 0),
                    new Vector(-99.717341, 45.9427608181819, 0),
                    new Vector(-99.87578600000001, 45.9435438181818, 0),
                    new Vector(-100.514408, 45.9403938181819, 0),
                    new Vector(-102.002774, 45.94250881818191, 0),
                    new Vector(-102.946397, 45.941662818182, 0),
                    new Vector(-102.994826, 45.9411138181818, 0),
                    new Vector(-104.048915, 45.94299481818179, 0),
                    new Vector(-104.049518, 45.88305481818179, 0),
                    new Vector(-104.043857, 45.2128698181819, 0),
                    new Vector(-104.043074, 44.9978058181819, 0),
                    new Vector(-104.059841, 44.9973378181819, 0),
                    new Vector(-104.059472, 44.5743558181818, 0),
                    new Vector(-104.061038, 44.1818298181819, 0),
                    new Vector(-104.059724, 44.1458298181818, 0),
                    new Vector(-103.455815, 44.1456408181818, 0),
                    new Vector(-102.395678, 44.1470898181818, 0),
                    new Vector(-102.404282, 44.1608598181818, 0),
                    new Vector(-102.390341, 44.1844038181819, 0),
                    new Vector(-102.403733, 44.1840978181818, 0),
                    new Vector(-102.402869, 44.1936648181818, 0),
                    new Vector(-102.394715, 44.2149858181818, 0),
                    new Vector(-102.368705, 44.2356408181818, 0),
                    new Vector(-102.371828, 44.2653048181818, 0),
                    new Vector(-102.342821, 44.3556738181818, 0),
                    new Vector(-102.303806, 44.3820798181819, 0),
                    new Vector(-102.304832, 44.4431988181819, 0),
                    new Vector(-102.2828, 44.4543138181818, 0),
                    new Vector(-102.227666, 44.4576978181818, 0),
                    new Vector(-102.222815, 44.4471498181819, 0),
                    new Vector(-102.193754, 44.4330738181819, 0),
                    new Vector(-102.1676, 44.4304368181819, 0),
                    new Vector(-102.156971, 44.4444228181818, 0),
                    new Vector(-102.142184, 44.4469518181818, 0),
                    new Vector(-102.116777, 44.4402198181818, 0),
                    new Vector(-102.076484, 44.4843378181818, 0),
                    new Vector(-102.055802, 44.4908718181819, 0),
                    new Vector(-102.040592, 44.5075308181817, 0),
                    new Vector(-102.001244, 44.5165308181818, 0),
                    new Vector(-101.989382, 44.5277448181819, 0),
                    new Vector(-101.948036, 44.5389858181819, 0),
                    new Vector(-101.828912, 44.5366458181819, 0),
                    new Vector(-101.816933, 44.5300578181819, 0),
                    new Vector(-101.803721, 44.5426218181819, 0),
                    new Vector(-101.786369, 44.5436928181819, 0),
                    new Vector(-101.75702, 44.5591728181818, 0),
                    new Vector(-101.741126, 44.5744098181818, 0),
                    new Vector(-101.688989, 44.5799088181819, 0),
                    new Vector(-101.671988, 44.5896468181818, 0),
                    new Vector(-101.529401, 44.5770468181819, 0),
                    new Vector(-101.501393, 44.5888548181819, 0),
                    new Vector(-101.485265, 44.6086188181819, 0),
                    new Vector(-101.463386, 44.6104908181819, 0),
                    new Vector(-101.447906, 44.6462478181818, 0),
                    new Vector(-101.424218, 44.6448708181818, 0),
                    new Vector(-101.406362, 44.6582178181818, 0),
                    new Vector(-101.370983, 44.6602608181819, 0),
                    new Vector(-101.365988, 44.6893758181818, 0),
                    new Vector(-101.337575, 44.6933718181818, 0),
                    new Vector(-101.32637, 44.6840298181818, 0),
                    new Vector(-101.210594, 44.7031098181818, 0),
                    new Vector(-101.135381, 44.7494418181819, 0),
                    new Vector(-101.066117, 44.7452028181818, 0),
                    new Vector(-101.015969, 44.7303978181819, 0),
                    new Vector(-100.971869, 44.7535998181819, 0),
                    new Vector(-100.962293, 44.766163818182, 0),
                    new Vector(-100.937165, 44.7669648181817, 0),
                    new Vector(-100.918616, 44.7788628181819, 0),
                    new Vector(-100.893227, 44.7714288181818, 0),
                    new Vector(-100.862519, 44.7816708181819, 0),
                    new Vector(-100.81607, 44.7705288181818, 0),
                    new Vector(-100.792058, 44.7749838181818, 0),
                    new Vector(-100.765004, 44.7624558181819, 0),
                    new Vector(-100.747679, 44.7748218181819, 0),
                    new Vector(-100.737752, 44.7672708181819, 0),
                    new Vector(-100.718915, 44.7709248181819, 0),
                    new Vector(-100.633136, 44.7368328181819, 0),
                    new Vector(-100.616963, 44.6871168181819, 0),
                    new Vector(-100.646573, 44.6216778181818, 0),
                    new Vector(-100.634756, 44.5752918181818, 0),
                    new Vector(-100.598963, 44.5597848181818, 0),
                    new Vector(-100.567355, 44.5635378181818, 0),
                    new Vector(-100.533668, 44.5576428181819, 0),
                    new Vector(-100.521932, 44.5486698181818, 0),
                    new Vector(-99.6809719999999, 44.5505778181819, 0),
                    new Vector(-99.665609, 44.5500828181818, 0),
                    new Vector(-99.66170299999999, 44.2213758181819, 0),
                    new Vector(-99.611699, 44.2146978181818, 0),
                    new Vector(-99.57839899999999, 44.1967158181819, 0),
                    new Vector(-99.29993, 44.1994788181818, 0),
                    new Vector(-98.9296609999999, 44.1995508181819, 0)
                })
            }
        };
    }
}