using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_New_York_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2260;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / New York East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",38.83333333333334],PARAMETER[\"central_meridian\",-74.5],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",492125],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2260\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / New York East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",38.83333333333334],PARAMETER[\"central_meridian\",-74.5],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",492125],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.665681818182, -73.517144),
                    new Vector(42.0474258181819, -73.48423099999999),
                    new Vector(42.0774678181818, -73.49883800000001),
                    new Vector(42.5047518181819, -73.350824),
                    new Vector(42.7460508181819, -73.258061),
                    new Vector(42.7474818181818, -73.26927499999989),
                    new Vector(42.8035428181819, -73.296176),
                    new Vector(42.837103818182, -73.27958),
                    new Vector(42.9402888181818, -73.27600700000001),
                    new Vector(43.310854818182, -73.2500689999999),
                    new Vector(43.5128328181819, -73.238387),
                    new Vector(43.5593808181818, -73.259978),
                    new Vector(43.5750408181818, -73.291397),
                    new Vector(43.5931938181819, -73.28174),
                    new Vector(43.6196538181819, -73.29409699999999),
                    new Vector(43.6247208181819, -73.303538),
                    new Vector(43.6150008181818, -73.363685),
                    new Vector(43.5691458181819, -73.38812),
                    new Vector(43.5824838181818, -73.41831500000001),
                    new Vector(43.6321188181819, -73.422968),
                    new Vector(43.7142798181818, -73.3709929999999),
                    new Vector(43.7565528181818, -73.356674),
                    new Vector(43.7784228181818, -73.358996),
                    new Vector(43.8045048181819, -73.384736),
                    new Vector(43.8859818181819, -73.37511499999989),
                    new Vector(43.9148088181819, -73.405337),
                    new Vector(43.9882038181818, -73.417406),
                    new Vector(44.0182188181819, -73.408253),
                    new Vector(44.045677818182, -73.43599999999989),
                    new Vector(44.0639028181819, -73.43521699999999),
                    new Vector(44.1066078181818, -73.40875699999999),
                    new Vector(44.1362268181819, -73.407866),
                    new Vector(44.1721098181818, -73.382063),
                    new Vector(44.2012428181818, -73.37733799999999),
                    new Vector(44.2601478181818, -73.305329),
                    new Vector(44.3673918181818, -73.329791),
                    new Vector(44.4055338181818, -73.299992),
                    new Vector(44.4328578181818, -73.293314),
                    new Vector(44.5443228181818, -73.3344529999999),
                    new Vector(44.5539708181818, -73.347809),
                    new Vector(44.5791618181819, -73.37129899999999),
                    new Vector(44.6198058181818, -73.381829),
                    new Vector(44.6343498181819, -73.370138),
                    new Vector(44.6612688181818, -73.373099),
                    new Vector(44.6803758181817, -73.358159),
                    new Vector(44.7242328181817, -73.373153),
                    new Vector(44.7992928181819, -73.326785),
                    new Vector(44.8191198181819, -73.369058),
                    new Vector(44.8479378181818, -73.382306),
                    new Vector(44.9326008181818, -73.336415),
                    new Vector(44.9819748181819, -73.350752),
                    new Vector(45.0061398181819, -73.344731),
                    new Vector(44.9908488181818, -74.02154),
                    new Vector(44.9929188181819, -74.736113),
                    new Vector(44.9486298181818, -74.968475),
                    new Vector(44.8106238181819, -75.328862),
                    new Vector(44.5175388181819, -75.758657),
                    new Vector(44.3902608181818, -75.848027),
                    new Vector(44.2148868181818, -75.447221),
                    new Vector(44.0928108181819, -75.16387400000001),
                    new Vector(43.6113648181819, -75.115211),
                    new Vector(43.3271988181819, -75.08036300000001),
                    new Vector(43.3265958181819, -75.09735499999999),
                    new Vector(43.3148058181818, -75.092765),
                    new Vector(43.3079118181818, -75.101468),
                    new Vector(43.3105128181819, -75.11723600000001),
                    new Vector(43.3006848181819, -75.149168),
                    new Vector(43.2600858181818, -75.161687),
                    new Vector(43.2523728181819, -75.15779000000001),
                    new Vector(43.2530298181819, -75.135164),
                    new Vector(43.2439758181819, -75.12998),
                    new Vector(43.2303948181819, -75.068168),
                    new Vector(43.0635348181819, -75.21419299999999),
                    new Vector(42.8852808181818, -75.21293300000001),
                    new Vector(42.8813388181818, -75.24538699999989),
                    new Vector(42.8735448181819, -75.252128),
                    new Vector(42.8372568181818, -75.24334399999989),
                    new Vector(42.7880448181818, -75.254324),
                    new Vector(42.7486338181819, -75.28607599999989),
                    new Vector(42.6655458181819, -75.32132),
                    new Vector(42.6191868181818, -75.32105900000001),
                    new Vector(42.5713248181819, -75.33385699999999),
                    new Vector(42.544594818182, -75.37005499999999),
                    new Vector(42.5167758181818, -75.378839),
                    new Vector(42.5061738181818, -75.392933),
                    new Vector(42.4725138181819, -75.39537199999999),
                    new Vector(42.4250388181819, -75.3732949999999),
                    new Vector(42.3910908181818, -75.403058),
                    new Vector(42.3603288181819, -75.391268),
                    new Vector(42.3219528181818, -75.410357),
                    new Vector(42.194161818182, -75.42138199999999),
                    new Vector(42.0573708181819, -75.427241),
                    new Vector(42.0153678181818, -75.40600999999999),
                    new Vector(41.9983578181818, -75.382808),
                    new Vector(41.9928498181819, -75.34565600000001),
                    new Vector(41.9612688181819, -75.324065),
                    new Vector(41.9475978181819, -75.283691),
                    new Vector(41.8688748181819, -75.25452199999999),
                    new Vector(41.8678398181819, -75.17128099999999),
                    new Vector(41.8557888181819, -75.148286),
                    new Vector(41.8491828181818, -75.124751),
                    new Vector(41.8369788181819, -75.11777600000001),
                    new Vector(41.8141458181819, -75.079841),
                    new Vector(41.797207818182, -75.0968239999999),
                    new Vector(41.7790458181819, -75.0971569999999),
                    new Vector(41.770261818182, -75.061319),
                    new Vector(41.7267108181819, -75.056972),
                    new Vector(41.7148398181818, -75.06539600000001),
                    new Vector(41.6373138181819, -75.051329),
                    new Vector(41.6130858181818, -75.072452),
                    new Vector(41.6044818181819, -75.06986000000001),
                    new Vector(41.5657998181818, -75.025094),
                    new Vector(41.5395558181818, -75.014888),
                    new Vector(41.4836028181818, -74.97178700000001),
                    new Vector(41.4843588181818, -74.9325649999999),
                    new Vector(41.4618948181819, -74.898563),
                    new Vector(41.4446688181818, -74.895278),
                    new Vector(41.447152818182, -74.86406599999999),
                    new Vector(41.4299178181818, -74.792804),
                    new Vector(41.4301428181818, -74.754824),
                    new Vector(41.4220608181819, -74.740037),
                    new Vector(41.4016398181819, -74.740433),
                    new Vector(41.3750628181818, -74.70527),
                    new Vector(41.3505738181819, -74.700068),
                    new Vector(41.1958548181819, -74.371982),
                    new Vector(41.137624818182, -74.24236399999999),
                    new Vector(41.1236118181819, -74.213033),
                    new Vector(40.9985298181819, -73.89670099999999),
                    new Vector(40.9608738181819, -73.8961429999999),
                    new Vector(40.9273218181819, -73.908968),
                    new Vector(40.9081878181818, -73.8378589999999),
                    new Vector(40.8927438181819, -73.824521),
                    new Vector(40.8866868181818, -73.78004300000001),
                    new Vector(40.9983948181819, -73.65315200000001),
                    new Vector(41.0126148181819, -73.653728),
                    new Vector(41.1003558181819, -73.725233),
                    new Vector(41.2107588181819, -73.47812),
                    new Vector(41.2936218181819, -73.550264),
                    new Vector(41.3652978181818, -73.5442879999999),
                    new Vector(41.5227438181818, -73.53039200000001),
                    new Vector(41.665681818182, -73.517144)
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