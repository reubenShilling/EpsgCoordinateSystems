using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wisconsin_South_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2289;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wisconsin South";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Wisconsin South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44.06666666666667],PARAMETER[standard_parallel_2,42.73333333333333],PARAMETER[latitude_of_origin,42],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2289],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Wisconsin South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,44.06666666666667],PARAMETER[standard_parallel_2,42.73333333333333],PARAMETER[latitude_of_origin,42],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-87.819845, 42.8415678181818, 0),
                    new Vector(-87.836432, 42.9645888181819, 0),
                    new Vector(-87.89198, 43.0257708181819, 0),
                    new Vector(-87.86007499999999, 43.0758738181819, 0),
                    new Vector(-87.8898379999999, 43.1972208181819, 0),
                    new Vector(-87.8753389999999, 43.3585908181819, 0),
                    new Vector(-87.802961, 43.4587158181819, 0),
                    new Vector(-87.7860409999999, 43.5463038181818, 0),
                    new Vector(-87.70272799999999, 43.6731768181817, 0),
                    new Vector(-87.726119, 43.8939018181819, 0),
                    new Vector(-87.644372, 44.097823818182, 0),
                    new Vector(-87.517319, 44.1757548181818, 0),
                    new Vector(-87.5374879999999, 44.3278548181818, 0),
                    new Vector(-87.76329800000001, 44.3278098181818, 0),
                    new Vector(-87.878957, 44.3265228181819, 0),
                    new Vector(-87.882863, 44.2426878181819, 0),
                    new Vector(-88.038599, 44.2403928181819, 0),
                    new Vector(-88.185254, 44.2446588181819, 0),
                    new Vector(-88.39904, 44.2420398181819, 0),
                    new Vector(-88.732022, 44.2448298181818, 0),
                    new Vector(-88.880675, 44.2437858181819, 0),
                    new Vector(-89.215592, 44.244910818182, 0),
                    new Vector(-89.5938979999999, 44.2447218181818, 0),
                    new Vector(-89.722139, 44.2477638181817, 0),
                    new Vector(-89.88611, 44.2492038181819, 0),
                    new Vector(-90.310433, 44.2532178181818, 0),
                    new Vector(-90.31187300000001, 44.1593298181818, 0),
                    new Vector(-90.903227, 44.1612378181818, 0),
                    new Vector(-90.94253, 44.1516888181819, 0),
                    new Vector(-90.968918, 44.1345438181819, 0),
                    new Vector(-90.973337, 44.0738928181818, 0),
                    new Vector(-91.148414, 44.0763948181819, 0),
                    new Vector(-91.181849, 44.0891838181819, 0),
                    new Vector(-91.22562499999998, 44.0585478181819, 0),
                    new Vector(-91.264118, 44.0707968181818, 0),
                    new Vector(-91.302764, 44.0643528181819, 0),
                    new Vector(-91.33540699999999, 44.0474958181819, 0),
                    new Vector(-91.346468, 44.0332308181818, 0),
                    new Vector(-91.330619, 43.9878798181819, 0),
                    new Vector(-91.42590199999989, 43.9856208181818, 0),
                    new Vector(-91.37335100000001, 43.9471908181818, 0),
                    new Vector(-91.291946, 43.8471918181819, 0),
                    new Vector(-91.251113, 43.788070818182, 0),
                    new Vector(-91.258916, 43.7223888181818, 0),
                    new Vector(-91.258394, 43.6773168181818, 0),
                    new Vector(-91.23298699999989, 43.5988908181819, 0),
                    new Vector(-91.24055599999988, 43.5487068181818, 0),
                    new Vector(-91.223564, 43.500808818182, 0),
                    new Vector(-91.23590299999999, 43.4646828181818, 0),
                    new Vector(-91.21091900000002, 43.424056818182, 0),
                    new Vector(-91.19824699999998, 43.3705068181818, 0),
                    new Vector(-91.177043, 43.3539468181819, 0),
                    new Vector(-91.078502, 43.3133028181818, 0),
                    new Vector(-91.0664239999999, 43.2806778181817, 0),
                    new Vector(-91.069052, 43.2578988181819, 0),
                    new Vector(-91.161356, 43.1475768181818, 0),
                    new Vector(-91.16857400000001, 43.0828938181819, 0),
                    new Vector(-91.15975400000002, 43.0811838181818, 0),
                    new Vector(-91.152221, 43.0013178181819, 0),
                    new Vector(-91.1391169999999, 42.9258888181819, 0),
                    new Vector(-91.0934239999999, 42.8714388181819, 0),
                    new Vector(-91.08203, 42.783364818182, 0),
                    new Vector(-91.06617199999999, 42.7449168181819, 0),
                    new Vector(-90.99918499999998, 42.7070538181819, 0),
                    new Vector(-90.91940899999999, 42.6806838181819, 0),
                    new Vector(-90.892544, 42.6782358181819, 0),
                    new Vector(-90.74561, 42.6569958181818, 0),
                    new Vector(-90.69478700000001, 42.6379248181819, 0),
                    new Vector(-90.664385, 42.571387818182, 0),
                    new Vector(-90.63922100000001, 42.5557188181819, 0),
                    new Vector(-90.62571199999999, 42.528565818182, 0),
                    new Vector(-90.63845600000001, 42.5093598181818, 0),
                    new Vector(-90.420098, 42.5083608181819, 0),
                    new Vector(-89.923694, 42.5041218181818, 0),
                    new Vector(-89.834738, 42.5034738181819, 0),
                    new Vector(-89.4006049999999, 42.497497818182, 0),
                    new Vector(-89.359565, 42.4979208181818, 0),
                    new Vector(-88.939193, 42.4908828181819, 0),
                    new Vector(-88.765052, 42.4909188181819, 0),
                    new Vector(-88.70662400000001, 42.4896768181818, 0),
                    new Vector(-88.297988, 42.4919898181819, 0),
                    new Vector(-88.194794, 42.4896228181819, 0),
                    new Vector(-87.797381, 42.4891548181819, 0),
                    new Vector(-87.79151299999999, 42.6666438181818, 0),
                    new Vector(-87.7567999999999, 42.7775418181819, 0),
                    new Vector(-87.819845, 42.8415678181818, 0)
                })
            }
        };
    }
}