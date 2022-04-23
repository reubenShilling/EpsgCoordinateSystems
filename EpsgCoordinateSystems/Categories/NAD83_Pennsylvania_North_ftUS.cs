using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Pennsylvania_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2271;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Pennsylvania North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Pennsylvania North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.95],PARAMETER[standard_parallel_2,40.88333333333333],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-77.75],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2271],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Pennsylvania North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.95],PARAMETER[standard_parallel_2,40.88333333333333],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-77.75],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.483041, 40.8137238181818, 0),
                    new Vector(-75.29996300000001, 40.8615048181817, 0),
                    new Vector(-75.247304, 40.9123188181819, 0),
                    new Vector(-75.135524, 40.9629348181819, 0),
                    new Vector(-75.1393039999999, 40.9775238181818, 0),
                    new Vector(-75.1166149999999, 41.0002488181819, 0),
                    new Vector(-75.069986, 41.0107158181818, 0),
                    new Vector(-75.03525500000001, 41.0282028181819, 0),
                    new Vector(-75.001154, 41.0624838181818, 0),
                    new Vector(-74.96628800000001, 41.0826708181818, 0),
                    new Vector(-74.988878, 41.0817618181819, 0),
                    new Vector(-74.984594, 41.0993838181819, 0),
                    new Vector(-74.949989, 41.1118578181818, 0),
                    new Vector(-74.91476299999999, 41.1411078181818, 0),
                    new Vector(-74.86287799999999, 41.2067718181819, 0),
                    new Vector(-74.866406, 41.2268148181819, 0),
                    new Vector(-74.825204, 41.2827048181819, 0),
                    new Vector(-74.794145, 41.2952148181818, 0),
                    new Vector(-74.791661, 41.3119638181819, 0),
                    new Vector(-74.700068, 41.3505738181819, 0),
                    new Vector(-74.70527, 41.3750628181818, 0),
                    new Vector(-74.740433, 41.4016398181819, 0),
                    new Vector(-74.740037, 41.4220608181819, 0),
                    new Vector(-74.754824, 41.4301428181818, 0),
                    new Vector(-74.792804, 41.4299178181818, 0),
                    new Vector(-74.86406599999999, 41.447152818182, 0),
                    new Vector(-74.895278, 41.4446688181818, 0),
                    new Vector(-74.898563, 41.4618948181819, 0),
                    new Vector(-74.9325649999999, 41.4843588181818, 0),
                    new Vector(-74.97178700000001, 41.4836028181818, 0),
                    new Vector(-75.014888, 41.5395558181818, 0),
                    new Vector(-75.025094, 41.5657998181818, 0),
                    new Vector(-75.06986000000001, 41.6044818181819, 0),
                    new Vector(-75.072452, 41.6130858181818, 0),
                    new Vector(-75.051329, 41.6373138181819, 0),
                    new Vector(-75.06539600000001, 41.7148398181818, 0),
                    new Vector(-75.056972, 41.7267108181819, 0),
                    new Vector(-75.061319, 41.770261818182, 0),
                    new Vector(-75.0971569999999, 41.7790458181819, 0),
                    new Vector(-75.0968239999999, 41.797207818182, 0),
                    new Vector(-75.079841, 41.8141458181819, 0),
                    new Vector(-75.11777600000001, 41.8369788181819, 0),
                    new Vector(-75.124751, 41.8491828181818, 0),
                    new Vector(-75.148286, 41.8557888181819, 0),
                    new Vector(-75.17128099999999, 41.8678398181819, 0),
                    new Vector(-75.25452199999999, 41.8688748181819, 0),
                    new Vector(-75.283691, 41.9475978181819, 0),
                    new Vector(-75.324065, 41.9612688181819, 0),
                    new Vector(-75.34565600000001, 41.9928498181819, 0),
                    new Vector(-75.382808, 41.9983578181818, 0),
                    new Vector(-75.479738, 41.9963598181819, 0),
                    new Vector(-76.104833, 41.9995008181818, 0),
                    new Vector(-76.14501799999999, 42.0006528181818, 0),
                    new Vector(-76.563914, 42.0030108181818, 0),
                    new Vector(-76.928387, 42.0025338181818, 0),
                    new Vector(-76.9685719999999, 42.0029838181819, 0),
                    new Vector(-77.612846, 41.9988258181818, 0),
                    new Vector(-77.74501100000001, 41.9973408181818, 0),
                    new Vector(-78.204263, 41.9981958181819, 0),
                    new Vector(-78.30509000000001, 41.9994198181819, 0),
                    new Vector(-78.918539, 41.9998428181819, 0),
                    new Vector(-79.059488, 42.0011568181819, 0),
                    new Vector(-79.61236700000001, 42.0005808181819, 0),
                    new Vector(-79.761668, 42.0031098181819, 0),
                    new Vector(-79.763234, 42.2673228181819, 0),
                    new Vector(-80.52059300000001, 41.9868738181819, 0),
                    new Vector(-80.522645, 41.8507758181818, 0),
                    new Vector(-80.5239229999999, 41.4950958181818, 0),
                    new Vector(-80.519999, 41.4892908181819, 0),
                    new Vector(-80.5229329999999, 41.1296238181818, 0),
                    new Vector(-80.266631, 41.1290838181819, 0),
                    new Vector(-80.26928599999999, 41.1190398181818, 0),
                    new Vector(-80.15258299999989, 41.1142518181818, 0),
                    new Vector(-80.105144, 41.0684778181818, 0),
                    new Vector(-80.003984, 41.1726258181818, 0),
                    new Vector(-79.697588, 41.1746328181819, 0),
                    new Vector(-79.681316, 41.1617538181818, 0),
                    new Vector(-79.68110900000001, 41.0954958181819, 0),
                    new Vector(-79.66443200000001, 41.0690088181819, 0),
                    new Vector(-79.67186599999999, 41.0525478181818, 0),
                    new Vector(-79.630988, 41.0310018181818, 0),
                    new Vector(-79.59793999999999, 41.0256468181818, 0),
                    new Vector(-79.615994, 41.0185368181818, 0),
                    new Vector(-79.61577800000001, 41.0112828181819, 0),
                    new Vector(-79.590551, 41.0026158181819, 0),
                    new Vector(-79.58772500000001, 40.9895028181819, 0),
                    new Vector(-79.628576, 40.9910958181819, 0),
                    new Vector(-79.6127359999999, 40.9704948181818, 0),
                    new Vector(-79.556495, 40.9832118181819, 0),
                    new Vector(-79.533041, 40.9722408181818, 0),
                    new Vector(-79.518857, 40.9869918181818, 0),
                    new Vector(-79.507094, 40.9799088181817, 0),
                    new Vector(-79.497473, 40.9841478181818, 0),
                    new Vector(-79.485197, 41.0024898181819, 0),
                    new Vector(-79.46617999999999, 40.9973328181819, 0),
                    new Vector(-79.456091, 40.984777818182, 0),
                    new Vector(-79.431332, 40.9924278181818, 0),
                    new Vector(-79.423457, 41.0161428181818, 0),
                    new Vector(-79.423727, 41.0034348181818, 0),
                    new Vector(-79.410884, 41.0013558181819, 0),
                    new Vector(-79.410605, 40.9913838181819, 0),
                    new Vector(-79.38525199999999, 40.9994748181819, 0),
                    new Vector(-79.385621, 40.9903938181819, 0),
                    new Vector(-79.39904900000001, 40.9915548181818, 0),
                    new Vector(-79.3826779999999, 40.9713768181819, 0),
                    new Vector(-79.361546, 41.0007258181818, 0),
                    new Vector(-79.325609, 41.0003388181819, 0),
                    new Vector(-79.31123599999999, 41.0100768181819, 0),
                    new Vector(-79.290401, 41.0049198181819, 0),
                    new Vector(-79.27451600000001, 41.0269248181818, 0),
                    new Vector(-79.25867599999999, 41.0266908181819, 0),
                    new Vector(-79.237769, 41.0437638181819, 0),
                    new Vector(-79.21654700000001, 41.0476788181819, 0),
                    new Vector(-79.22063300000001, 40.9155858181818, 0),
                    new Vector(-78.80697499999999, 40.9082508181819, 0),
                    new Vector(-78.80733499999999, 40.7304198181818, 0),
                    new Vector(-78.79082, 40.722868818182, 0),
                    new Vector(-78.361493, 40.7255958181818, 0),
                    new Vector(-78.37133900000001, 40.7377818181818, 0),
                    new Vector(-78.14092100000001, 40.7464128181819, 0),
                    new Vector(-78.12631399999999, 40.7419488181818, 0),
                    new Vector(-77.956745, 40.6905048181819, 0),
                    new Vector(-77.889668, 40.7261088181818, 0),
                    new Vector(-77.82484100000001, 40.7403558181819, 0),
                    new Vector(-77.76714200000001, 40.7218878181818, 0),
                    new Vector(-77.71377200000001, 40.7219868181818, 0),
                    new Vector(-77.68893199999999, 40.7302038181819, 0),
                    new Vector(-77.36362699999999, 40.8550158181819, 0),
                    new Vector(-77.3600629999999, 40.8114648181819, 0),
                    new Vector(-77.065808, 40.8734118181818, 0),
                    new Vector(-77.03187800000001, 40.8565098181818, 0),
                    new Vector(-77.01291500000001, 40.8754908181818, 0),
                    new Vector(-76.99471699999999, 40.8717918181819, 0),
                    new Vector(-76.939898, 40.8874338181818, 0),
                    new Vector(-76.908956, 40.8805038181819, 0),
                    new Vector(-76.82808199999999, 40.8850848181818, 0),
                    new Vector(-76.81290799999999, 40.8822858181819, 0),
                    new Vector(-76.813304, 40.8423618181818, 0),
                    new Vector(-76.84394, 40.8134898181818, 0),
                    new Vector(-76.864901, 40.7782188181819, 0),
                    new Vector(-76.8496279999999, 40.7227968181818, 0),
                    new Vector(-76.895546, 40.6713168181819, 0),
                    new Vector(-76.922933, 40.6569258181819, 0),
                    new Vector(-76.938233, 40.6379448181819, 0),
                    new Vector(-76.94385800000001, 40.6166508181818, 0),
                    new Vector(-76.933013, 40.6088928181819, 0),
                    new Vector(-76.90698500000001, 40.6083258181819, 0),
                    new Vector(-76.859537, 40.632580818182, 0),
                    new Vector(-76.84567699999999, 40.6252548181819, 0),
                    new Vector(-76.817165, 40.6300968181818, 0),
                    new Vector(-76.80608599999999, 40.6486278181819, 0),
                    new Vector(-76.79158700000001, 40.6435608181819, 0),
                    new Vector(-76.714439, 40.6639728181818, 0),
                    new Vector(-76.697537, 40.6579698181818, 0),
                    new Vector(-76.696871, 40.6634058181818, 0),
                    new Vector(-76.39031300000001, 40.7767788181819, 0),
                    new Vector(-76.313939, 40.8064788181819, 0),
                    new Vector(-76.286489, 40.8847068181818, 0),
                    new Vector(-76.2111409999999, 40.9497588181819, 0),
                    new Vector(-76.029611, 40.9019598181818, 0),
                    new Vector(-75.99716600000001, 40.9124718181819, 0),
                    new Vector(-75.915644, 40.8320928181818, 0),
                    new Vector(-75.765434, 40.7394018181819, 0),
                    new Vector(-75.6972049999999, 40.7742948181819, 0),
                    new Vector(-75.618554, 40.7876688181818, 0),
                    new Vector(-75.483041, 40.8137238181818, 0)
                })
            }
        };
    }
}