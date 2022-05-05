using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Pennsylvania_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2272;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Pennsylvania South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Pennsylvania South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.96666666666667],PARAMETER[standard_parallel_2,39.93333333333333],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-77.75],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2272],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Pennsylvania South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,40.96666666666667],PARAMETER[standard_parallel_2,39.93333333333333],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-77.75],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-78.33455600000001, 39.7241028181818, 0),
                    new Vector(-78.09594800000001, 39.7254618181819, 0),
                    new Vector(-77.47579399999999, 39.7196298181819, 0),
                    new Vector(-77.46443600000001, 39.7200708181817, 0),
                    new Vector(-77.221058, 39.7206828181818, 0),
                    new Vector(-76.9968049999999, 39.7208898181818, 0),
                    new Vector(-76.79048899999999, 39.7212588181818, 0),
                    new Vector(-76.569836, 39.7202598181819, 0),
                    new Vector(-76.233119, 39.7218528181818, 0),
                    new Vector(-76.139231, 39.7222308181818, 0),
                    new Vector(-75.791093, 39.7238598181819, 0),
                    new Vector(-75.774929, 39.7245528181819, 0),
                    new Vector(-75.7455889999999, 39.7749258181819, 0),
                    new Vector(-75.69477500000001, 39.8204568181819, 0),
                    new Vector(-75.64398799999999, 39.8383128181819, 0),
                    new Vector(-75.583445, 39.840121818182, 0),
                    new Vector(-75.469982, 39.8265498181818, 0),
                    new Vector(-75.420464, 39.7989828181818, 0),
                    new Vector(-75.3459349999999, 39.8485188181818, 0),
                    new Vector(-75.253739, 39.8455398181819, 0),
                    new Vector(-75.246989, 39.8504088181819, 0),
                    new Vector(-75.185609, 39.8774088181819, 0),
                    new Vector(-75.142904, 39.8816028181819, 0),
                    new Vector(-75.135812, 39.8968938181819, 0),
                    new Vector(-75.147161, 39.9347388181819, 0),
                    new Vector(-75.13986199999989, 39.9559158181818, 0),
                    new Vector(-75.110963, 39.9766878181819, 0),
                    new Vector(-75.084593, 39.9757338181818, 0),
                    new Vector(-75.06804200000001, 39.9853908181819, 0),
                    new Vector(-75.045677, 40.0076388181818, 0),
                    new Vector(-74.98347800000001, 40.0340718181819, 0),
                    new Vector(-74.956199, 40.0580208181819, 0),
                    new Vector(-74.8719229999999, 40.0780548181818, 0),
                    new Vector(-74.82902, 40.1161608181819, 0),
                    new Vector(-74.746292, 40.1243508181818, 0),
                    new Vector(-74.72548399999989, 40.1493078181817, 0),
                    new Vector(-74.738831, 40.1777298181819, 0),
                    new Vector(-74.84276300000001, 40.2484518181819, 0),
                    new Vector(-74.880662, 40.2995898181818, 0),
                    new Vector(-74.921153, 40.3140348181819, 0),
                    new Vector(-74.932502, 40.3337718181819, 0),
                    new Vector(-74.950187, 40.3454718181819, 0),
                    new Vector(-74.9728489999999, 40.4044488181818, 0),
                    new Vector(-75.00047000000001, 40.4086158181818, 0),
                    new Vector(-75.02126, 40.4013258181819, 0),
                    new Vector(-75.057458, 40.4201718181819, 0),
                    new Vector(-75.070121, 40.456252818182, 0),
                    new Vector(-75.063686, 40.5209988181819, 0),
                    new Vector(-75.079778, 40.5453528181819, 0),
                    new Vector(-75.124526, 40.5648018181819, 0),
                    new Vector(-75.18227899999999, 40.5568008181819, 0),
                    new Vector(-75.1975699999999, 40.5706788181819, 0),
                    new Vector(-75.193511, 40.5837738181818, 0),
                    new Vector(-75.20038700000001, 40.6147428181819, 0),
                    new Vector(-75.19793900000001, 40.6342098181819, 0),
                    new Vector(-75.20891899999999, 40.6507338181819, 0),
                    new Vector(-75.184061, 40.6697868181818, 0),
                    new Vector(-75.205355, 40.6860678181819, 0),
                    new Vector(-75.18775100000001, 40.7238588181818, 0),
                    new Vector(-75.193646, 40.7479968181818, 0),
                    new Vector(-75.170309, 40.7748078181819, 0),
                    new Vector(-75.13032200000001, 40.7727108181819, 0),
                    new Vector(-75.10054100000001, 40.7916648181819, 0),
                    new Vector(-75.08920999999989, 40.8213918181819, 0),
                    new Vector(-75.099542, 40.8392838181819, 0),
                    new Vector(-75.054614, 40.8556728181819, 0),
                    new Vector(-75.056495, 40.8720438181819, 0),
                    new Vector(-75.073685, 40.8846258181819, 0),
                    new Vector(-75.079733, 40.9033458181819, 0),
                    new Vector(-75.135524, 40.9629348181819, 0),
                    new Vector(-75.247304, 40.9123188181819, 0),
                    new Vector(-75.29996300000001, 40.8615048181817, 0),
                    new Vector(-75.483041, 40.8137238181818, 0),
                    new Vector(-75.618554, 40.7876688181818, 0),
                    new Vector(-75.6972049999999, 40.7742948181819, 0),
                    new Vector(-75.765434, 40.7394018181819, 0),
                    new Vector(-75.915644, 40.8320928181818, 0),
                    new Vector(-75.99716600000001, 40.9124718181819, 0),
                    new Vector(-76.029611, 40.9019598181818, 0),
                    new Vector(-76.2111409999999, 40.9497588181819, 0),
                    new Vector(-76.286489, 40.8847068181818, 0),
                    new Vector(-76.313939, 40.8064788181819, 0),
                    new Vector(-76.39031300000001, 40.7767788181819, 0),
                    new Vector(-76.696871, 40.6634058181818, 0),
                    new Vector(-76.697537, 40.6579698181818, 0),
                    new Vector(-76.714439, 40.6639728181818, 0),
                    new Vector(-76.79158700000001, 40.6435608181819, 0),
                    new Vector(-76.80608599999999, 40.6486278181819, 0),
                    new Vector(-76.817165, 40.6300968181818, 0),
                    new Vector(-76.84567699999999, 40.6252548181819, 0),
                    new Vector(-76.859537, 40.632580818182, 0),
                    new Vector(-76.90698500000001, 40.6083258181819, 0),
                    new Vector(-76.933013, 40.6088928181819, 0),
                    new Vector(-76.94385800000001, 40.6166508181818, 0),
                    new Vector(-76.938233, 40.6379448181819, 0),
                    new Vector(-76.922933, 40.6569258181819, 0),
                    new Vector(-76.895546, 40.6713168181819, 0),
                    new Vector(-76.8496279999999, 40.7227968181818, 0),
                    new Vector(-76.864901, 40.7782188181819, 0),
                    new Vector(-76.84394, 40.8134898181818, 0),
                    new Vector(-76.813304, 40.8423618181818, 0),
                    new Vector(-76.81290799999999, 40.8822858181819, 0),
                    new Vector(-76.82808199999999, 40.8850848181818, 0),
                    new Vector(-76.908956, 40.8805038181819, 0),
                    new Vector(-76.939898, 40.8874338181818, 0),
                    new Vector(-76.99471699999999, 40.8717918181819, 0),
                    new Vector(-77.01291500000001, 40.8754908181818, 0),
                    new Vector(-77.03187800000001, 40.8565098181818, 0),
                    new Vector(-77.065808, 40.8734118181818, 0),
                    new Vector(-77.3600629999999, 40.8114648181819, 0),
                    new Vector(-77.36362699999999, 40.8550158181819, 0),
                    new Vector(-77.68893199999999, 40.7302038181819, 0),
                    new Vector(-77.71377200000001, 40.7219868181818, 0),
                    new Vector(-77.76714200000001, 40.7218878181818, 0),
                    new Vector(-77.82484100000001, 40.7403558181819, 0),
                    new Vector(-77.889668, 40.7261088181818, 0),
                    new Vector(-77.956745, 40.6905048181819, 0),
                    new Vector(-78.12631399999999, 40.7419488181818, 0),
                    new Vector(-78.14092100000001, 40.7464128181819, 0),
                    new Vector(-78.37133900000001, 40.7377818181818, 0),
                    new Vector(-78.361493, 40.7255958181818, 0),
                    new Vector(-78.79082, 40.722868818182, 0),
                    new Vector(-78.80733499999999, 40.7304198181818, 0),
                    new Vector(-78.80697499999999, 40.9082508181819, 0),
                    new Vector(-79.22063300000001, 40.9155858181818, 0),
                    new Vector(-79.21654700000001, 41.0476788181819, 0),
                    new Vector(-79.237769, 41.0437638181819, 0),
                    new Vector(-79.25867599999999, 41.0266908181819, 0),
                    new Vector(-79.27451600000001, 41.0269248181818, 0),
                    new Vector(-79.290401, 41.0049198181819, 0),
                    new Vector(-79.31123599999999, 41.0100768181819, 0),
                    new Vector(-79.325609, 41.0003388181819, 0),
                    new Vector(-79.361546, 41.0007258181818, 0),
                    new Vector(-79.3826779999999, 40.9713768181819, 0),
                    new Vector(-79.39904900000001, 40.9915548181818, 0),
                    new Vector(-79.385621, 40.9903938181819, 0),
                    new Vector(-79.38525199999999, 40.9994748181819, 0),
                    new Vector(-79.410605, 40.9913838181819, 0),
                    new Vector(-79.410884, 41.0013558181819, 0),
                    new Vector(-79.423727, 41.0034348181818, 0),
                    new Vector(-79.423457, 41.0161428181818, 0),
                    new Vector(-79.431332, 40.9924278181818, 0),
                    new Vector(-79.456091, 40.984777818182, 0),
                    new Vector(-79.46617999999999, 40.9973328181819, 0),
                    new Vector(-79.485197, 41.0024898181819, 0),
                    new Vector(-79.497473, 40.9841478181818, 0),
                    new Vector(-79.507094, 40.9799088181817, 0),
                    new Vector(-79.518857, 40.9869918181818, 0),
                    new Vector(-79.533041, 40.9722408181818, 0),
                    new Vector(-79.556495, 40.9832118181819, 0),
                    new Vector(-79.6127359999999, 40.9704948181818, 0),
                    new Vector(-79.628576, 40.9910958181819, 0),
                    new Vector(-79.58772500000001, 40.9895028181819, 0),
                    new Vector(-79.590551, 41.0026158181819, 0),
                    new Vector(-79.61577800000001, 41.0112828181819, 0),
                    new Vector(-79.615994, 41.0185368181818, 0),
                    new Vector(-79.59793999999999, 41.0256468181818, 0),
                    new Vector(-79.630988, 41.0310018181818, 0),
                    new Vector(-79.67186599999999, 41.0525478181818, 0),
                    new Vector(-79.66443200000001, 41.0690088181819, 0),
                    new Vector(-79.68110900000001, 41.0954958181819, 0),
                    new Vector(-79.681316, 41.1617538181818, 0),
                    new Vector(-79.697588, 41.1746328181819, 0),
                    new Vector(-80.003984, 41.1726258181818, 0),
                    new Vector(-80.105144, 41.0684778181818, 0),
                    new Vector(-80.15258299999989, 41.1142518181818, 0),
                    new Vector(-80.26928599999999, 41.1190398181818, 0),
                    new Vector(-80.266631, 41.1290838181819, 0),
                    new Vector(-80.5229329999999, 41.1296238181818, 0),
                    new Vector(-80.520926, 40.8972708181818, 0),
                    new Vector(-80.52030499999989, 40.8541698181818, 0),
                    new Vector(-80.521997, 40.6371978181819, 0),
                    new Vector(-80.524355, 40.4787798181819, 0),
                    new Vector(-80.523563, 40.4030358181818, 0),
                    new Vector(-80.52604700000001, 40.1625198181819, 0),
                    new Vector(-80.524967, 40.0228308181819, 0),
                    new Vector(-80.524652, 39.9584178181819, 0),
                    new Vector(-80.52427400000001, 39.7212048181818, 0),
                    new Vector(-80.429081, 39.7198458181818, 0),
                    new Vector(-79.918268, 39.7216638181819, 0),
                    new Vector(-79.76513300000001, 39.7218078181818, 0),
                    new Vector(-79.480976, 39.7202688181818, 0),
                    new Vector(-79.39661, 39.7193058181819, 0),
                    new Vector(-78.930176, 39.7223388181818, 0),
                    new Vector(-78.817757, 39.7231218181818, 0),
                    new Vector(-78.38478499999999, 39.7237428181818, 0),
                    new Vector(-78.33455600000001, 39.7241028181818, 0)
                })
            }
        };
    }
}