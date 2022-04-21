namespace EpsgCoordinateSystems.Other
{
    public class Dealul_Piscului_1970_Stereo_70 : IEpsgCoordinateSystem
    {
        public string Name => "Dealul Piscului 1970/ Stereo 70";
        public long Srid => 31700;

        public string OgcWkt =>
            "PROJCS[Dealul Piscului 1970/ Stereo 70,GEOGCS[Dealul Piscului 1970,DATUM[Dealul_Piscului_1970,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6317]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4317]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,46],PARAMETER[central_meridian,25],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,31700],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Dealul Piscului 1970/ Stereo 70,GEOGCS[Dealul Piscului 1970,DATUM[Dealul_Piscului_1970,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6317]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4317]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,46],PARAMETER[central_meridian,25],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,31700],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}