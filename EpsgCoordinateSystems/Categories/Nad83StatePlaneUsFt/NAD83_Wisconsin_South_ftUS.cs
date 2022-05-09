using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Wisconsin_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2289;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wisconsin South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Wisconsin South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",44.06666666666667],PARAMETER[\"standard_parallel_2\",42.73333333333333],PARAMETER[\"latitude_of_origin\",42],PARAMETER[\"central_meridian\",-90],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2289\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Wisconsin South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",44.06666666666667],PARAMETER[\"standard_parallel_2\",42.73333333333333],PARAMETER[\"latitude_of_origin\",42],PARAMETER[\"central_meridian\",-90],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.8415678181818, -87.819845),
                    new Vector(42.9645888181819, -87.836432),
                    new Vector(43.0257708181819, -87.89198),
                    new Vector(43.0758738181819, -87.86007499999999),
                    new Vector(43.1972208181819, -87.8898379999999),
                    new Vector(43.3585908181819, -87.8753389999999),
                    new Vector(43.4587158181819, -87.802961),
                    new Vector(43.5463038181818, -87.7860409999999),
                    new Vector(43.6731768181817, -87.70272799999999),
                    new Vector(43.8939018181819, -87.726119),
                    new Vector(44.097823818182, -87.644372),
                    new Vector(44.1757548181818, -87.517319),
                    new Vector(44.3278548181818, -87.5374879999999),
                    new Vector(44.3278098181818, -87.76329800000001),
                    new Vector(44.3265228181819, -87.878957),
                    new Vector(44.2426878181819, -87.882863),
                    new Vector(44.2403928181819, -88.038599),
                    new Vector(44.2446588181819, -88.185254),
                    new Vector(44.2420398181819, -88.39904),
                    new Vector(44.2448298181818, -88.732022),
                    new Vector(44.2437858181819, -88.880675),
                    new Vector(44.244910818182, -89.215592),
                    new Vector(44.2447218181818, -89.5938979999999),
                    new Vector(44.2477638181817, -89.722139),
                    new Vector(44.2492038181819, -89.88611),
                    new Vector(44.2532178181818, -90.310433),
                    new Vector(44.1593298181818, -90.31187300000001),
                    new Vector(44.1612378181818, -90.903227),
                    new Vector(44.1516888181819, -90.94253),
                    new Vector(44.1345438181819, -90.968918),
                    new Vector(44.0738928181818, -90.973337),
                    new Vector(44.0763948181819, -91.148414),
                    new Vector(44.0891838181819, -91.181849),
                    new Vector(44.0585478181819, -91.22562499999998),
                    new Vector(44.0707968181818, -91.264118),
                    new Vector(44.0643528181819, -91.302764),
                    new Vector(44.0474958181819, -91.33540699999999),
                    new Vector(44.0332308181818, -91.346468),
                    new Vector(43.9878798181819, -91.330619),
                    new Vector(43.9856208181818, -91.42590199999989),
                    new Vector(43.9471908181818, -91.37335100000001),
                    new Vector(43.8471918181819, -91.291946),
                    new Vector(43.788070818182, -91.251113),
                    new Vector(43.7223888181818, -91.258916),
                    new Vector(43.6773168181818, -91.258394),
                    new Vector(43.5988908181819, -91.23298699999989),
                    new Vector(43.5487068181818, -91.24055599999988),
                    new Vector(43.500808818182, -91.223564),
                    new Vector(43.4646828181818, -91.23590299999999),
                    new Vector(43.424056818182, -91.21091900000002),
                    new Vector(43.3705068181818, -91.19824699999998),
                    new Vector(43.3539468181819, -91.177043),
                    new Vector(43.3133028181818, -91.078502),
                    new Vector(43.2806778181817, -91.0664239999999),
                    new Vector(43.2578988181819, -91.069052),
                    new Vector(43.1475768181818, -91.161356),
                    new Vector(43.0828938181819, -91.16857400000001),
                    new Vector(43.0811838181818, -91.15975400000002),
                    new Vector(43.0013178181819, -91.152221),
                    new Vector(42.9258888181819, -91.1391169999999),
                    new Vector(42.8714388181819, -91.0934239999999),
                    new Vector(42.783364818182, -91.08203),
                    new Vector(42.7449168181819, -91.06617199999999),
                    new Vector(42.7070538181819, -90.99918499999998),
                    new Vector(42.6806838181819, -90.91940899999999),
                    new Vector(42.6782358181819, -90.892544),
                    new Vector(42.6569958181818, -90.74561),
                    new Vector(42.6379248181819, -90.69478700000001),
                    new Vector(42.571387818182, -90.664385),
                    new Vector(42.5557188181819, -90.63922100000001),
                    new Vector(42.528565818182, -90.62571199999999),
                    new Vector(42.5093598181818, -90.63845600000001),
                    new Vector(42.5083608181819, -90.420098),
                    new Vector(42.5041218181818, -89.923694),
                    new Vector(42.5034738181819, -89.834738),
                    new Vector(42.497497818182, -89.4006049999999),
                    new Vector(42.4979208181818, -89.359565),
                    new Vector(42.4908828181819, -88.939193),
                    new Vector(42.4909188181819, -88.765052),
                    new Vector(42.4896768181818, -88.70662400000001),
                    new Vector(42.4919898181819, -88.297988),
                    new Vector(42.4896228181819, -88.194794),
                    new Vector(42.4891548181819, -87.797381),
                    new Vector(42.6666438181818, -87.79151299999999),
                    new Vector(42.7775418181819, -87.7567999999999),
                    new Vector(42.8415678181818, -87.819845)
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