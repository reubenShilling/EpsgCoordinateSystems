using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Louisiana_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3452;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Louisiana South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Louisiana South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,30.7],PARAMETER[standard_parallel_2,29.3],PARAMETER[latitude_of_origin,28.5],PARAMETER[central_meridian,-91.33333333333333],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3452],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Louisiana South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,30.7],PARAMETER[standard_parallel_2,29.3],PARAMETER[latitude_of_origin,28.5],PARAMETER[central_meridian,-91.33333333333333],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(30.0607308181818, -93.712649),
                    new Vector(30.0061728181819, -93.760367),
                    new Vector(29.8505178181819, -93.791453),
                    new Vector(29.8099818181819, -93.89990299999999),
                    new Vector(29.7258678181818, -93.801821),
                    new Vector(29.7587898181819, -93.721991),
                    new Vector(29.7889938181819, -93.23365100000001),
                    new Vector(29.5886268181818, -92.60743100000001),
                    new Vector(29.5415748181818, -92.29737199999991),
                    new Vector(29.6070138181819, -92.0597539999999),
                    new Vector(29.7631188181819, -92.1997039999999),
                    new Vector(29.7735228181818, -92.130098),
                    new Vector(29.73074581818179, -92.13715400000001),
                    new Vector(29.8060578181819, -91.973327),
                    new Vector(29.8418868181819, -91.96708099999998),
                    new Vector(29.8390428181819, -91.8275),
                    new Vector(29.7868878181819, -91.823936),
                    new Vector(29.8083978181819, -91.846625),
                    new Vector(29.7659538181819, -91.88118500000002),
                    new Vector(29.7258408181819, -91.86325699999999),
                    new Vector(29.76913981818189, -91.61576599999999),
                    new Vector(29.6439678181819, -91.64354899999999),
                    new Vector(29.6421228181817, -91.54849100000001),
                    new Vector(29.5316838181819, -91.547861),
                    new Vector(29.5525818181818, -91.43303),
                    new Vector(29.4895908181819, -91.26272299999991),
                    new Vector(29.4059268181818, -91.2137359999999),
                    new Vector(29.3141358181817, -91.10218999999999),
                    new Vector(29.3600178181818, -91.07838499999998),
                    new Vector(29.3435208181818, -90.936527),
                    new Vector(29.2676598181818, -90.8973409999999),
                    new Vector(29.2567968181818, -90.818555),
                    new Vector(29.2210128181819, -90.814289),
                    new Vector(29.1819078181819, -90.92040799999999),
                    new Vector(29.1374118181818, -90.88263499999988),
                    new Vector(29.182339818182, -90.839381),
                    new Vector(29.1606228181819, -90.77269099999999),
                    new Vector(29.1269448181819, -90.78289700000001),
                    new Vector(29.1402828181818, -90.676787),
                    new Vector(29.1819168181819, -90.68385200000002),
                    new Vector(29.1625758181818, -90.638114),
                    new Vector(29.2542948181819, -90.650057),
                    new Vector(29.2229658181818, -90.62126599999999),
                    new Vector(29.2609278181818, -90.58313299999999),
                    new Vector(29.3050368181819, -90.61108699999988),
                    new Vector(29.3039478181819, -90.4764739999999),
                    new Vector(29.3524488181819, -90.450518),
                    new Vector(29.3259888181819, -90.40682300000002),
                    new Vector(29.2723488181818, -90.396428),
                    new Vector(29.3129568181819, -90.34764800000002),
                    new Vector(29.2455378181817, -90.2840989999999),
                    new Vector(29.2751568181818, -90.27881600000001),
                    new Vector(29.2547448181818, -90.2429149999999),
                    new Vector(29.1846438181818, -90.263957),
                    new Vector(29.0986758181818, -90.227768),
                    new Vector(29.1764448181818, -90.07780099999999),
                    new Vector(29.2236768181818, -90.04310599999999),
                    new Vector(29.2145688181819, -90.077882),
                    new Vector(29.3217228181819, -90.111632),
                    new Vector(29.3088708181819, -90.03299900000002),
                    new Vector(29.3514228181819, -90.0559489999999),
                    new Vector(29.374210818182, -90.029948),
                    new Vector(29.4282828181818, -90.055328),
                    new Vector(29.447155818182, -90.036086),
                    new Vector(29.4959448181818, -90.174137),
                    new Vector(29.5447248181818, -90.20814799999999),
                    new Vector(29.59530481818191, -90.15179000000001),
                    new Vector(29.5338078181818, -90.13729099999999),
                    new Vector(29.5538418181819, -90.11308099999999),
                    new Vector(29.4939378181818, -90.006692),
                    new Vector(29.5035498181819, -89.971925),
                    new Vector(29.4726798181819, -89.96673199999989),
                    new Vector(29.4776298181818, -89.81753),
                    new Vector(29.4209118181819, -89.821742),
                    new Vector(29.3742918181819, -89.753711),
                    new Vector(29.3225328181818, -89.794949),
                    new Vector(29.3317578181818, -89.610719),
                    new Vector(29.2795758181819, -89.61959299999999),
                    new Vector(29.2349898181819, -89.493197),
                    new Vector(29.2557348181819, -89.459114),
                    new Vector(29.2163148181818, -89.46707000000001),
                    new Vector(29.1462678181818, -89.393135),
                    new Vector(29.1003858181818, -89.388662),
                    new Vector(29.1044898181819, -89.339738),
                    new Vector(29.1801888181818, -89.319092),
                    new Vector(29.1482118181819, -89.26329199999989),
                    new Vector(28.9396548181819, -89.39489),
                    new Vector(29.0594628181819, -89.257496),
                    new Vector(29.1211758181819, -89.24116100000001),
                    new Vector(29.0166858181819, -89.14439299999999),
                    new Vector(29.05722181818191, -89.154023),
                    new Vector(29.0830158181818, -89.111408),
                    new Vector(29.1353058181818, -89.126546),
                    new Vector(29.0852838181819, -89.057759),
                    new Vector(29.1471138181818, -89.021804),
                    new Vector(29.1634488181817, -89.0982769999999),
                    new Vector(29.2234068181819, -89.0332609999999),
                    new Vector(29.2118778181818, -89.1202279999999),
                    new Vector(29.2908888181819, -89.12993899999999),
                    new Vector(29.3490468181818, -89.193398),
                    new Vector(29.2978098181819, -89.26255399999999),
                    new Vector(29.3506668181819, -89.2647769999999),
                    new Vector(29.3408928181819, -89.337056),
                    new Vector(29.3979348181819, -89.384522),
                    new Vector(29.4014538181819, -89.53707199999999),
                    new Vector(29.4716808181818, -89.544623),
                    new Vector(29.6102448181819, -89.771783),
                    new Vector(29.6060238181819, -89.7232099999999),
                    new Vector(29.6373798181819, -89.74854499999999),
                    new Vector(29.6461728181819, -89.72832200000001),
                    new Vector(29.6265258181818, -89.635262),
                    new Vector(29.6940798181819, -89.695328),
                    new Vector(29.7029628181818, -89.676698),
                    new Vector(29.6651538181819, -89.59795699999999),
                    new Vector(29.6361738181818, -89.4791929999999),
                    new Vector(29.6646138181817, -89.511944),
                    new Vector(29.697742818182, -89.611835),
                    new Vector(29.7108648181818, -89.592872),
                    new Vector(29.7668988181818, -89.650589),
                    new Vector(29.7547308181818, -89.54050100000001),
                    new Vector(29.8309428181819, -89.482235),
                    new Vector(29.7829368181818, -89.41742600000001),
                    new Vector(29.7967698181819, -89.36403799999989),
                    new Vector(29.8280988181818, -89.42115200000001),
                    new Vector(29.8459458181818, -89.402198),
                    new Vector(29.9402838181819, -89.431043),
                    new Vector(29.95128181818181, -89.37779),
                    new Vector(29.9857338181819, -89.453624),
                    new Vector(30.0444048181819, -89.435858),
                    new Vector(30.0089628181818, -89.574386),
                    new Vector(29.8981548181818, -89.58586099999999),
                    new Vector(29.8756818181819, -89.627414),
                    new Vector(29.8975248181819, -89.712203),
                    new Vector(29.9693988181819, -89.71502),
                    new Vector(29.9512908181819, -89.8208419999999),
                    new Vector(30.0106818181819, -89.848967),
                    new Vector(30.0552228181818, -89.7168379999999),
                    new Vector(30.1224258181819, -89.64939200000001),
                    new Vector(30.163384818182, -89.669201),
                    new Vector(30.1210938181819, -89.724929),
                    new Vector(30.1589298181819, -89.740094),
                    new Vector(30.1053708181819, -89.798261),
                    new Vector(30.1560948181818, -89.891231),
                    new Vector(30.0536658181819, -89.99054599999999),
                    new Vector(30.0416058181819, -90.11154200000001),
                    new Vector(30.0620538181818, -90.275981),
                    new Vector(30.0920778181818, -90.39556399999999),
                    new Vector(30.1858848181818, -90.424526),
                    new Vector(30.3038478181819, -90.30902899999998),
                    new Vector(30.3809508181818, -90.23975600000001),
                    new Vector(30.3689808181817, -90.07555999999991),
                    new Vector(30.26985481818179, -89.943539),
                    new Vector(30.2310918181819, -89.759219),
                    new Vector(30.1810068181818, -89.728565),
                    new Vector(30.1949388181819, -89.573882),
                    new Vector(30.2414148181819, -89.609999),
                    new Vector(30.2478228181818, -89.606309),
                    new Vector(30.2569668181818, -89.621663),
                    new Vector(30.29035681818189, -89.625947),
                    new Vector(30.2958288181819, -89.639177),
                    new Vector(30.3118488181819, -89.6370799999999),
                    new Vector(30.3237648181819, -89.618594),
                    new Vector(30.3434298181819, -89.62019600000001),
                    new Vector(30.3553098181818, -89.633453),
                    new Vector(30.3552918181819, -89.646692),
                    new Vector(30.3790608181818, -89.654675),
                    new Vector(30.4000758181818, -89.675375),
                    new Vector(30.445354818182, -89.675465),
                    new Vector(30.4627158181818, -89.683457),
                    new Vector(30.4681878181818, -89.6945989999999),
                    new Vector(30.478249818182, -89.6956789999999),
                    new Vector(30.4814178181819, -89.713184),
                    new Vector(30.4960338181818, -89.719061),
                    new Vector(30.4978338181818, -89.73231800000001),
                    new Vector(30.51561781818191, -89.755178),
                    new Vector(30.5512488181819, -89.7728),
                    new Vector(30.5539488181819, -89.790845),
                    new Vector(30.6242748181818, -89.820311),
                    new Vector(30.6494568181819, -89.805533),
                    new Vector(30.6512478181818, -89.819357),
                    new Vector(30.6708768181818, -89.829527),
                    new Vector(30.6662508181818, -89.845448),
                    new Vector(30.675880818182, -89.83539500000001),
                    new Vector(30.6795168181819, -89.841785),
                    new Vector(30.7005588181819, -89.84134400000001),
                    new Vector(30.70378081818181, -89.830724),
                    new Vector(30.7124298181819, -89.844053),
                    new Vector(30.7293678181819, -89.83562000000001),
                    new Vector(30.73305781818179, -89.823398),
                    new Vector(30.7426428181819, -89.82556700000001),
                    new Vector(30.7481688181819, -89.813354),
                    new Vector(30.7897308181819, -89.82469399999999),
                    new Vector(30.8116998181819, -89.81093300000001),
                    new Vector(30.812653818182, -89.79656),
                    new Vector(30.8291058181818, -89.796092),
                    new Vector(30.8305368181819, -89.774798),
                    new Vector(30.861577818182, -89.785031),
                    new Vector(30.8620818181819, -89.765852),
                    new Vector(30.9004758181818, -89.763305),
                    new Vector(30.9027888181819, -89.746799),
                    new Vector(30.9101058181819, -89.745755),
                    new Vector(30.9210498181819, -89.75805800000001),
                    new Vector(30.9261078181818, -89.740472),
                    new Vector(30.9498498181818, -89.748536),
                    new Vector(30.9654018181819, -89.739518),
                    new Vector(30.9754908181818, -89.719826),
                    new Vector(30.9846168181818, -89.726783),
                    new Vector(31.001527818182, -89.723624),
                    new Vector(31.0074498181818, -89.732714),
                    new Vector(31.0071798181819, -89.833568),
                    new Vector(31.0073688181819, -90.25937599999999),
                    new Vector(31.0053888181819, -90.3436609999999),
                    new Vector(31.0023288181818, -90.54265100000001),
                    new Vector(31.0017078181819, -90.56025500000001),
                    new Vector(31.0015458181819, -90.82971500000001),
                    new Vector(31.0004208181819, -91.05700999999999),
                    new Vector(31.0004658181819, -91.17921200000001),
                    new Vector(31.0013658181819, -91.632299),
                    new Vector(30.9898998181819, -91.658147),
                    new Vector(31.0235688181818, -91.64195600000001),
                    new Vector(31.0473558181818, -91.640444),
                    new Vector(31.0601448181818, -91.71074299999989),
                    new Vector(31.0426848181818, -91.73857099999999),
                    new Vector(31.0238478181818, -91.743926),
                    new Vector(31.0178268181817, -91.76991799999999),
                    new Vector(30.9985218181819, -91.77577700000001),
                    new Vector(30.9797388181819, -91.800329),
                    new Vector(30.8728548181819, -91.79730499999999),
                    new Vector(30.8703168181819, -91.8095),
                    new Vector(30.8583018181818, -91.816079),
                    new Vector(30.8516418181818, -91.80629600000002),
                    new Vector(30.8526138181819, -92.2080289999999),
                    new Vector(30.8552238181819, -92.232095),
                    new Vector(30.8955438181818, -92.228117),
                    new Vector(30.9369798181818, -92.271632),
                    new Vector(30.9688938181819, -92.274854),
                    new Vector(30.9670488181818, -92.32975399999998),
                    new Vector(30.9916548181818, -92.35036399999998),
                    new Vector(30.999277818182, -92.391188),
                    new Vector(30.9749058181819, -92.414345),
                    new Vector(30.9581298181819, -92.47829),
                    new Vector(30.9474558181819, -92.48431100000001),
                    new Vector(30.9309138181819, -92.47036099999998),
                    new Vector(30.9203568181819, -92.47210699999999),
                    new Vector(30.8972628181819, -92.497928),
                    new Vector(30.8949948181818, -92.51437100000001),
                    new Vector(30.9030858181818, -92.53599800000001),
                    new Vector(30.8984778181819, -92.58647000000002),
                    new Vector(30.8909538181818, -92.81544799999999),
                    new Vector(30.8762928181818, -92.816447),
                    new Vector(30.8775798181819, -92.96843000000001),
                    new Vector(30.8793168181819, -93.128432),
                    new Vector(30.8879748181819, -93.129341),
                    new Vector(30.8879838181819, -93.424226),
                    new Vector(30.8641878181819, -93.47586800000001),
                    new Vector(30.8856528181819, -93.53983099999989),
                    new Vector(30.8720808181818, -93.56101700000002),
                    new Vector(30.8604798181819, -93.552971),
                    new Vector(30.8453418181819, -93.5666149999999),
                    new Vector(30.8425338181819, -93.555815),
                    new Vector(30.8285478181818, -93.550856),
                    new Vector(30.8022408181819, -93.582041),
                    new Vector(30.7723788181818, -93.58534400000001),
                    new Vector(30.7459908181818, -93.61862599999999),
                    new Vector(30.7322118181818, -93.607826),
                    new Vector(30.7327428181819, -93.61795999999988),
                    new Vector(30.7105308181818, -93.612578),
                    new Vector(30.6869958181818, -93.61778000000001),
                    new Vector(30.6730638181819, -93.660161),
                    new Vector(30.6398898181819, -93.67814299999999),
                    new Vector(30.6402498181819, -93.69305599999998),
                    new Vector(30.6236268181819, -93.68476699999999),
                    new Vector(30.6160038181818, -93.692876),
                    new Vector(30.5980398181819, -93.671753),
                    new Vector(30.599038818182, -93.69358699999999),
                    new Vector(30.5875818181818, -93.717986),
                    new Vector(30.56835781818179, -93.718058),
                    new Vector(30.5457138181819, -93.735482),
                    new Vector(30.5230608181818, -93.70563800000001),
                    new Vector(30.5053218181819, -93.714809),
                    new Vector(30.4964478181818, -93.707447),
                    new Vector(30.4888248181819, -93.71502499999998),
                    new Vector(30.47024881818181, -93.69814100000001),
                    new Vector(30.4627158181818, -93.70359500000001),
                    new Vector(30.4428348181818, -93.696746),
                    new Vector(30.4331778181819, -93.721712),
                    new Vector(30.4090308181819, -93.74272699999999),
                    new Vector(30.3819948181819, -93.75511999999999),
                    new Vector(30.3676218181819, -93.748001),
                    new Vector(30.3543558181819, -93.759512),
                    new Vector(30.3410808181819, -93.75934100000001),
                    new Vector(30.3051168181819, -93.72994699999998),
                    new Vector(30.2975928181818, -93.69937400000001),
                    new Vector(30.2395788181818, -93.70752799999998),
                    new Vector(30.2205078181818, -93.715007),
                    new Vector(30.1810698181819, -93.70453099999999),
                    new Vector(30.1758858181819, -93.69632299999999),
                    new Vector(30.1510188181818, -93.69982400000001),
                    new Vector(30.148435818182, -93.68330899999999),
                    new Vector(30.14146081818179, -93.686126),
                    new Vector(30.1414338181818, -93.69879800000001),
                    new Vector(30.1181328181818, -93.69708799999998),
                    new Vector(30.11495581818181, -93.708545),
                    new Vector(30.0958848181818, -93.716024),
                    new Vector(30.0607308181818, -93.712649)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(29.5964838181819, -92.01636500000001),
                    new Vector(29.4870798181819, -91.849091),
                    new Vector(29.4945048181818, -91.75810999999999),
                    new Vector(29.5342578181819, -91.7649679999999),
                    new Vector(29.5772598181819, -91.7016169999999),
                    new Vector(29.5786188181819, -91.76984599999999),
                    new Vector(29.6509248181819, -91.9025419999999),
                    new Vector(29.5964838181819, -92.01636500000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(29.2590918181818, -90.9345739999999),
                    new Vector(29.3238018181818, -90.99895100000001),
                    new Vector(29.297548818182, -91.007375),
                    new Vector(29.293516818182, -91.12750699999999),
                    new Vector(29.227078818182, -91.12256600000001),
                    new Vector(29.1909168181818, -91.05555200000001),
                    new Vector(29.2531158181819, -91.06769300000001),
                    new Vector(29.2756248181819, -91.033097),
                    new Vector(29.21125681818179, -91.04444599999989),
                    new Vector(29.2248018181818, -90.99456799999999),
                    new Vector(29.1843198181818, -91.00323499999999),
                    new Vector(29.1857958181819, -90.962024),
                    new Vector(29.2263948181819, -90.94497800000002),
                    new Vector(29.2199508181819, -90.980384),
                    new Vector(29.2763448181818, -90.98138299999988),
                    new Vector(29.2730508181818, -90.95362699999998),
                    new Vector(29.2420908181819, -90.97084400000001),
                    new Vector(29.2590918181818, -90.9345739999999)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(29.3419098181819, -91.3413199999999),
                    new Vector(29.254024818182, -91.27615999999999),
                    new Vector(29.2269978181818, -91.128308),
                    new Vector(29.2599288181819, -91.1346889999999),
                    new Vector(29.2452678181818, -91.16365999999999),
                    new Vector(29.2665348181818, -91.15259),
                    new Vector(29.2736718181818, -91.19506099999998),
                    new Vector(29.3079798181819, -91.200461),
                    new Vector(29.2847508181819, -91.18802299999999),
                    new Vector(29.2836708181819, -91.1712289999999),
                    new Vector(29.3237208181819, -91.16156299999999),
                    new Vector(29.2976118181818, -91.18927400000001),
                    new Vector(29.3814018181819, -91.22655200000001),
                    new Vector(29.3164578181818, -91.300487),
                    new Vector(29.3419098181819, -91.3413199999999)
                })
            }
        };
    }
}