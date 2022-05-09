using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_1_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2225;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "California zone 1";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / California zone 1 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.66666666666666],PARAMETER[standard_parallel_2,40],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-122],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2225],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / California zone 1 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.66666666666666],PARAMETER[standard_parallel_2,40],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-122],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.7948158181818, -122.040563),
                    new Vector(39.8043468181819, -122.05202),
                    new Vector(39.8373678181819, -122.054945),
                    new Vector(39.8571228181819, -122.04914),
                    new Vector(39.8700288181818, -122.033246),
                    new Vector(39.8742858181818, -122.040149),
                    new Vector(39.8682738181819, -122.065529),
                    new Vector(39.8842398181819, -122.063648),
                    new Vector(39.8808918181818, -121.766351),
                    new Vector(39.8909448181819, -121.752626),
                    new Vector(39.9301218181819, -121.7372),
                    new Vector(39.9772278181818, -121.703657),
                    new Vector(39.9791718181819, -121.638893),
                    new Vector(39.9964878181818, -121.637012),
                    new Vector(39.9973878181819, -121.625033),
                    new Vector(40.0182948181819, -121.624583),
                    new Vector(40.0185738181819, -121.616789),
                    new Vector(40.0348728181819, -121.617833),
                    new Vector(40.0364208181819, -121.600508),
                    new Vector(40.0533948181819, -121.595576),
                    new Vector(40.0588848181818, -121.582094),
                    new Vector(40.0950468181819, -121.586207),
                    new Vector(40.1037498181819, -121.483247),
                    new Vector(40.1123718181819, -121.483184),
                    new Vector(40.111732818182, -121.462673),
                    new Vector(40.1194548181819, -121.462565),
                    new Vector(40.1195358181819, -121.447508),
                    new Vector(40.1290488181818, -121.448102),
                    new Vector(40.1293458181819, -121.439687),
                    new Vector(40.1528808181818, -121.441748),
                    new Vector(40.1539248181818, -121.424945),
                    new Vector(40.1533038181818, -121.403849),
                    new Vector(40.0965408181819, -121.40456),
                    new Vector(40.0980258181818, -121.387811),
                    new Vector(40.0870908181818, -121.388945),
                    new Vector(40.0791798181818, -121.368596),
                    new Vector(40.0633488181819, -121.367039),
                    new Vector(40.0638798181819, -121.377902),
                    new Vector(40.0425408181818, -121.378397),
                    new Vector(40.0418838181818, -121.397),
                    new Vector(40.0188798181818, -121.405802),
                    new Vector(40.0180248181818, -121.417169),
                    new Vector(39.9979908181818, -121.418951),
                    new Vector(39.9987828181818, -121.409366),
                    new Vector(39.9778488181819, -121.411094),
                    new Vector(39.9772728181818, -121.401446),
                    new Vector(39.9522798181819, -121.402319),
                    new Vector(39.9510648181819, -121.411256),
                    new Vector(39.9087018181819, -121.402652),
                    new Vector(39.9077028181819, -121.418186),
                    new Vector(39.8945268181818, -121.418582),
                    new Vector(39.8940858181819, -121.405343),
                    new Vector(39.8601198181819, -121.403273),
                    new Vector(39.8539458181818, -121.35911),
                    new Vector(39.8161908181818, -121.348427),
                    new Vector(39.8158848181819, -121.331039),
                    new Vector(39.8027538181819, -121.330238),
                    new Vector(39.8019708181819, -121.313417),
                    new Vector(39.7915128181819, -121.313975),
                    new Vector(39.7863198181819, -121.293293),
                    new Vector(39.7608948181818, -121.280396),
                    new Vector(39.7609938181818, -121.264241),
                    new Vector(39.7460898181818, -121.262162),
                    new Vector(39.7462068181819, -121.245404),
                    new Vector(39.7322298181819, -121.242785),
                    new Vector(39.7336518181819, -121.227287),
                    new Vector(39.7191618181819, -121.226441),
                    new Vector(39.7194138181819, -121.205507),
                    new Vector(39.6922608181819, -121.203338),
                    new Vector(39.6919548181817, -121.185365),
                    new Vector(39.6792738181818, -121.184636),
                    new Vector(39.6793818181819, -121.167878),
                    new Vector(39.6648648181819, -121.167626),
                    new Vector(39.6656838181818, -121.156925),
                    new Vector(39.6509868181819, -121.148303),
                    new Vector(39.6515268181818, -121.132184),
                    new Vector(39.6202878181819, -121.129799),
                    new Vector(39.6199998181818, -121.111259),
                    new Vector(39.6100368181819, -121.110683),
                    new Vector(39.6123048181819, -121.08272),
                    new Vector(39.5919738181819, -121.080371),
                    new Vector(39.5940708181819, -121.071533),
                    new Vector(39.6294858181819, -121.000613),
                    new Vector(39.6731808181818, -120.939035),
                    new Vector(39.7450188181818, -120.919613),
                    new Vector(39.7543068181819, -120.883595),
                    new Vector(39.770776818182, -120.864731),
                    new Vector(39.7677078181819, -120.846587),
                    new Vector(39.7095588181819, -120.789626),
                    new Vector(39.7117908181818, -120.745463),
                    new Vector(39.7041948181818, -120.710966),
                    new Vector(39.6781848181819, -120.670151),
                    new Vector(39.700486818182, -120.635978),
                    new Vector(39.7005588181819, -120.457715),
                    new Vector(39.7087668181819, -120.45632),
                    new Vector(39.7102788181818, -120.139907),
                    new Vector(39.7097568181819, -120.013664),
                    new Vector(39.7201788181818, -120.014087),
                    new Vector(39.7206108181819, -119.996168),
                    new Vector(41.1775668181818, -119.99633),
                    new Vector(41.9892048181819, -119.993468),
                    new Vector(41.9876748181818, -120.871913),
                    new Vector(41.9943348181818, -121.441505),
                    new Vector(42.0007608181818, -122.284706),
                    new Vector(42.0021918181819, -123.222101),
                    new Vector(41.9978358181818, -123.513197),
                    new Vector(41.9929488181819, -123.819143),
                    new Vector(41.9976468181817, -124.206458),
                    new Vector(41.8483278181818, -124.207502),
                    new Vector(41.7767508181819, -124.243106),
                    new Vector(41.7271878181819, -124.144205),
                    new Vector(41.4581598181818, -124.057958),
                    new Vector(41.3138358181819, -124.071602),
                    new Vector(41.1288408181819, -124.149704),
                    new Vector(40.9782078181819, -124.109447),
                    new Vector(40.4352378181819, -124.392632),
                    new Vector(40.3275528181818, -124.336121),
                    new Vector(40.2524298181819, -124.34531),
                    new Vector(40.1003838181819, -124.094552),
                    new Vector(39.9985848181818, -124.007639),
                    new Vector(39.9978918181818, -123.536732),
                    new Vector(39.9775968181818, -123.533681),
                    new Vector(39.9792348181818, -122.933003),
                    new Vector(39.9367008181819, -122.91026),
                    new Vector(39.9149208181819, -122.919269),
                    new Vector(39.8980098181819, -122.940707),
                    new Vector(39.8462598181818, -122.949635),
                    new Vector(39.7959228181819, -122.928674),
                    new Vector(39.7948158181818, -122.040563)
                })
            }
        };
    }
}