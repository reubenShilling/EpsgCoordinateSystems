using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Oklahoma_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2268;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Oklahoma South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Oklahoma South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35.23333333333333],PARAMETER[standard_parallel_2,33.93333333333333],PARAMETER[latitude_of_origin,33.33333333333334],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2268],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Oklahoma South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,35.23333333333333],PARAMETER[standard_parallel_2,33.93333333333333],PARAMETER[latitude_of_origin,33.33333333333334],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-98.137184, 34.1385228181818, 0),
                    new Vector(-98.11517899999998, 34.1490798181819, 0),
                    new Vector(-98.09444299999998, 34.1346438181818, 0),
                    new Vector(-98.11101199999999, 34.0699158181819, 0),
                    new Vector(-98.08651399999999, 34.0054128181818, 0),
                    new Vector(-98.05586900000002, 33.9898968181818, 0),
                    new Vector(-98.02381099999999, 33.9870798181819, 0),
                    new Vector(-97.98298699999991, 34.0013808181818, 0),
                    new Vector(-97.95053299999999, 33.9712578181818, 0),
                    new Vector(-97.94806699999999, 33.9598458181819, 0),
                    new Vector(-97.96331300000001, 33.9487488181819, 0),
                    new Vector(-97.95100100000002, 33.9326208181819, 0),
                    new Vector(-97.976444, 33.9121548181819, 0),
                    new Vector(-97.9766869999999, 33.9025968181817, 0),
                    new Vector(-97.95504200000002, 33.8835798181819, 0),
                    new Vector(-97.90937599999999, 33.8741298181818, 0),
                    new Vector(-97.870064, 33.8552208181819, 0),
                    new Vector(-97.852856, 33.8571738181819, 0),
                    new Vector(-97.7905219999999, 33.890554818182, 0),
                    new Vector(-97.75667300000001, 33.9321978181819, 0),
                    new Vector(-97.729331, 33.939388818182, 0),
                    new Vector(-97.70456299999999, 33.9716448181819, 0),
                    new Vector(-97.67137099999999, 33.9887088181819, 0),
                    new Vector(-97.6004779999999, 33.9695388181819, 0),
                    new Vector(-97.592657, 33.9179778181818, 0),
                    new Vector(-97.575971, 33.9026238181818, 0),
                    new Vector(-97.55489300000001, 33.9040008181819, 0),
                    new Vector(-97.51849700000001, 33.9168708181818, 0),
                    new Vector(-97.47782599999991, 33.9078078181818, 0),
                    new Vector(-97.463066, 33.9024798181819, 0),
                    new Vector(-97.45736000000001, 33.8905368181819, 0),
                    new Vector(-97.45304, 33.8363208181818, 0),
                    new Vector(-97.410416, 33.8208048181818, 0),
                    new Vector(-97.36361599999988, 33.8311278181819, 0),
                    new Vector(-97.342097, 33.8620158181819, 0),
                    new Vector(-97.31525899999991, 33.8704938181819, 0),
                    new Vector(-97.314386, 33.8959458181819, 0),
                    new Vector(-97.2725719999999, 33.8726718181818, 0),
                    new Vector(-97.264202, 33.8588388181819, 0),
                    new Vector(-97.25098099999998, 33.8730768181819, 0),
                    new Vector(-97.24635499999998, 33.8943348181818, 0),
                    new Vector(-97.21162400000001, 33.9057918181818, 0),
                    new Vector(-97.188062, 33.8993118181819, 0),
                    new Vector(-97.164464, 33.8632578181818, 0),
                    new Vector(-97.16888299999999, 33.8479038181819, 0),
                    new Vector(-97.195307, 33.8362668181818, 0),
                    new Vector(-97.20860899999998, 33.8197518181819, 0),
                    new Vector(-97.18945699999999, 33.7528728181819, 0),
                    new Vector(-97.15276399999999, 33.7287708181819, 0),
                    new Vector(-97.11585499999998, 33.7260348181819, 0),
                    new Vector(-97.09079, 33.7317768181818, 0),
                    new Vector(-97.083752, 33.7425138181818, 0),
                    new Vector(-97.08795499999998, 33.8076738181818, 0),
                    new Vector(-97.05031700000001, 33.8235588181819, 0),
                    new Vector(-97.0785319999999, 33.8379048181818, 0),
                    new Vector(-97.082465, 33.851197818182, 0),
                    new Vector(-97.07118800000001, 33.8568228181817, 0),
                    new Vector(-97.025882, 33.8406678181818, 0),
                    new Vector(-97.0061359999999, 33.8506218181819, 0),
                    new Vector(-96.98799200000002, 33.8765238181819, 0),
                    new Vector(-96.988145, 33.9443028181819, 0),
                    new Vector(-96.96847099999999, 33.9374178181818, 0),
                    new Vector(-96.936494, 33.9479478181819, 0),
                    new Vector(-96.9298519999999, 33.9618708181819, 0),
                    new Vector(-96.89873900000001, 33.9501258181818, 0),
                    new Vector(-96.883133, 33.9246918181818, 0),
                    new Vector(-96.87921799999999, 33.8841018181818, 0),
                    new Vector(-96.861299, 33.8617818181819, 0),
                    new Vector(-96.844289, 33.8581368181819, 0),
                    new Vector(-96.81439999999999, 33.8718708181818, 0),
                    new Vector(-96.797876, 33.8700528181818, 0),
                    new Vector(-96.74909599999999, 33.8318388181819, 0),
                    new Vector(-96.71195299999999, 33.8339718181818, 0),
                    new Vector(-96.693656, 33.8480118181819, 0),
                    new Vector(-96.677978, 33.904423818182, 0),
                    new Vector(-96.666512, 33.9136488181819, 0),
                    new Vector(-96.58476499999999, 33.8962428181818, 0),
                    new Vector(-96.61443799999989, 33.8629968181819, 0),
                    new Vector(-96.60146, 33.8430528181819, 0),
                    new Vector(-96.56240900000002, 33.8255208181819, 0),
                    new Vector(-96.510848, 33.8157918181818, 0),
                    new Vector(-96.50102, 33.7881888181818, 0),
                    new Vector(-96.487646, 33.7782348181819, 0),
                    new Vector(-96.41972299999999, 33.7884228181818, 0),
                    new Vector(-96.37107799999998, 33.7404978181818, 0),
                    new Vector(-96.347858, 33.705622818182, 0),
                    new Vector(-96.31653799999999, 33.7018968181819, 0),
                    new Vector(-96.301058, 33.714154818182, 0),
                    new Vector(-96.28994299999999, 33.7620348181817, 0),
                    new Vector(-96.27833299999999, 33.7734918181819, 0),
                    new Vector(-96.2128129999999, 33.7567878181817, 0),
                    new Vector(-96.18728000000002, 33.7586778181818, 0),
                    new Vector(-96.169073, 33.7694508181818, 0),
                    new Vector(-96.161576, 33.7983228181819, 0),
                    new Vector(-96.141677, 33.8204178181818, 0),
                    new Vector(-96.15477199999999, 33.8240448181818, 0),
                    new Vector(-96.18098000000001, 33.8085378181818, 0),
                    new Vector(-96.183392, 33.8158908181819, 0),
                    new Vector(-96.16946, 33.8290848181817, 0),
                    new Vector(-96.14922799999989, 33.8356908181819, 0),
                    new Vector(-96.1097, 33.8293548181819, 0),
                    new Vector(-96.09178099999991, 33.8446818181819, 0),
                    new Vector(-96.04823, 33.8413788181819, 0),
                    new Vector(-96.02699900000002, 33.8561208181818, 0),
                    new Vector(-96.01432699999989, 33.8443128181819, 0),
                    new Vector(-96.002042, 33.8570838181819, 0),
                    new Vector(-96.00286999999999, 33.8734908181819, 0),
                    new Vector(-95.99446399999991, 33.875470818182, 0),
                    new Vector(-95.97764299999999, 33.8580558181818, 0),
                    new Vector(-95.959022, 33.8651388181818, 0),
                    new Vector(-95.943326, 33.8900688181819, 0),
                    new Vector(-95.93332699999999, 33.8906268181818, 0),
                    new Vector(-95.84681, 33.8411358181818, 0),
                    new Vector(-95.82621799999998, 33.8431248181819, 0),
                    new Vector(-95.79572599999999, 33.8647698181819, 0),
                    new Vector(-95.7687619999999, 33.8515038181819, 0),
                    new Vector(-95.76449600000001, 33.8791068181819, 0),
                    new Vector(-95.760941, 33.8935428181819, 0),
                    new Vector(-95.747108, 33.9034968181818, 0),
                    new Vector(-95.6999569999999, 33.8949288181818, 0),
                    new Vector(-95.633735, 33.9202098181819, 0),
                    new Vector(-95.61322400000002, 33.9203448181819, 0),
                    new Vector(-95.61506900000001, 33.9367878181819, 0),
                    new Vector(-95.60631200000002, 33.9446538181818, 0),
                    new Vector(-95.56301299999988, 33.9361848181819, 0),
                    new Vector(-95.54655200000001, 33.9041358181819, 0),
                    new Vector(-95.519822, 33.9067458181818, 0),
                    new Vector(-95.52697699999999, 33.897916818182, 0),
                    new Vector(-95.5477309999999, 33.8932638181819, 0),
                    new Vector(-95.5442749999999, 33.8858478181818, 0),
                    new Vector(-95.51311699999999, 33.8978358181818, 0),
                    new Vector(-95.499095, 33.8818158181818, 0),
                    new Vector(-95.46836, 33.8865408181818, 0),
                    new Vector(-95.45184500000001, 33.8658588181819, 0),
                    new Vector(-95.33027300000001, 33.8710248181818, 0),
                    new Vector(-95.336465, 33.8972148181818, 0),
                    new Vector(-95.302193, 33.8867298181818, 0),
                    new Vector(-95.28666800000001, 33.8870088181818, 0),
                    new Vector(-95.27757800000001, 33.9180498181819, 0),
                    new Vector(-95.26384400000002, 33.8979078181819, 0),
                    new Vector(-95.251226, 33.9051258181819, 0),
                    new Vector(-95.25151399999999, 33.9365538181819, 0),
                    new Vector(-95.23427, 33.9649758181818, 0),
                    new Vector(-95.148545, 33.9436548181818, 0),
                    new Vector(-95.12819600000002, 33.9409728181819, 0),
                    new Vector(-95.1269089999999, 33.9172578181819, 0),
                    new Vector(-95.11945700000001, 33.9123888181819, 0),
                    new Vector(-95.0955799999999, 33.9218478181819, 0),
                    new Vector(-95.08249400000001, 33.9185628181819, 0),
                    new Vector(-95.08993700000002, 33.8970258181819, 0),
                    new Vector(-95.083826, 33.8885748181819, 0),
                    new Vector(-95.06370200000001, 33.9177528181818, 0),
                    new Vector(-95.06336, 33.8968008181818, 0),
                    new Vector(-95.043092, 33.8845518181819, 0),
                    new Vector(-95.03758400000001, 33.8665608181819, 0),
                    new Vector(-95.012996, 33.8700528181818, 0),
                    new Vector(-94.989497, 33.8562918181819, 0),
                    new Vector(-94.968923, 33.8663268181819, 0),
                    new Vector(-94.96013000000001, 33.8481828181819, 0),
                    new Vector(-94.940105, 33.8409378181819, 0),
                    new Vector(-94.940618, 33.8159178181818, 0),
                    new Vector(-94.918451, 33.8163048181818, 0),
                    new Vector(-94.908767, 33.8035788181819, 0),
                    new Vector(-94.91410399999999, 33.7897098181819, 0),
                    new Vector(-94.88185699999998, 33.7750758181818, 0),
                    new Vector(-94.858097, 33.7494258181819, 0),
                    new Vector(-94.81937000000002, 33.7495068181819, 0),
                    new Vector(-94.80343999999998, 33.7396878181819, 0),
                    new Vector(-94.783721, 33.7533768181818, 0),
                    new Vector(-94.76438899999998, 33.7529538181818, 0),
                    new Vector(-94.782245, 33.7423698181818, 0),
                    new Vector(-94.78336999999999, 33.7337748181819, 0),
                    new Vector(-94.74997999999988, 33.7368168181819, 0),
                    new Vector(-94.7629309999999, 33.7169088181819, 0),
                    new Vector(-94.7423299999999, 33.7191588181819, 0),
                    new Vector(-94.754687, 33.7078818181818, 0),
                    new Vector(-94.7418619999999, 33.7013838181819, 0),
                    new Vector(-94.69120100000001, 33.6904038181818, 0),
                    new Vector(-94.66866500000002, 33.6966498181819, 0),
                    new Vector(-94.65568700000001, 33.6924018181819, 0),
                    new Vector(-94.64453599999999, 33.6777678181818, 0),
                    new Vector(-94.668161, 33.6715758181819, 0),
                    new Vector(-94.66963699999999, 33.666175818182, 0),
                    new Vector(-94.65874699999999, 33.6638538181818, 0),
                    new Vector(-94.638974, 33.6702168181818, 0),
                    new Vector(-94.631945, 33.6840048181819, 0),
                    new Vector(-94.601156, 33.6657168181818, 0),
                    new Vector(-94.58531600000001, 33.6790908181819, 0),
                    new Vector(-94.57871899999989, 33.6705858181818, 0),
                    new Vector(-94.56092599999999, 33.6720258181817, 0),
                    new Vector(-94.565417, 33.6631248181819, 0),
                    new Vector(-94.58536100000002, 33.6622428181818, 0),
                    new Vector(-94.58859200000001, 33.6555648181819, 0),
                    new Vector(-94.57667600000001, 33.6522708181818, 0),
                    new Vector(-94.545626, 33.6617388181818, 0),
                    new Vector(-94.54213399999999, 33.6483648181818, 0),
                    new Vector(-94.56240199999999, 33.6429468181818, 0),
                    new Vector(-94.56235700000001, 33.6356568181819, 0),
                    new Vector(-94.55039600000001, 33.6328128181819, 0),
                    new Vector(-94.51820299999999, 33.6431268181818, 0),
                    new Vector(-94.525268, 33.6211398181819, 0),
                    new Vector(-94.51076, 33.6309228181819, 0),
                    new Vector(-94.50081500000002, 33.6231648181818, 0),
                    new Vector(-94.47669499999999, 33.6320838181819, 0),
                    new Vector(-94.468586, 33.9393078181818, 0),
                    new Vector(-94.46169199999999, 34.1967618181818, 0),
                    new Vector(-94.452629, 34.508440818182, 0),
                    new Vector(-94.44596, 34.7356098181818, 0),
                    new Vector(-94.439318, 34.9291548181818, 0),
                    new Vector(-94.42855400000001, 35.4005478181819, 0),
                    new Vector(-94.45036100000002, 35.3773458181819, 0),
                    new Vector(-94.492949, 35.3666088181819, 0),
                    new Vector(-94.503767, 35.3575638181819, 0),
                    new Vector(-94.50409999999989, 35.3057508181819, 0),
                    new Vector(-94.601822, 35.3366388181819, 0),
                    new Vector(-94.63183700000002, 35.3111868181819, 0),
                    new Vector(-94.63593200000001, 35.2849968181819, 0),
                    new Vector(-94.669466, 35.2815228181819, 0),
                    new Vector(-94.664759, 35.3085948181818, 0),
                    new Vector(-94.70039899999999, 35.3479248181819, 0),
                    new Vector(-94.76342600000001, 35.3593818181818, 0),
                    new Vector(-94.80735499999999, 35.3445048181819, 0),
                    new Vector(-94.85644099999999, 35.3784798181819, 0),
                    new Vector(-94.900352, 35.3721978181819, 0),
                    new Vector(-94.90760599999999, 35.3988828181818, 0),
                    new Vector(-94.92390499999999, 35.4086748181818, 0),
                    new Vector(-94.959203, 35.4133728181819, 0),
                    new Vector(-94.9712, 35.4370518181819, 0),
                    new Vector(-95.01373400000001, 35.4434058181819, 0),
                    new Vector(-95.07200899999989, 35.4690288181818, 0),
                    new Vector(-95.086004, 35.4537108181818, 0),
                    new Vector(-95.083187, 35.4358728181819, 0),
                    new Vector(-95.105795, 35.3918088181818, 0),
                    new Vector(-95.143514, 35.3847348181818, 0),
                    new Vector(-95.1388249999999, 35.3609118181819, 0),
                    new Vector(-95.17238599999999, 35.3391048181819, 0),
                    new Vector(-95.21892500000001, 35.2719288181819, 0),
                    new Vector(-95.25219800000001, 35.2719108181818, 0),
                    new Vector(-95.297837, 35.3000988181819, 0),
                    new Vector(-95.339795, 35.3058588181819, 0),
                    new Vector(-95.340479, 35.5630698181819, 0),
                    new Vector(-95.70700399999998, 35.5574088181819, 0),
                    new Vector(-95.82239300000002, 35.5583628181819, 0),
                    new Vector(-95.82593900000001, 35.4730878181818, 0),
                    new Vector(-95.875151, 35.4720888181819, 0),
                    new Vector(-95.87875999999999, 35.3845368181818, 0),
                    new Vector(-95.97756200000001, 35.3843118181818, 0),
                    new Vector(-95.977301, 35.2929798181819, 0),
                    new Vector(-96.436751, 35.2941138181818, 0),
                    new Vector(-96.43803799999999, 35.4603978181818, 0),
                    new Vector(-96.472031, 35.4582378181819, 0),
                    new Vector(-96.498212, 35.4294918181819, 0),
                    new Vector(-96.5240239999999, 35.4329748181819, 0),
                    new Vector(-96.53007199999999, 35.4490578181818, 0),
                    new Vector(-96.55080800000002, 35.4528378181819, 0),
                    new Vector(-96.56637799999999, 35.4455748181819, 0),
                    new Vector(-96.5367229999999, 35.4020058181819, 0),
                    new Vector(-96.540125, 35.3893878181819, 0),
                    new Vector(-96.59009299999998, 35.4081078181818, 0),
                    new Vector(-96.61984699999999, 35.3989728181818, 0),
                    new Vector(-96.61675099999998, 35.4688218181819, 0),
                    new Vector(-97.14100999999988, 35.4699468181819, 0),
                    new Vector(-97.14076700000001, 35.385940818182, 0),
                    new Vector(-97.66738400000001, 35.3807118181819, 0),
                    new Vector(-97.669301, 35.3362518181819, 0),
                    new Vector(-97.69506800000001, 35.3422098181819, 0),
                    new Vector(-97.734875, 35.3307168181818, 0),
                    new Vector(-97.785662, 35.3484828181819, 0),
                    new Vector(-97.821518, 35.3368908181818, 0),
                    new Vector(-97.85014700000001, 35.3415078181819, 0),
                    new Vector(-97.8801169999999, 35.3588418181819, 0),
                    new Vector(-97.91071700000002, 35.3534778181818, 0),
                    new Vector(-97.94695100000001, 35.3691018181819, 0),
                    new Vector(-97.97726299999999, 35.3532798181819, 0),
                    new Vector(-98.022335, 35.3767428181819, 0),
                    new Vector(-98.08830500000001, 35.3778408181818, 0),
                    new Vector(-98.308823, 35.3798388181819, 0),
                    new Vector(-98.30665399999999, 35.5545558181819, 0),
                    new Vector(-98.619872, 35.5545378181818, 0),
                    new Vector(-98.61918799999999, 35.4673908181819, 0),
                    new Vector(-99.35834899999999, 35.4700818181819, 0),
                    new Vector(-99.36086, 35.5063968181819, 0),
                    new Vector(-99.57384499999999, 35.5073598181818, 0),
                    new Vector(-99.573161, 35.427025818182, 0),
                    new Vector(-99.994748, 35.4246138181819, 0),
                    new Vector(-99.997574, 35.1822348181819, 0),
                    new Vector(-99.996458, 35.0310528181819, 0),
                    new Vector(-99.99926600000001, 34.7472468181819, 0),
                    new Vector(-99.996476, 34.5623778181818, 0),
                    new Vector(-99.972482, 34.5619278181819, 0),
                    new Vector(-99.94512200000001, 34.5796398181819, 0),
                    new Vector(-99.932288, 34.5791718181819, 0),
                    new Vector(-99.88097, 34.5482478181819, 0),
                    new Vector(-99.860945, 34.5186918181819, 0),
                    new Vector(-99.830309, 34.5018438181818, 0),
                    new Vector(-99.77806400000001, 34.4440638181818, 0),
                    new Vector(-99.68527400000001, 34.3775178181817, 0),
                    new Vector(-99.601817, 34.3686348181818, 0),
                    new Vector(-99.58559, 34.3849338181818, 0),
                    new Vector(-99.57821900000002, 34.4089908181818, 0),
                    new Vector(-99.55423399999999, 34.4152548181818, 0),
                    new Vector(-99.50250199999989, 34.4041488181818, 0),
                    new Vector(-99.47981299999999, 34.3836018181819, 0),
                    new Vector(-99.43874599999999, 34.3647828181818, 0),
                    new Vector(-99.410324, 34.3691838181818, 0),
                    new Vector(-99.39451999999999, 34.3968138181819, 0),
                    new Vector(-99.39315199999999, 34.4290698181818, 0),
                    new Vector(-99.364577, 34.4502738181819, 0),
                    new Vector(-99.32366299999998, 34.4127888181819, 0),
                    new Vector(-99.26753899999999, 34.3983618181819, 0),
                    new Vector(-99.254462, 34.3682928181819, 0),
                    new Vector(-99.205844, 34.3320768181818, 0),
                    new Vector(-99.196664, 34.3052118181819, 0),
                    new Vector(-99.204953, 34.2557298181819, 0),
                    new Vector(-99.19083200000001, 34.2238158181818, 0),
                    new Vector(-99.176513, 34.2128178181819, 0),
                    new Vector(-99.1283, 34.2015588181819, 0),
                    new Vector(-99.07878199999999, 34.2084438181818, 0),
                    new Vector(-99.035573, 34.1990118181818, 0),
                    new Vector(-98.996549, 34.2095778181819, 0),
                    new Vector(-98.95285400000002, 34.1946558181818, 0),
                    new Vector(-98.89168999999998, 34.1609058181819, 0),
                    new Vector(-98.81141, 34.1460288181818, 0),
                    new Vector(-98.77887500000001, 34.1320518181819, 0),
                    new Vector(-98.70563300000001, 34.1308098181819, 0),
                    new Vector(-98.682557, 34.1500878181819, 0),
                    new Vector(-98.66206399999999, 34.1471268181819, 0),
                    new Vector(-98.62632499999999, 34.1585298181818, 0),
                    new Vector(-98.60757800000002, 34.1514918181817, 0),
                    new Vector(-98.57666299999998, 34.1420148181819, 0),
                    new Vector(-98.55791600000002, 34.1054298181819, 0),
                    new Vector(-98.49985700000001, 34.066504818182, 0),
                    new Vector(-98.44852099999999, 34.0544718181818, 0),
                    new Vector(-98.42167399999991, 34.0659288181819, 0),
                    new Vector(-98.40746299999999, 34.0825428181818, 0),
                    new Vector(-98.39128100000001, 34.0873308181819, 0),
                    new Vector(-98.38458500000002, 34.1158698181819, 0),
                    new Vector(-98.35072700000001, 34.1422128181819, 0),
                    new Vector(-98.32082, 34.1395128181818, 0),
                    new Vector(-98.277323, 34.1229618181818, 0),
                    new Vector(-98.17316599999999, 34.1154648181817, 0),
                    new Vector(-98.137184, 34.1385228181818, 0)
                })
            }
        };
    }
}