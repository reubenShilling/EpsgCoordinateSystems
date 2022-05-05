using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_Hampshire_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3437;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "New Hampshire";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / New Hampshire (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,3437],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / New Hampshire (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-70.813886, 42.8670648181819, 0),
                    new Vector(-70.734137, 43.0587648181819, 0),
                    new Vector(-70.81043, 43.0897338181819, 0),
                    new Vector(-70.886489, 43.0588818181818, 0),
                    new Vector(-70.905416, 43.0840188181819, 0),
                    new Vector(-70.874627, 43.1015238181818, 0),
                    new Vector(-70.884743, 43.1277048181818, 0),
                    new Vector(-70.818665, 43.1218728181819, 0),
                    new Vector(-70.830545, 43.1591688181819, 0),
                    new Vector(-70.813211, 43.2352188181819, 0),
                    new Vector(-70.9010779999999, 43.2810198181818, 0),
                    new Vector(-70.90580300000001, 43.3020708181818, 0),
                    new Vector(-70.969703, 43.3663848181818, 0),
                    new Vector(-70.97909900000001, 43.3961838181818, 0),
                    new Vector(-70.96148599999999, 43.4381238181818, 0),
                    new Vector(-70.970792, 43.470208818182, 0),
                    new Vector(-70.959281, 43.5163878181819, 0),
                    new Vector(-70.96426700000001, 43.5319938181819, 0),
                    new Vector(-70.94961499999999, 43.5489588181819, 0),
                    new Vector(-70.95652699999999, 43.5641418181819, 0),
                    new Vector(-70.97387000000001, 43.5718278181819, 0),
                    new Vector(-70.98444499999999, 43.7911668181818, 0),
                    new Vector(-71.008601, 44.2821438181819, 0),
                    new Vector(-71.02872499999999, 44.6685408181818, 0),
                    new Vector(-71.087513, 45.30147481818191, 0),
                    new Vector(-71.153087, 45.2379708181819, 0),
                    new Vector(-71.29724, 45.2934918181818, 0),
                    new Vector(-71.386385, 45.2349288181819, 0),
                    new Vector(-71.446568, 45.2360808181818, 0),
                    new Vector(-71.402522, 45.2027988181819, 0),
                    new Vector(-71.430413, 45.1169928181819, 0),
                    new Vector(-71.50299800000001, 45.0598878181819, 0),
                    new Vector(-71.505374, 45.0133578181819, 0),
                    new Vector(-71.540924, 44.9765658181818, 0),
                    new Vector(-71.516975, 44.9436978181819, 0),
                    new Vector(-71.506364, 44.8996698181818, 0),
                    new Vector(-71.575097, 44.8160148181819, 0),
                    new Vector(-71.58350299999999, 44.779195818182, 0),
                    new Vector(-71.63114, 44.7417108181818, 0),
                    new Vector(-71.607686, 44.6778648181818, 0),
                    new Vector(-71.588741, 44.6506038181819, 0),
                    new Vector(-71.568023, 44.6374458181819, 0),
                    new Vector(-71.55410000000001, 44.5965948181819, 0),
                    new Vector(-71.536793, 44.5789278181819, 0),
                    new Vector(-71.5922869999999, 44.5511988181819, 0),
                    new Vector(-71.591441, 44.5388688181819, 0),
                    new Vector(-71.57524100000001, 44.5258098181818, 0),
                    new Vector(-71.586617, 44.4945348181819, 0),
                    new Vector(-71.61422899999999, 44.4745098181818, 0),
                    new Vector(-71.63655799999999, 44.4767238181819, 0),
                    new Vector(-71.64770900000001, 44.4691728181818, 0),
                    new Vector(-71.656403, 44.4401388181819, 0),
                    new Vector(-71.676878, 44.4213468181819, 0),
                    new Vector(-71.766572, 44.3982438181819, 0),
                    new Vector(-71.79773, 44.3841768181819, 0),
                    new Vector(-71.821202, 44.3503638181819, 0),
                    new Vector(-71.834819, 44.344198818182, 0),
                    new Vector(-71.928365, 44.3361078181819, 0),
                    new Vector(-71.938913, 44.3257848181818, 0),
                    new Vector(-71.994434, 44.3275488181819, 0),
                    new Vector(-72.035492, 44.2994328181819, 0),
                    new Vector(-72.059567, 44.2614888181819, 0),
                    new Vector(-72.044393, 44.2343808181818, 0),
                    new Vector(-72.059279, 44.1821718181818, 0),
                    new Vector(-72.044726, 44.1564408181819, 0),
                    new Vector(-72.034916, 44.1207468181818, 0),
                    new Vector(-72.049514, 44.1004518181817, 0),
                    new Vector(-72.03244100000001, 44.0960958181819, 0),
                    new Vector(-72.034727, 44.0833698181818, 0),
                    new Vector(-72.076919, 44.0320338181819, 0),
                    new Vector(-72.085199, 44.0089308181819, 0),
                    new Vector(-72.10991300000001, 43.9892298181818, 0),
                    new Vector(-72.11281099999989, 43.9765218181819, 0),
                    new Vector(-72.091706, 43.9579908181819, 0),
                    new Vector(-72.113198, 43.9391628181819, 0),
                    new Vector(-72.12164900000001, 43.9092198181819, 0),
                    new Vector(-72.170087, 43.8789168181819, 0),
                    new Vector(-72.184838, 43.8016878181819, 0),
                    new Vector(-72.206087, 43.7646348181819, 0),
                    new Vector(-72.219128, 43.7506938181818, 0),
                    new Vector(-72.260051, 43.7353038181819, 0),
                    new Vector(-72.304034, 43.698529818182, 0),
                    new Vector(-72.33308599999989, 43.5973608181819, 0),
                    new Vector(-72.373496, 43.5723768181819, 0),
                    new Vector(-72.394997, 43.5175578181819, 0),
                    new Vector(-72.382514, 43.4846268181819, 0),
                    new Vector(-72.396248, 43.4101518181818, 0),
                    new Vector(-72.4121329999999, 43.3771308181819, 0),
                    new Vector(-72.39762500000001, 43.3510128181818, 0),
                    new Vector(-72.4102249999999, 43.3234008181819, 0),
                    new Vector(-72.402422, 43.3073808181819, 0),
                    new Vector(-72.435596, 43.2322578181819, 0),
                    new Vector(-72.452399, 43.1560188181818, 0),
                    new Vector(-72.437612, 43.1162748181818, 0),
                    new Vector(-72.443462, 43.0790328181818, 0),
                    new Vector(-72.461759, 43.0464978181819, 0),
                    new Vector(-72.45716, 42.9995988181818, 0),
                    new Vector(-72.473342, 42.9761448181819, 0),
                    new Vector(-72.504266, 42.9655788181819, 0),
                    new Vector(-72.520214, 42.9516738181818, 0),
                    new Vector(-72.52481299999999, 42.9126138181819, 0),
                    new Vector(-72.55342400000001, 42.8606478181819, 0),
                    new Vector(-72.538916, 42.8077368181818, 0),
                    new Vector(-72.513068, 42.7892598181817, 0),
                    new Vector(-72.507272, 42.7687398181819, 0),
                    new Vector(-72.47931800000001, 42.7615938181818, 0),
                    new Vector(-72.46217300000001, 42.7468338181819, 0),
                    new Vector(-72.45577400000001, 42.7258548181819, 0),
                    new Vector(-72.27991400000001, 42.7204638181819, 0),
                    new Vector(-71.93021899999999, 42.7072068181819, 0),
                    new Vector(-71.900942, 42.7053798181819, 0),
                    new Vector(-71.287187, 42.6986028181818, 0),
                    new Vector(-71.252411, 42.7260708181818, 0),
                    new Vector(-71.240486, 42.7435578181818, 0),
                    new Vector(-71.186342, 42.738760818182, 0),
                    new Vector(-71.181068, 42.8073138181818, 0),
                    new Vector(-71.120597, 42.8182848181818, 0),
                    new Vector(-71.065562, 42.8043168181818, 0),
                    new Vector(-71.025431, 42.8511708181818, 0),
                    new Vector(-70.92133699999999, 42.8851458181819, 0),
                    new Vector(-70.89810799999999, 42.8868828181818, 0),
                    new Vector(-70.849733, 42.8634288181819, 0),
                    new Vector(-70.813886, 42.8670648181819, 0)
                })
            }
        };
    }
}