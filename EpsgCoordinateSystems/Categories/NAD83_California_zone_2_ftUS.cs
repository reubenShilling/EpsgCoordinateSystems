using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_2_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2226;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "California zone 2";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / California zone 2 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,39.83333333333334],PARAMETER[standard_parallel_2,38.33333333333334],PARAMETER[latitude_of_origin,37.66666666666666],PARAMETER[central_meridian,-122],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2226],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / California zone 2 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,39.83333333333334],PARAMETER[standard_parallel_2,38.33333333333334],PARAMETER[latitude_of_origin,37.66666666666666],PARAMETER[central_meridian,-122],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-119.628041, 38.338183818182, 0),
                    new Vector(-119.609537, 38.3621508181819, 0),
                    new Vector(-119.612435, 38.3942898181818, 0),
                    new Vector(-119.562836, 38.4039468181819, 0),
                    new Vector(-119.555618, 38.4158808181818, 0),
                    new Vector(-119.556023, 38.4612048181819, 0),
                    new Vector(-119.54678, 38.4827058181819, 0),
                    new Vector(-119.554268, 38.5120278181818, 0),
                    new Vector(-119.615612, 38.6150148181819, 0),
                    new Vector(-119.607269, 38.6623458181818, 0),
                    new Vector(-119.575679, 38.7029088181818, 0),
                    new Vector(-119.889347, 38.9222568181819, 0),
                    new Vector(-119.995259, 38.9941128181818, 0),
                    new Vector(-119.995151, 39.0634938181819, 0),
                    new Vector(-119.994548, 39.1061268181817, 0),
                    new Vector(-119.995529, 39.1587048181819, 0),
                    new Vector(-119.995304, 39.3115428181817, 0),
                    new Vector(-119.996006, 39.4435008181818, 0),
                    new Vector(-119.996168, 39.7206108181819, 0),
                    new Vector(-120.014087, 39.7201788181818, 0),
                    new Vector(-120.013664, 39.7097568181819, 0),
                    new Vector(-120.139907, 39.7102788181818, 0),
                    new Vector(-120.45632, 39.7087668181819, 0),
                    new Vector(-120.457715, 39.7005588181819, 0),
                    new Vector(-120.635978, 39.700486818182, 0),
                    new Vector(-120.670151, 39.6781848181819, 0),
                    new Vector(-120.710966, 39.7041948181818, 0),
                    new Vector(-120.745463, 39.7117908181818, 0),
                    new Vector(-120.789626, 39.7095588181819, 0),
                    new Vector(-120.846587, 39.7677078181819, 0),
                    new Vector(-120.864731, 39.770776818182, 0),
                    new Vector(-120.883595, 39.7543068181819, 0),
                    new Vector(-120.919613, 39.7450188181818, 0),
                    new Vector(-120.939035, 39.6731808181818, 0),
                    new Vector(-121.000613, 39.6294858181819, 0),
                    new Vector(-121.071533, 39.5940708181819, 0),
                    new Vector(-121.080371, 39.5919738181819, 0),
                    new Vector(-121.08272, 39.6123048181819, 0),
                    new Vector(-121.110683, 39.6100368181819, 0),
                    new Vector(-121.111259, 39.6199998181818, 0),
                    new Vector(-121.129799, 39.6202878181819, 0),
                    new Vector(-121.132184, 39.6515268181818, 0),
                    new Vector(-121.148303, 39.6509868181819, 0),
                    new Vector(-121.156925, 39.6656838181818, 0),
                    new Vector(-121.167626, 39.6648648181819, 0),
                    new Vector(-121.167878, 39.6793818181819, 0),
                    new Vector(-121.184636, 39.6792738181818, 0),
                    new Vector(-121.185365, 39.6919548181817, 0),
                    new Vector(-121.203338, 39.6922608181819, 0),
                    new Vector(-121.205507, 39.7194138181819, 0),
                    new Vector(-121.226441, 39.7191618181819, 0),
                    new Vector(-121.227287, 39.7336518181819, 0),
                    new Vector(-121.242785, 39.7322298181819, 0),
                    new Vector(-121.245404, 39.7462068181819, 0),
                    new Vector(-121.262162, 39.7460898181818, 0),
                    new Vector(-121.264241, 39.7609938181818, 0),
                    new Vector(-121.280396, 39.7608948181818, 0),
                    new Vector(-121.293293, 39.7863198181819, 0),
                    new Vector(-121.313975, 39.7915128181819, 0),
                    new Vector(-121.313417, 39.8019708181819, 0),
                    new Vector(-121.330238, 39.8027538181819, 0),
                    new Vector(-121.331039, 39.8158848181819, 0),
                    new Vector(-121.348427, 39.8161908181818, 0),
                    new Vector(-121.35911, 39.8539458181818, 0),
                    new Vector(-121.403273, 39.8601198181819, 0),
                    new Vector(-121.405343, 39.8940858181819, 0),
                    new Vector(-121.418582, 39.8945268181818, 0),
                    new Vector(-121.418186, 39.9077028181819, 0),
                    new Vector(-121.402652, 39.9087018181819, 0),
                    new Vector(-121.411256, 39.9510648181819, 0),
                    new Vector(-121.402319, 39.9522798181819, 0),
                    new Vector(-121.401446, 39.9772728181818, 0),
                    new Vector(-121.411094, 39.9778488181819, 0),
                    new Vector(-121.409366, 39.9987828181818, 0),
                    new Vector(-121.418951, 39.9979908181818, 0),
                    new Vector(-121.417169, 40.0180248181818, 0),
                    new Vector(-121.405802, 40.0188798181818, 0),
                    new Vector(-121.397, 40.0418838181818, 0),
                    new Vector(-121.378397, 40.0425408181818, 0),
                    new Vector(-121.377902, 40.0638798181819, 0),
                    new Vector(-121.367039, 40.0633488181819, 0),
                    new Vector(-121.368596, 40.0791798181818, 0),
                    new Vector(-121.388945, 40.0870908181818, 0),
                    new Vector(-121.387811, 40.0980258181818, 0),
                    new Vector(-121.40456, 40.0965408181819, 0),
                    new Vector(-121.403849, 40.1533038181818, 0),
                    new Vector(-121.424945, 40.1539248181818, 0),
                    new Vector(-121.441748, 40.1528808181818, 0),
                    new Vector(-121.439687, 40.1293458181819, 0),
                    new Vector(-121.448102, 40.1290488181818, 0),
                    new Vector(-121.447508, 40.1195358181819, 0),
                    new Vector(-121.462565, 40.1194548181819, 0),
                    new Vector(-121.462673, 40.111732818182, 0),
                    new Vector(-121.483184, 40.1123718181819, 0),
                    new Vector(-121.483247, 40.1037498181819, 0),
                    new Vector(-121.586207, 40.0950468181819, 0),
                    new Vector(-121.582094, 40.0588848181818, 0),
                    new Vector(-121.595576, 40.0533948181819, 0),
                    new Vector(-121.600508, 40.0364208181819, 0),
                    new Vector(-121.617833, 40.0348728181819, 0),
                    new Vector(-121.616789, 40.0185738181819, 0),
                    new Vector(-121.624583, 40.0182948181819, 0),
                    new Vector(-121.625033, 39.9973878181819, 0),
                    new Vector(-121.637012, 39.9964878181818, 0),
                    new Vector(-121.638893, 39.9791718181819, 0),
                    new Vector(-121.703657, 39.9772278181818, 0),
                    new Vector(-121.7372, 39.9301218181819, 0),
                    new Vector(-121.752626, 39.8909448181819, 0),
                    new Vector(-121.766351, 39.8808918181818, 0),
                    new Vector(-122.063648, 39.8842398181819, 0),
                    new Vector(-122.065529, 39.8682738181819, 0),
                    new Vector(-122.040149, 39.8742858181818, 0),
                    new Vector(-122.033246, 39.8700288181818, 0),
                    new Vector(-122.04914, 39.8571228181819, 0),
                    new Vector(-122.054945, 39.8373678181819, 0),
                    new Vector(-122.05202, 39.8043468181819, 0),
                    new Vector(-122.040563, 39.7948158181818, 0),
                    new Vector(-122.928674, 39.7959228181819, 0),
                    new Vector(-122.949635, 39.8462598181818, 0),
                    new Vector(-122.940707, 39.8980098181819, 0),
                    new Vector(-122.919269, 39.9149208181819, 0),
                    new Vector(-122.91026, 39.9367008181819, 0),
                    new Vector(-122.933003, 39.9792348181818, 0),
                    new Vector(-123.533681, 39.9775968181818, 0),
                    new Vector(-123.536732, 39.9978918181818, 0),
                    new Vector(-124.007639, 39.9985848181818, 0),
                    new Vector(-123.838115, 39.8263968181818, 0),
                    new Vector(-123.783539, 39.6871128181818, 0),
                    new Vector(-123.754649, 39.5518788181818, 0),
                    new Vector(-123.813716, 39.3478128181818, 0),
                    new Vector(-123.683441, 39.0418128181818, 0),
                    new Vector(-123.721898, 38.9247768181818, 0),
                    new Vector(-123.523889, 38.7576648181819, 0),
                    new Vector(-123.297944, 38.5473348181819, 0),
                    new Vector(-123.121544, 38.4336018181819, 0),
                    new Vector(-123.048797, 38.2941468181818, 0),
                    new Vector(-122.994644, 38.2972248181817, 0),
                    new Vector(-122.965655, 38.3122908181819, 0),
                    new Vector(-122.935379, 38.3083038181819, 0),
                    new Vector(-122.895284, 38.3138658181818, 0),
                    new Vector(-122.729729, 38.2031928181819, 0),
                    new Vector(-122.710487, 38.2050018181819, 0),
                    new Vector(-122.634617, 38.1794418181818, 0),
                    new Vector(-122.564687, 38.1853638181819, 0),
                    new Vector(-122.528642, 38.1506688181818, 0),
                    new Vector(-122.488934, 38.1134178181818, 0),
                    new Vector(-122.42921, 38.1138048181818, 0),
                    new Vector(-122.398466, 38.1613338181819, 0),
                    new Vector(-122.272772, 38.0974788181819, 0),
                    new Vector(-122.285354, 38.1593088181818, 0),
                    new Vector(-122.338913, 38.1935808181819, 0),
                    new Vector(-122.315756, 38.2059378181819, 0),
                    new Vector(-122.272997, 38.1594168181819, 0),
                    new Vector(-122.232245, 38.0710818181819, 0),
                    new Vector(-121.984547, 38.1394998181819, 0),
                    new Vector(-121.902773, 38.0729088181819, 0),
                    new Vector(-121.782371, 38.0667708181819, 0),
                    new Vector(-121.665209, 38.1692808181818, 0),
                    new Vector(-121.659593, 38.0964618181818, 0),
                    new Vector(-121.554158, 38.1373668181818, 0),
                    new Vector(-121.526735, 38.1545388181819, 0),
                    new Vector(-121.515008, 38.1926268181819, 0),
                    new Vector(-121.464851, 38.2548078181819, 0),
                    new Vector(-121.42202, 38.254546818182, 0),
                    new Vector(-121.400132, 38.2321908181819, 0),
                    new Vector(-121.319015, 38.2291758181819, 0),
                    new Vector(-121.266806, 38.2491468181819, 0),
                    new Vector(-121.197344, 38.2447278181818, 0),
                    new Vector(-121.158554, 38.2537638181818, 0),
                    new Vector(-121.092458, 38.2886478181819, 0),
                    new Vector(-121.016165, 38.2993308181819, 0),
                    new Vector(-120.98381, 38.2223538181819, 0),
                    new Vector(-120.906581, 38.2252878181819, 0),
                    new Vector(-120.878744, 38.2198248181818, 0),
                    new Vector(-120.841988, 38.2572648181818, 0),
                    new Vector(-120.795917, 38.2850118181818, 0),
                    new Vector(-120.752141, 38.2895298181819, 0),
                    new Vector(-120.630452, 38.3326398181819, 0),
                    new Vector(-120.600806, 38.3625378181819, 0),
                    new Vector(-120.597611, 38.3930208181819, 0),
                    new Vector(-120.514361, 38.4217308181818, 0),
                    new Vector(-120.488333, 38.4428808181819, 0),
                    new Vector(-120.426485, 38.4654708181819, 0),
                    new Vector(-120.327656, 38.4650118181819, 0),
                    new Vector(-120.207776, 38.4940368181818, 0),
                    new Vector(-120.142967, 38.4916248181819, 0),
                    new Vector(-120.068924, 38.5079958181818, 0),
                    new Vector(-120.071435, 38.4412788181818, 0),
                    new Vector(-120.04997, 38.4481638181819, 0),
                    new Vector(-120.015212, 38.4322338181818, 0),
                    new Vector(-119.868323, 38.3586678181818, 0),
                    new Vector(-119.83928, 38.3665878181818, 0),
                    new Vector(-119.78951, 38.4012828181819, 0),
                    new Vector(-119.740208, 38.4182568181818, 0),
                    new Vector(-119.709023, 38.4171408181818, 0),
                    new Vector(-119.690204, 38.4003198181818, 0),
                    new Vector(-119.683022, 38.3646528181818, 0),
                    new Vector(-119.655239, 38.3434938181819, 0),
                    new Vector(-119.628041, 38.338183818182, 0)
                })
            }
        };
    }
}