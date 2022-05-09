using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Minnesota_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 26851;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Minnesota South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Minnesota South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,45.21666666666667],PARAMETER[standard_parallel_2,43.78333333333333],PARAMETER[latitude_of_origin,43],PARAMETER[central_meridian,-94],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,26851],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Minnesota South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,45.21666666666667],PARAMETER[standard_parallel_2,43.78333333333333],PARAMETER[latitude_of_origin,43],PARAMETER[central_meridian,-94],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(43.5006288181818, -91.611104),
                    new Vector(43.500808818182, -91.223564),
                    new Vector(43.5487068181818, -91.24055599999988),
                    new Vector(43.5988908181819, -91.23298699999989),
                    new Vector(43.6773168181818, -91.258394),
                    new Vector(43.7223888181818, -91.258916),
                    new Vector(43.788070818182, -91.251113),
                    new Vector(43.8471918181819, -91.291946),
                    new Vector(43.9471908181818, -91.37335100000001),
                    new Vector(43.9856208181818, -91.42590199999989),
                    new Vector(44.0342208181818, -91.52842099999999),
                    new Vector(44.034958818182, -91.569164),
                    new Vector(44.0408178181818, -91.60178000000001),
                    new Vector(44.0668908181819, -91.65223400000001),
                    new Vector(44.1372258181819, -91.753214),
                    new Vector(44.1911898181818, -91.848749),
                    new Vector(44.2574928181819, -91.88869099999999),
                    new Vector(44.2883448181819, -91.922342),
                    new Vector(44.3175138181819, -91.92275600000001),
                    new Vector(44.3391048181819, -91.93886599999999),
                    new Vector(44.3644938181818, -91.9723819999999),
                    new Vector(44.4155868181819, -92.09133500000002),
                    new Vector(44.4383928181819, -92.20613899999999),
                    new Vector(44.4562218181817, -92.24909599999999),
                    new Vector(44.4921858181818, -92.296688),
                    new Vector(44.5404888181819, -92.32048399999989),
                    new Vector(44.552836818182, -92.340869),
                    new Vector(44.5751658181819, -92.50921399999999),
                    new Vector(44.6102928181818, -92.60897),
                    new Vector(44.6426568181819, -92.630363),
                    new Vector(44.7135948181819, -92.737148),
                    new Vector(44.7461658181818, -92.805584),
                    new Vector(44.8353738181819, -92.76102500000002),
                    new Vector(44.8622388181818, -92.76426499999998),
                    new Vector(44.8994988181819, -92.77187000000001),
                    new Vector(44.9149968181818, -92.7539239999999),
                    new Vector(44.9356518181818, -92.74976599999999),
                    new Vector(45.00100981818199, -92.767127),
                    new Vector(45.0221148181819, -92.762987),
                    new Vector(45.06561181818191, -92.796764),
                    new Vector(45.11299681818201, -92.7454189999999),
                    new Vector(45.1564218181817, -92.744933),
                    new Vector(45.1866078181818, -92.7625819999999),
                    new Vector(45.212374818182, -92.75541799999999),
                    new Vector(45.2975958181819, -92.746589),
                    new Vector(45.2985408181819, -93.01898300000001),
                    new Vector(45.41228281818191, -93.023015),
                    new Vector(45.4136688181818, -93.513569),
                    new Vector(45.5585778181817, -93.51706999999999),
                    new Vector(45.5616558181819, -93.760808),
                    new Vector(45.5584428181818, -94.14940999999999),
                    new Vector(45.5195898181819, -94.147997),
                    new Vector(45.4862358181817, -94.13331800000002),
                    new Vector(45.4314078181819, -94.050212),
                    new Vector(45.3498498181818, -94.094663),
                    new Vector(45.3292038181818, -94.1230939999999),
                    new Vector(45.3044088181819, -94.165511),
                    new Vector(45.322156818182, -94.19465300000002),
                    new Vector(45.3109608181818, -94.25291899999999),
                    new Vector(45.28458181818179, -94.26142400000001),
                    new Vector(45.2846358181818, -94.374959),
                    new Vector(45.3270438181818, -94.3786939999999),
                    new Vector(45.32529781818181, -94.76548699999999),
                    new Vector(45.4136238181818, -94.765298),
                    new Vector(45.4115538181818, -95.13379400000001),
                    new Vector(45.4093848181819, -95.261054),
                    new Vector(45.41254381818181, -95.74523600000001),
                    new Vector(45.4100148181818, -96.124289),
                    new Vector(45.4118328181819, -96.24485300000001),
                    new Vector(45.5858928181819, -96.246167),
                    new Vector(45.58716181818189, -96.257381),
                    new Vector(45.5840928181818, -96.8430919999999),
                    new Vector(45.51748381818189, -96.76924699999989),
                    new Vector(45.4581918181818, -96.738035),
                    new Vector(45.4106358181818, -96.69316999999999),
                    new Vector(45.3965238181818, -96.60507800000001),
                    new Vector(45.3751398181819, -96.53254700000001),
                    new Vector(45.3285108181819, -96.47759299999998),
                    new Vector(45.2988558181819, -96.457604),
                    new Vector(45.2751948181819, -96.454499),
                    new Vector(44.9719938181819, -96.45608300000001),
                    new Vector(44.8013448181819, -96.455219),
                    new Vector(44.6288058181818, -96.456722),
                    new Vector(44.5383468181819, -96.45511099999999),
                    new Vector(44.1990648181819, -96.45739700000001),
                    new Vector(43.8487488181819, -96.456596),
                    new Vector(43.4997198181819, -96.46045699999999),
                    new Vector(43.4985408181819, -96.061037),
                    new Vector(43.4989458181818, -95.86690700000001),
                    new Vector(43.4995488181818, -95.464769),
                    new Vector(43.5003408181818, -95.396558),
                    new Vector(43.4993688181818, -94.920467),
                    new Vector(43.5000258181818, -94.85983399999999),
                    new Vector(43.4980998181818, -94.45523900000001),
                    new Vector(43.4989458181818, -94.24678999999999),
                    new Vector(43.5002958181818, -93.973955),
                    new Vector(43.5007638181818, -93.65369900000002),
                    new Vector(43.5004938181818, -93.50082500000001),
                    new Vector(43.501456818182, -93.05437999999999),
                    new Vector(43.5012858181818, -93.027209),
                    new Vector(43.5002598181819, -92.55801200000001),
                    new Vector(43.4994678181819, -92.4531709999999),
                    new Vector(43.4991528181819, -92.077538),
                    new Vector(43.4995758181819, -91.730363),
                    new Vector(43.5006288181818, -91.611104)
                })
            }
        };
    }
}