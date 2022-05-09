using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_New_York_Central_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2261;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / New York Central (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",40],PARAMETER[\"central_meridian\",-76.58333333333333],PARAMETER[\"scale_factor\",0.9999375],PARAMETER[\"false_easting\",820208.3330000002],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2261\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / New York Central (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",40],PARAMETER[\"central_meridian\",-76.58333333333333],PARAMETER[\"scale_factor\",0.9999375],PARAMETER[\"false_easting\",820208.3330000002],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.0025338181818, -76.928387),
                    new Vector(42.0030108181818, -76.563914),
                    new Vector(42.0006528181818, -76.14501799999999),
                    new Vector(41.9995008181818, -76.104833),
                    new Vector(41.9963598181819, -75.479738),
                    new Vector(41.9983578181818, -75.382808),
                    new Vector(42.0153678181818, -75.40600999999999),
                    new Vector(42.0573708181819, -75.427241),
                    new Vector(42.194161818182, -75.42138199999999),
                    new Vector(42.3219528181818, -75.410357),
                    new Vector(42.3603288181819, -75.391268),
                    new Vector(42.3910908181818, -75.403058),
                    new Vector(42.4250388181819, -75.3732949999999),
                    new Vector(42.4725138181819, -75.39537199999999),
                    new Vector(42.5061738181818, -75.392933),
                    new Vector(42.5167758181818, -75.378839),
                    new Vector(42.544594818182, -75.37005499999999),
                    new Vector(42.5713248181819, -75.33385699999999),
                    new Vector(42.6191868181818, -75.32105900000001),
                    new Vector(42.6655458181819, -75.32132),
                    new Vector(42.7486338181819, -75.28607599999989),
                    new Vector(42.7880448181818, -75.254324),
                    new Vector(42.8372568181818, -75.24334399999989),
                    new Vector(42.8735448181819, -75.252128),
                    new Vector(42.8813388181818, -75.24538699999989),
                    new Vector(42.8852808181818, -75.21293300000001),
                    new Vector(43.0635348181819, -75.21419299999999),
                    new Vector(43.2303948181819, -75.068168),
                    new Vector(43.2439758181819, -75.12998),
                    new Vector(43.2530298181819, -75.135164),
                    new Vector(43.2523728181819, -75.15779000000001),
                    new Vector(43.2600858181818, -75.161687),
                    new Vector(43.3006848181819, -75.149168),
                    new Vector(43.3105128181819, -75.11723600000001),
                    new Vector(43.3079118181818, -75.101468),
                    new Vector(43.3148058181818, -75.092765),
                    new Vector(43.3265958181819, -75.09735499999999),
                    new Vector(43.3271988181819, -75.08036300000001),
                    new Vector(43.6113648181819, -75.115211),
                    new Vector(44.0928108181819, -75.16387400000001),
                    new Vector(44.2148868181818, -75.447221),
                    new Vector(44.3902608181818, -75.848027),
                    new Vector(44.0983548181818, -76.362881),
                    new Vector(44.0420148181819, -76.29688400000001),
                    new Vector(44.0656038181818, -76.20154700000001),
                    new Vector(44.0132238181818, -76.13451499999999),
                    new Vector(43.9322058181818, -76.12906099999989),
                    new Vector(43.9124868181818, -76.19371700000001),
                    new Vector(43.8351228181818, -76.23999499999999),
                    new Vector(43.682698818182, -76.20565999999999),
                    new Vector(43.6331988181819, -76.184573),
                    new Vector(43.5541518181819, -76.22275999999989),
                    new Vector(43.5007188181818, -76.454654),
                    new Vector(43.4141568181819, -76.619624),
                    new Vector(43.3234458181819, -76.71847099999999),
                    new Vector(43.3427328181818, -76.736831),
                    new Vector(43.2785988181819, -76.91452700000001),
                    new Vector(43.275709818182, -77.37731599999999),
                    new Vector(43.0363908181818, -77.364968),
                    new Vector(43.0351488181819, -77.4821929999999),
                    new Vector(42.9446628181819, -77.479511),
                    new Vector(42.9455898181818, -77.57977099999989),
                    new Vector(42.8790528181818, -77.550665),
                    new Vector(42.8597658181819, -77.557181),
                    new Vector(42.8562198181818, -77.587025),
                    new Vector(42.7679478181818, -77.58744799999999),
                    new Vector(42.7671198181819, -77.617391),
                    new Vector(42.6753288181818, -77.597627),
                    new Vector(42.6742848181819, -77.485253),
                    new Vector(42.5830608181818, -77.495),
                    new Vector(42.5850228181818, -77.655254),
                    new Vector(42.5409048181818, -77.655416),
                    new Vector(42.5392038181818, -77.715734),
                    new Vector(42.4712718181818, -77.72144),
                    new Vector(41.9973408181818, -77.74501100000001),
                    new Vector(41.9988258181818, -77.612846),
                    new Vector(42.0029838181819, -76.9685719999999),
                    new Vector(42.0025338181818, -76.928387)
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