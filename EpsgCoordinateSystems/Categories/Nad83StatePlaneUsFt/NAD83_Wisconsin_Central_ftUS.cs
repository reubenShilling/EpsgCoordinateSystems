using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Wisconsin_Central_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2288;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wisconsin Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Wisconsin Central (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",45.5],PARAMETER[\"standard_parallel_2\",44.25],PARAMETER[\"latitude_of_origin\",43.83333333333334],PARAMETER[\"central_meridian\",-90],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2288\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Wisconsin Central (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",45.5],PARAMETER[\"standard_parallel_2\",44.25],PARAMETER[\"latitude_of_origin\",43.83333333333334],PARAMETER[\"central_meridian\",-90],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.2492038181819, -89.88611),
                    new Vector(44.2477638181817, -89.722139),
                    new Vector(44.2447218181818, -89.5938979999999),
                    new Vector(44.244910818182, -89.215592),
                    new Vector(44.2437858181819, -88.880675),
                    new Vector(44.2448298181818, -88.732022),
                    new Vector(44.2420398181819, -88.39904),
                    new Vector(44.2446588181819, -88.185254),
                    new Vector(44.2403928181819, -88.038599),
                    new Vector(44.2426878181819, -87.882863),
                    new Vector(44.3265228181819, -87.878957),
                    new Vector(44.3278098181818, -87.76329800000001),
                    new Vector(44.3278548181818, -87.5374879999999),
                    new Vector(44.5339458181819, -87.473525),
                    new Vector(44.6769198181818, -87.373076),
                    new Vector(44.7947208181818, -87.31446800000001),
                    new Vector(44.8115598181819, -87.36745999999999),
                    new Vector(44.8911018181818, -87.433745),
                    new Vector(44.8230258181819, -87.551672),
                    new Vector(44.8513398181819, -87.55278800000001),
                    new Vector(44.8330428181818, -87.614465),
                    new Vector(44.6892948181819, -87.723815),
                    new Vector(44.6440428181818, -87.764225),
                    new Vector(44.6169078181819, -87.86877800000001),
                    new Vector(44.5391388181819, -87.926405),
                    new Vector(44.535502818182, -87.96623),
                    new Vector(44.5714488181818, -88.04041700000001),
                    new Vector(44.6222358181818, -88.0130209999999),
                    new Vector(44.5958208181818, -87.975752),
                    new Vector(44.6391198181818, -88.013291),
                    new Vector(44.6772618181819, -87.983186),
                    new Vector(44.7204708181819, -87.985787),
                    new Vector(44.8733448181819, -87.8310139999999),
                    new Vector(44.9273268181819, -87.83998699999999),
                    new Vector(44.9616168181818, -87.74855599999989),
                    new Vector(44.9920008181819, -87.620333),
                    new Vector(45.0568098181819, -87.618515),
                    new Vector(45.09463681818179, -87.581273),
                    new Vector(45.1090548181818, -87.664883),
                    new Vector(45.1406718181819, -87.672821),
                    new Vector(45.1765998181819, -87.729674),
                    new Vector(45.1990728181818, -87.736199),
                    new Vector(45.2116728181818, -87.721628),
                    new Vector(45.2367738181819, -87.719666),
                    new Vector(45.2470788181819, -87.70514900000001),
                    new Vector(45.2722068181818, -87.704474),
                    new Vector(45.34817581818191, -87.64536200000001),
                    new Vector(45.3618558181818, -87.64367900000001),
                    new Vector(45.3912768181818, -87.68959700000001),
                    new Vector(45.35290081818181, -87.76004),
                    new Vector(45.3583188181819, -87.828008),
                    new Vector(45.3461418181819, -87.841283),
                    new Vector(45.3701628181819, -87.8620999999999),
                    new Vector(45.3720708181818, -87.86853499999999),
                    new Vector(45.3620808181818, -87.873971),
                    new Vector(45.3658518181819, -87.88361),
                    new Vector(45.40611781818189, -87.849536),
                    new Vector(45.4450968181819, -87.860264),
                    new Vector(45.4664628181819, -87.81361699999999),
                    new Vector(45.4990608181819, -87.78937999999989),
                    new Vector(45.5445288181818, -87.805148),
                    new Vector(45.5685948181819, -87.828602),
                    new Vector(45.5685138181819, -87.786311),
                    new Vector(45.60039181818179, -87.77507),
                    new Vector(45.6131988181819, -87.776042),
                    new Vector(45.6544548181818, -87.819935),
                    new Vector(45.66538981818191, -87.817055),
                    new Vector(45.6759198181818, -87.7809469999999),
                    new Vector(45.68410081818191, -87.777473),
                    new Vector(45.70132681818189, -87.801152),
                    new Vector(45.7113888181818, -87.801557),
                    new Vector(45.72241381818179, -87.84236300000001),
                    new Vector(45.75070081818179, -87.87362899999989),
                    new Vector(45.76644181818179, -87.969182),
                    new Vector(45.7950438181819, -87.990071),
                    new Vector(45.7861068181817, -88.05164000000001),
                    new Vector(45.715258818182, -88.055789),
                    new Vector(45.7213518181819, -88.41498799999989),
                    new Vector(45.3757968181819, -88.4225299999999),
                    new Vector(45.3784608181819, -88.669679),
                    new Vector(45.3829608181819, -88.91942899999999),
                    new Vector(45.4638528181818, -88.919375),
                    new Vector(45.4679838181818, -89.0421259999999),
                    new Vector(45.4700988181819, -89.4202159999999),
                    new Vector(45.5569488181818, -89.42142200000001),
                    new Vector(45.5545188181818, -90.04134200000001),
                    new Vector(45.3840408181819, -90.043205),
                    new Vector(45.37955881818181, -90.675752),
                    new Vector(45.63689581818189, -90.677048),
                    new Vector(45.6408018181819, -91.540913),
                    new Vector(45.6402438181819, -92.03344700000001),
                    new Vector(45.6383178181819, -92.15781799999999),
                    new Vector(45.72431281818181, -92.158646),
                    new Vector(45.7279488181819, -92.53004900000001),
                    new Vector(45.6449778181819, -92.537357),
                    new Vector(45.6449508181818, -92.885396),
                    new Vector(45.5788368181818, -92.876828),
                    new Vector(45.5634018181819, -92.835032),
                    new Vector(45.5642658181818, -92.76217699999998),
                    new Vector(45.5472468181818, -92.72815699999998),
                    new Vector(45.4700538181819, -92.68541600000002),
                    new Vector(45.4552218181819, -92.654816),
                    new Vector(45.4394538181818, -92.64497),
                    new Vector(45.39546181818189, -92.6487589999999),
                    new Vector(45.3630708181818, -92.684876),
                    new Vector(45.31819681818191, -92.707385),
                    new Vector(45.2975958181819, -92.746589),
                    new Vector(45.212374818182, -92.75541799999999),
                    new Vector(45.1866078181818, -92.7625819999999),
                    new Vector(45.1564218181817, -92.744933),
                    new Vector(45.11299681818201, -92.7454189999999),
                    new Vector(45.06561181818191, -92.796764),
                    new Vector(45.0221148181819, -92.762987),
                    new Vector(45.00100981818199, -92.767127),
                    new Vector(44.9356518181818, -92.74976599999999),
                    new Vector(44.9149968181818, -92.7539239999999),
                    new Vector(44.8994988181819, -92.77187000000001),
                    new Vector(44.8622388181818, -92.76426499999998),
                    new Vector(44.8353738181819, -92.76102500000002),
                    new Vector(44.7461658181818, -92.805584),
                    new Vector(44.7135948181819, -92.737148),
                    new Vector(44.6426568181819, -92.630363),
                    new Vector(44.6102928181818, -92.60897),
                    new Vector(44.5751658181819, -92.50921399999999),
                    new Vector(44.552836818182, -92.340869),
                    new Vector(44.5404888181819, -92.32048399999989),
                    new Vector(44.4921858181818, -92.296688),
                    new Vector(44.4562218181817, -92.24909599999999),
                    new Vector(44.4383928181819, -92.20613899999999),
                    new Vector(44.4155868181819, -92.09133500000002),
                    new Vector(44.3644938181818, -91.9723819999999),
                    new Vector(44.3391048181819, -91.93886599999999),
                    new Vector(44.3175138181819, -91.92275600000001),
                    new Vector(44.2883448181819, -91.922342),
                    new Vector(44.2574928181819, -91.88869099999999),
                    new Vector(44.1911898181818, -91.848749),
                    new Vector(44.1372258181819, -91.753214),
                    new Vector(44.0668908181819, -91.65223400000001),
                    new Vector(44.0408178181818, -91.60178000000001),
                    new Vector(44.034958818182, -91.569164),
                    new Vector(44.0342208181818, -91.52842099999999),
                    new Vector(43.9856208181818, -91.42590199999989),
                    new Vector(43.9878798181819, -91.330619),
                    new Vector(44.0332308181818, -91.346468),
                    new Vector(44.0474958181819, -91.33540699999999),
                    new Vector(44.0643528181819, -91.302764),
                    new Vector(44.0707968181818, -91.264118),
                    new Vector(44.0585478181819, -91.22562499999998),
                    new Vector(44.0891838181819, -91.181849),
                    new Vector(44.0763948181819, -91.148414),
                    new Vector(44.0738928181818, -90.973337),
                    new Vector(44.1345438181819, -90.968918),
                    new Vector(44.1516888181819, -90.94253),
                    new Vector(44.1612378181818, -90.903227),
                    new Vector(44.1593298181818, -90.31187300000001),
                    new Vector(44.2532178181818, -90.310433),
                    new Vector(44.2492038181819, -89.88611)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(45.2904048181819, -87.03452299999999),
                    new Vector(45.2964618181819, -87.066068),
                    new Vector(45.1549728181819, -87.17791099999999),
                    new Vector(45.1750608181819, -87.230921),
                    new Vector(45.0526158181818, -87.28348099999999),
                    new Vector(45.01521181818179, -87.342161),
                    new Vector(44.9111988181818, -87.405422),
                    new Vector(44.8377498181819, -87.378737),
                    new Vector(44.7987708181819, -87.31112899999989),
                    new Vector(44.8732368181818, -87.205658),
                    new Vector(44.9333298181819, -87.16879400000001),
                    new Vector(44.9828118181819, -87.17869399999999),
                    new Vector(45.0647658181819, -87.11255300000001),
                    new Vector(45.0532818181819, -87.08389699999999),
                    new Vector(45.0921798181819, -87.08768600000001),
                    new Vector(45.0955098181819, -87.0448999999999),
                    new Vector(45.1473048181819, -87.079874),
                    new Vector(45.1499688181818, -87.025442),
                    new Vector(45.2490138181818, -87.045107),
                    new Vector(45.2184048181819, -86.995733),
                    new Vector(45.2402838181819, -86.967707),
                    new Vector(45.2986578181819, -86.986256),
                    new Vector(45.2904048181819, -87.03452299999999)
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