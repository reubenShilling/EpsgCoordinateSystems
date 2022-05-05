using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
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
                    new Vector(-91.611104, 43.5006288181818, 0),
                    new Vector(-91.223564, 43.500808818182, 0),
                    new Vector(-91.24055599999988, 43.5487068181818, 0),
                    new Vector(-91.23298699999989, 43.5988908181819, 0),
                    new Vector(-91.258394, 43.6773168181818, 0),
                    new Vector(-91.258916, 43.7223888181818, 0),
                    new Vector(-91.251113, 43.788070818182, 0),
                    new Vector(-91.291946, 43.8471918181819, 0),
                    new Vector(-91.37335100000001, 43.9471908181818, 0),
                    new Vector(-91.42590199999989, 43.9856208181818, 0),
                    new Vector(-91.52842099999999, 44.0342208181818, 0),
                    new Vector(-91.569164, 44.034958818182, 0),
                    new Vector(-91.60178000000001, 44.0408178181818, 0),
                    new Vector(-91.65223400000001, 44.0668908181819, 0),
                    new Vector(-91.753214, 44.1372258181819, 0),
                    new Vector(-91.848749, 44.1911898181818, 0),
                    new Vector(-91.88869099999999, 44.2574928181819, 0),
                    new Vector(-91.922342, 44.2883448181819, 0),
                    new Vector(-91.92275600000001, 44.3175138181819, 0),
                    new Vector(-91.93886599999999, 44.3391048181819, 0),
                    new Vector(-91.9723819999999, 44.3644938181818, 0),
                    new Vector(-92.09133500000002, 44.4155868181819, 0),
                    new Vector(-92.20613899999999, 44.4383928181819, 0),
                    new Vector(-92.24909599999999, 44.4562218181817, 0),
                    new Vector(-92.296688, 44.4921858181818, 0),
                    new Vector(-92.32048399999989, 44.5404888181819, 0),
                    new Vector(-92.340869, 44.552836818182, 0),
                    new Vector(-92.50921399999999, 44.5751658181819, 0),
                    new Vector(-92.60897, 44.6102928181818, 0),
                    new Vector(-92.630363, 44.6426568181819, 0),
                    new Vector(-92.737148, 44.7135948181819, 0),
                    new Vector(-92.805584, 44.7461658181818, 0),
                    new Vector(-92.76102500000002, 44.8353738181819, 0),
                    new Vector(-92.76426499999998, 44.8622388181818, 0),
                    new Vector(-92.77187000000001, 44.8994988181819, 0),
                    new Vector(-92.7539239999999, 44.9149968181818, 0),
                    new Vector(-92.74976599999999, 44.9356518181818, 0),
                    new Vector(-92.767127, 45.00100981818199, 0),
                    new Vector(-92.762987, 45.0221148181819, 0),
                    new Vector(-92.796764, 45.06561181818191, 0),
                    new Vector(-92.7454189999999, 45.11299681818201, 0),
                    new Vector(-92.744933, 45.1564218181817, 0),
                    new Vector(-92.7625819999999, 45.1866078181818, 0),
                    new Vector(-92.75541799999999, 45.212374818182, 0),
                    new Vector(-92.746589, 45.2975958181819, 0),
                    new Vector(-93.01898300000001, 45.2985408181819, 0),
                    new Vector(-93.023015, 45.41228281818191, 0),
                    new Vector(-93.513569, 45.4136688181818, 0),
                    new Vector(-93.51706999999999, 45.5585778181817, 0),
                    new Vector(-93.760808, 45.5616558181819, 0),
                    new Vector(-94.14940999999999, 45.5584428181818, 0),
                    new Vector(-94.147997, 45.5195898181819, 0),
                    new Vector(-94.13331800000002, 45.4862358181817, 0),
                    new Vector(-94.050212, 45.4314078181819, 0),
                    new Vector(-94.094663, 45.3498498181818, 0),
                    new Vector(-94.1230939999999, 45.3292038181818, 0),
                    new Vector(-94.165511, 45.3044088181819, 0),
                    new Vector(-94.19465300000002, 45.322156818182, 0),
                    new Vector(-94.25291899999999, 45.3109608181818, 0),
                    new Vector(-94.26142400000001, 45.28458181818179, 0),
                    new Vector(-94.374959, 45.2846358181818, 0),
                    new Vector(-94.3786939999999, 45.3270438181818, 0),
                    new Vector(-94.76548699999999, 45.32529781818181, 0),
                    new Vector(-94.765298, 45.4136238181818, 0),
                    new Vector(-95.13379400000001, 45.4115538181818, 0),
                    new Vector(-95.261054, 45.4093848181819, 0),
                    new Vector(-95.74523600000001, 45.41254381818181, 0),
                    new Vector(-96.124289, 45.4100148181818, 0),
                    new Vector(-96.24485300000001, 45.4118328181819, 0),
                    new Vector(-96.246167, 45.5858928181819, 0),
                    new Vector(-96.257381, 45.58716181818189, 0),
                    new Vector(-96.8430919999999, 45.5840928181818, 0),
                    new Vector(-96.76924699999989, 45.51748381818189, 0),
                    new Vector(-96.738035, 45.4581918181818, 0),
                    new Vector(-96.69316999999999, 45.4106358181818, 0),
                    new Vector(-96.60507800000001, 45.3965238181818, 0),
                    new Vector(-96.53254700000001, 45.3751398181819, 0),
                    new Vector(-96.47759299999998, 45.3285108181819, 0),
                    new Vector(-96.457604, 45.2988558181819, 0),
                    new Vector(-96.454499, 45.2751948181819, 0),
                    new Vector(-96.45608300000001, 44.9719938181819, 0),
                    new Vector(-96.455219, 44.8013448181819, 0),
                    new Vector(-96.456722, 44.6288058181818, 0),
                    new Vector(-96.45511099999999, 44.5383468181819, 0),
                    new Vector(-96.45739700000001, 44.1990648181819, 0),
                    new Vector(-96.456596, 43.8487488181819, 0),
                    new Vector(-96.46045699999999, 43.4997198181819, 0),
                    new Vector(-96.061037, 43.4985408181819, 0),
                    new Vector(-95.86690700000001, 43.4989458181818, 0),
                    new Vector(-95.464769, 43.4995488181818, 0),
                    new Vector(-95.396558, 43.5003408181818, 0),
                    new Vector(-94.920467, 43.4993688181818, 0),
                    new Vector(-94.85983399999999, 43.5000258181818, 0),
                    new Vector(-94.45523900000001, 43.4980998181818, 0),
                    new Vector(-94.24678999999999, 43.4989458181818, 0),
                    new Vector(-93.973955, 43.5002958181818, 0),
                    new Vector(-93.65369900000002, 43.5007638181818, 0),
                    new Vector(-93.50082500000001, 43.5004938181818, 0),
                    new Vector(-93.05437999999999, 43.501456818182, 0),
                    new Vector(-93.027209, 43.5012858181818, 0),
                    new Vector(-92.55801200000001, 43.5002598181819, 0),
                    new Vector(-92.4531709999999, 43.4994678181819, 0),
                    new Vector(-92.077538, 43.4991528181819, 0),
                    new Vector(-91.730363, 43.4995758181819, 0),
                    new Vector(-91.611104, 43.5006288181818, 0)
                })
            }
        };
    }
}