using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_York_Central_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2261;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York Central";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New York Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-76.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,820208.3330000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,2261],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New York Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-76.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,820208.3330000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-76.928387, 42.0025338181818, 0),
                    new Vector(-76.563914, 42.0030108181818, 0),
                    new Vector(-76.14501799999999, 42.0006528181818, 0),
                    new Vector(-76.104833, 41.9995008181818, 0),
                    new Vector(-75.479738, 41.9963598181819, 0),
                    new Vector(-75.382808, 41.9983578181818, 0),
                    new Vector(-75.40600999999999, 42.0153678181818, 0),
                    new Vector(-75.427241, 42.0573708181819, 0),
                    new Vector(-75.42138199999999, 42.194161818182, 0),
                    new Vector(-75.410357, 42.3219528181818, 0),
                    new Vector(-75.391268, 42.3603288181819, 0),
                    new Vector(-75.403058, 42.3910908181818, 0),
                    new Vector(-75.3732949999999, 42.4250388181819, 0),
                    new Vector(-75.39537199999999, 42.4725138181819, 0),
                    new Vector(-75.392933, 42.5061738181818, 0),
                    new Vector(-75.378839, 42.5167758181818, 0),
                    new Vector(-75.37005499999999, 42.544594818182, 0),
                    new Vector(-75.33385699999999, 42.5713248181819, 0),
                    new Vector(-75.32105900000001, 42.6191868181818, 0),
                    new Vector(-75.32132, 42.6655458181819, 0),
                    new Vector(-75.28607599999989, 42.7486338181819, 0),
                    new Vector(-75.254324, 42.7880448181818, 0),
                    new Vector(-75.24334399999989, 42.8372568181818, 0),
                    new Vector(-75.252128, 42.8735448181819, 0),
                    new Vector(-75.24538699999989, 42.8813388181818, 0),
                    new Vector(-75.21293300000001, 42.8852808181818, 0),
                    new Vector(-75.21419299999999, 43.0635348181819, 0),
                    new Vector(-75.068168, 43.2303948181819, 0),
                    new Vector(-75.12998, 43.2439758181819, 0),
                    new Vector(-75.135164, 43.2530298181819, 0),
                    new Vector(-75.15779000000001, 43.2523728181819, 0),
                    new Vector(-75.161687, 43.2600858181818, 0),
                    new Vector(-75.149168, 43.3006848181819, 0),
                    new Vector(-75.11723600000001, 43.3105128181819, 0),
                    new Vector(-75.101468, 43.3079118181818, 0),
                    new Vector(-75.092765, 43.3148058181818, 0),
                    new Vector(-75.09735499999999, 43.3265958181819, 0),
                    new Vector(-75.08036300000001, 43.3271988181819, 0),
                    new Vector(-75.115211, 43.6113648181819, 0),
                    new Vector(-75.16387400000001, 44.0928108181819, 0),
                    new Vector(-75.447221, 44.2148868181818, 0),
                    new Vector(-75.848027, 44.3902608181818, 0),
                    new Vector(-76.362881, 44.0983548181818, 0),
                    new Vector(-76.29688400000001, 44.0420148181819, 0),
                    new Vector(-76.20154700000001, 44.0656038181818, 0),
                    new Vector(-76.13451499999999, 44.0132238181818, 0),
                    new Vector(-76.12906099999989, 43.9322058181818, 0),
                    new Vector(-76.19371700000001, 43.9124868181818, 0),
                    new Vector(-76.23999499999999, 43.8351228181818, 0),
                    new Vector(-76.20565999999999, 43.682698818182, 0),
                    new Vector(-76.184573, 43.6331988181819, 0),
                    new Vector(-76.22275999999989, 43.5541518181819, 0),
                    new Vector(-76.454654, 43.5007188181818, 0),
                    new Vector(-76.619624, 43.4141568181819, 0),
                    new Vector(-76.71847099999999, 43.3234458181819, 0),
                    new Vector(-76.736831, 43.3427328181818, 0),
                    new Vector(-76.91452700000001, 43.2785988181819, 0),
                    new Vector(-77.37731599999999, 43.275709818182, 0),
                    new Vector(-77.364968, 43.0363908181818, 0),
                    new Vector(-77.4821929999999, 43.0351488181819, 0),
                    new Vector(-77.479511, 42.9446628181819, 0),
                    new Vector(-77.57977099999989, 42.9455898181818, 0),
                    new Vector(-77.550665, 42.8790528181818, 0),
                    new Vector(-77.557181, 42.8597658181819, 0),
                    new Vector(-77.587025, 42.8562198181818, 0),
                    new Vector(-77.58744799999999, 42.7679478181818, 0),
                    new Vector(-77.617391, 42.7671198181819, 0),
                    new Vector(-77.597627, 42.6753288181818, 0),
                    new Vector(-77.485253, 42.6742848181819, 0),
                    new Vector(-77.495, 42.5830608181818, 0),
                    new Vector(-77.655254, 42.5850228181818, 0),
                    new Vector(-77.655416, 42.5409048181818, 0),
                    new Vector(-77.715734, 42.5392038181818, 0),
                    new Vector(-77.72144, 42.4712718181818, 0),
                    new Vector(-77.74501100000001, 41.9973408181818, 0),
                    new Vector(-77.612846, 41.9988258181818, 0),
                    new Vector(-76.9685719999999, 42.0029838181819, 0),
                    new Vector(-76.928387, 42.0025338181818, 0)
                })
            }
        };
    }
}