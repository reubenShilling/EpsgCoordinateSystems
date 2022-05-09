using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_Hampshire_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 3437;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Hampshire";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Hampshire (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,3437],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Hampshire (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.8670648181819, -70.813886),
                    new Vector(43.0587648181819, -70.734137),
                    new Vector(43.0897338181819, -70.81043),
                    new Vector(43.0588818181818, -70.886489),
                    new Vector(43.0840188181819, -70.905416),
                    new Vector(43.1015238181818, -70.874627),
                    new Vector(43.1277048181818, -70.884743),
                    new Vector(43.1218728181819, -70.818665),
                    new Vector(43.1591688181819, -70.830545),
                    new Vector(43.2352188181819, -70.813211),
                    new Vector(43.2810198181818, -70.9010779999999),
                    new Vector(43.3020708181818, -70.90580300000001),
                    new Vector(43.3663848181818, -70.969703),
                    new Vector(43.3961838181818, -70.97909900000001),
                    new Vector(43.4381238181818, -70.96148599999999),
                    new Vector(43.470208818182, -70.970792),
                    new Vector(43.5163878181819, -70.959281),
                    new Vector(43.5319938181819, -70.96426700000001),
                    new Vector(43.5489588181819, -70.94961499999999),
                    new Vector(43.5641418181819, -70.95652699999999),
                    new Vector(43.5718278181819, -70.97387000000001),
                    new Vector(43.7911668181818, -70.98444499999999),
                    new Vector(44.2821438181819, -71.008601),
                    new Vector(44.6685408181818, -71.02872499999999),
                    new Vector(45.30147481818191, -71.087513),
                    new Vector(45.2379708181819, -71.153087),
                    new Vector(45.2934918181818, -71.29724),
                    new Vector(45.2349288181819, -71.386385),
                    new Vector(45.2360808181818, -71.446568),
                    new Vector(45.2027988181819, -71.402522),
                    new Vector(45.1169928181819, -71.430413),
                    new Vector(45.0598878181819, -71.50299800000001),
                    new Vector(45.0133578181819, -71.505374),
                    new Vector(44.9765658181818, -71.540924),
                    new Vector(44.9436978181819, -71.516975),
                    new Vector(44.8996698181818, -71.506364),
                    new Vector(44.8160148181819, -71.575097),
                    new Vector(44.779195818182, -71.58350299999999),
                    new Vector(44.7417108181818, -71.63114),
                    new Vector(44.6778648181818, -71.607686),
                    new Vector(44.6506038181819, -71.588741),
                    new Vector(44.6374458181819, -71.568023),
                    new Vector(44.5965948181819, -71.55410000000001),
                    new Vector(44.5789278181819, -71.536793),
                    new Vector(44.5511988181819, -71.5922869999999),
                    new Vector(44.5388688181819, -71.591441),
                    new Vector(44.5258098181818, -71.57524100000001),
                    new Vector(44.4945348181819, -71.586617),
                    new Vector(44.4745098181818, -71.61422899999999),
                    new Vector(44.4767238181819, -71.63655799999999),
                    new Vector(44.4691728181818, -71.64770900000001),
                    new Vector(44.4401388181819, -71.656403),
                    new Vector(44.4213468181819, -71.676878),
                    new Vector(44.3982438181819, -71.766572),
                    new Vector(44.3841768181819, -71.79773),
                    new Vector(44.3503638181819, -71.821202),
                    new Vector(44.344198818182, -71.834819),
                    new Vector(44.3361078181819, -71.928365),
                    new Vector(44.3257848181818, -71.938913),
                    new Vector(44.3275488181819, -71.994434),
                    new Vector(44.2994328181819, -72.035492),
                    new Vector(44.2614888181819, -72.059567),
                    new Vector(44.2343808181818, -72.044393),
                    new Vector(44.1821718181818, -72.059279),
                    new Vector(44.1564408181819, -72.044726),
                    new Vector(44.1207468181818, -72.034916),
                    new Vector(44.1004518181817, -72.049514),
                    new Vector(44.0960958181819, -72.03244100000001),
                    new Vector(44.0833698181818, -72.034727),
                    new Vector(44.0320338181819, -72.076919),
                    new Vector(44.0089308181819, -72.085199),
                    new Vector(43.9892298181818, -72.10991300000001),
                    new Vector(43.9765218181819, -72.11281099999989),
                    new Vector(43.9579908181819, -72.091706),
                    new Vector(43.9391628181819, -72.113198),
                    new Vector(43.9092198181819, -72.12164900000001),
                    new Vector(43.8789168181819, -72.170087),
                    new Vector(43.8016878181819, -72.184838),
                    new Vector(43.7646348181819, -72.206087),
                    new Vector(43.7506938181818, -72.219128),
                    new Vector(43.7353038181819, -72.260051),
                    new Vector(43.698529818182, -72.304034),
                    new Vector(43.5973608181819, -72.33308599999989),
                    new Vector(43.5723768181819, -72.373496),
                    new Vector(43.5175578181819, -72.394997),
                    new Vector(43.4846268181819, -72.382514),
                    new Vector(43.4101518181818, -72.396248),
                    new Vector(43.3771308181819, -72.4121329999999),
                    new Vector(43.3510128181818, -72.39762500000001),
                    new Vector(43.3234008181819, -72.4102249999999),
                    new Vector(43.3073808181819, -72.402422),
                    new Vector(43.2322578181819, -72.435596),
                    new Vector(43.1560188181818, -72.452399),
                    new Vector(43.1162748181818, -72.437612),
                    new Vector(43.0790328181818, -72.443462),
                    new Vector(43.0464978181819, -72.461759),
                    new Vector(42.9995988181818, -72.45716),
                    new Vector(42.9761448181819, -72.473342),
                    new Vector(42.9655788181819, -72.504266),
                    new Vector(42.9516738181818, -72.520214),
                    new Vector(42.9126138181819, -72.52481299999999),
                    new Vector(42.8606478181819, -72.55342400000001),
                    new Vector(42.8077368181818, -72.538916),
                    new Vector(42.7892598181817, -72.513068),
                    new Vector(42.7687398181819, -72.507272),
                    new Vector(42.7615938181818, -72.47931800000001),
                    new Vector(42.7468338181819, -72.46217300000001),
                    new Vector(42.7258548181819, -72.45577400000001),
                    new Vector(42.7204638181819, -72.27991400000001),
                    new Vector(42.7072068181819, -71.93021899999999),
                    new Vector(42.7053798181819, -71.900942),
                    new Vector(42.6986028181818, -71.287187),
                    new Vector(42.7260708181818, -71.252411),
                    new Vector(42.7435578181818, -71.240486),
                    new Vector(42.738760818182, -71.186342),
                    new Vector(42.8073138181818, -71.181068),
                    new Vector(42.8182848181818, -71.120597),
                    new Vector(42.8043168181818, -71.065562),
                    new Vector(42.8511708181818, -71.025431),
                    new Vector(42.8851458181819, -70.92133699999999),
                    new Vector(42.8868828181818, -70.89810799999999),
                    new Vector(42.8634288181819, -70.849733),
                    new Vector(42.8670648181819, -70.813886)
                })
            }
        };
    }
}