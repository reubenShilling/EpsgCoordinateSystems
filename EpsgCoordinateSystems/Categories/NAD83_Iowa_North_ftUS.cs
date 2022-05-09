using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_Iowa_North_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 3417;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Iowa North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Iowa North (ft US),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,43.26666666666667],PARAMETER[standard_parallel_2,42.06666666666667],PARAMETER[latitude_of_origin,41.5],PARAMETER[central_meridian,-93.5],PARAMETER[false_easting,4921250],PARAMETER[false_northing,3280833.333300001],AUTHORITY[EPSG,3417],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Iowa North (ft US),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,43.26666666666667],PARAMETER[standard_parallel_2,42.06666666666667],PARAMETER[latitude_of_origin,41.5],PARAMETER[central_meridian,-93.5],PARAMETER[false_easting,4921250],PARAMETER[false_northing,3280833.333300001],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.9484708181819, -90.900869),
                    new Vector(42.0356898181819, -90.89890699999999),
                    new Vector(42.0334578181818, -90.150665),
                    new Vector(42.0610608181818, -90.168224),
                    new Vector(42.1037658181819, -90.166775),
                    new Vector(42.1205238181819, -90.176216),
                    new Vector(42.1227108181818, -90.19169599999998),
                    new Vector(42.1597458181819, -90.23106199999999),
                    new Vector(42.1973388181819, -90.32372599999999),
                    new Vector(42.2102268181819, -90.3678529999999),
                    new Vector(42.2426628181818, -90.40730000000001),
                    new Vector(42.2639388181818, -90.418109),
                    new Vector(42.3406458181818, -90.42781099999999),
                    new Vector(42.3600858181818, -90.44172500000001),
                    new Vector(42.3887868181819, -90.49117099999999),
                    new Vector(42.4218438181819, -90.56371100000001),
                    new Vector(42.4605618181819, -90.60595700000002),
                    new Vector(42.4756458181819, -90.6484729999999),
                    new Vector(42.4946988181818, -90.65190200000001),
                    new Vector(42.5093598181818, -90.63845600000001),
                    new Vector(42.528565818182, -90.62571199999999),
                    new Vector(42.5557188181819, -90.63922100000001),
                    new Vector(42.571387818182, -90.664385),
                    new Vector(42.6379248181819, -90.69478700000001),
                    new Vector(42.6569958181818, -90.74561),
                    new Vector(42.6782358181819, -90.892544),
                    new Vector(42.6806838181819, -90.91940899999999),
                    new Vector(42.7070538181819, -90.99918499999998),
                    new Vector(42.7449168181819, -91.06617199999999),
                    new Vector(42.783364818182, -91.08203),
                    new Vector(42.8714388181819, -91.0934239999999),
                    new Vector(42.9258888181819, -91.1391169999999),
                    new Vector(43.0013178181819, -91.152221),
                    new Vector(43.0811838181818, -91.15975400000002),
                    new Vector(43.0828938181819, -91.16857400000001),
                    new Vector(43.1475768181818, -91.161356),
                    new Vector(43.2578988181819, -91.069052),
                    new Vector(43.2806778181817, -91.0664239999999),
                    new Vector(43.3133028181818, -91.078502),
                    new Vector(43.3539468181819, -91.177043),
                    new Vector(43.3705068181818, -91.19824699999998),
                    new Vector(43.424056818182, -91.21091900000002),
                    new Vector(43.4646828181818, -91.23590299999999),
                    new Vector(43.500808818182, -91.223564),
                    new Vector(43.5006288181818, -91.611104),
                    new Vector(43.4995758181819, -91.730363),
                    new Vector(43.4991528181819, -92.077538),
                    new Vector(43.4994678181819, -92.4531709999999),
                    new Vector(43.5002598181819, -92.55801200000001),
                    new Vector(43.5012858181818, -93.027209),
                    new Vector(43.501456818182, -93.05437999999999),
                    new Vector(43.5004938181818, -93.50082500000001),
                    new Vector(43.5007638181818, -93.65369900000002),
                    new Vector(43.5002958181818, -93.973955),
                    new Vector(43.4989458181818, -94.24678999999999),
                    new Vector(43.4980998181818, -94.45523900000001),
                    new Vector(43.5000258181818, -94.85983399999999),
                    new Vector(43.4993688181818, -94.920467),
                    new Vector(43.5003408181818, -95.396558),
                    new Vector(43.4995488181818, -95.464769),
                    new Vector(43.4989458181818, -95.86690700000001),
                    new Vector(43.4985408181819, -96.061037),
                    new Vector(43.4997198181819, -96.46045699999999),
                    new Vector(43.4998458181819, -96.59831899999999),
                    new Vector(43.481917818182, -96.58380200000001),
                    new Vector(43.4355408181818, -96.589112),
                    new Vector(43.400728818182, -96.55771099999991),
                    new Vector(43.3842228181819, -96.52505899999991),
                    new Vector(43.356961818182, -96.52289),
                    new Vector(43.3076598181819, -96.54056600000001),
                    new Vector(43.2900738181818, -96.579131),
                    new Vector(43.2636048181819, -96.570716),
                    new Vector(43.2532638181819, -96.55956500000001),
                    new Vector(43.2396378181818, -96.56699),
                    new Vector(43.2254898181818, -96.55861099999998),
                    new Vector(43.2179118181818, -96.48724099999988),
                    new Vector(43.2090828181817, -96.47311999999989),
                    new Vector(43.1263098181818, -96.4515109999999),
                    new Vector(43.087870818182, -96.460808),
                    new Vector(43.0755858181819, -96.46209500000002),
                    new Vector(43.0618788181818, -96.479573),
                    new Vector(43.051510818182, -96.52001),
                    new Vector(43.0120548181819, -96.4990219999999),
                    new Vector(42.9864588181819, -96.51714800000001),
                    new Vector(42.9523848181818, -96.5149339999999),
                    new Vector(42.9138648181818, -96.54426499999988),
                    new Vector(42.8969088181818, -96.53750599999999),
                    new Vector(42.8466618181818, -96.55620799999991),
                    new Vector(42.8343498181818, -96.5731279999999),
                    new Vector(42.8353848181818, -96.58764499999999),
                    new Vector(42.7995558181819, -96.600875),
                    new Vector(42.7768398181819, -96.63297799999988),
                    new Vector(42.7485978181818, -96.640709),
                    new Vector(42.7083588181818, -96.62654300000001),
                    new Vector(42.6685068181819, -96.563039),
                    new Vector(42.6624048181819, -96.54116000000002),
                    new Vector(42.6297528181819, -96.5128459999999),
                    new Vector(42.5804778181817, -96.488501),
                    new Vector(42.5738808181818, -96.50094799999989),
                    new Vector(42.5640258181817, -96.48933800000002),
                    new Vector(42.517126818182, -96.480248),
                    new Vector(42.4892358181819, -96.43938799999988),
                    new Vector(42.4674018181819, -96.39607100000002),
                    new Vector(42.4417878181818, -96.39788899999999),
                    new Vector(42.4147788181819, -96.41762599999998),
                    new Vector(42.3809208181819, -96.41176700000001),
                    new Vector(42.3492858181819, -96.42416900000001),
                    new Vector(42.3287928181819, -96.38978),
                    new Vector(42.2980308181819, -96.368702),
                    new Vector(42.2820828181819, -96.34288100000002),
                    new Vector(42.2603118181819, -96.332657),
                    new Vector(42.2295138181819, -96.33770599999998),
                    new Vector(42.2140428181818, -96.36350899999989),
                    new Vector(42.1681788181818, -96.35216),
                    new Vector(42.1234578181818, -96.285128),
                    new Vector(42.0489018181819, -96.26548099999998),
                    new Vector(42.0284358181819, -96.238724),
                    new Vector(42.0012558181818, -96.23608699999998),
                    new Vector(41.996620818182, -96.20284100000001),
                    new Vector(41.9806818181819, -96.185219),
                    new Vector(41.9662548181819, -96.147329),
                    new Vector(41.9249088181818, -96.145871),
                    new Vector(41.9041548181819, -96.15997400000002),
                    new Vector(41.8626198181818, -96.13562899999999),
                    new Vector(41.8612968181819, -95.6771779999999),
                    new Vector(41.8604778181818, -95.5603849999999),
                    new Vector(41.8614048181818, -95.09738),
                    new Vector(41.8600548181818, -94.751591),
                    new Vector(41.8614948181818, -94.63690399999999),
                    new Vector(41.8589658181818, -94.28927899999998),
                    new Vector(41.8579488181819, -94.1682739999999),
                    new Vector(41.8600908181818, -93.81982999999998),
                    new Vector(41.8616748181819, -93.70332500000001),
                    new Vector(41.8631688181819, -93.34996700000001),
                    new Vector(41.8634568181818, -93.23216600000002),
                    new Vector(41.8628358181819, -92.76960200000001),
                    new Vector(41.8602258181818, -92.30148500000001),
                    new Vector(41.8568148181818, -91.83469100000001),
                    new Vector(41.851693818182, -91.369787),
                    new Vector(41.9443218181819, -91.371038),
                    new Vector(41.9484708181819, -90.900869)
                })
            }
        };
    }
}