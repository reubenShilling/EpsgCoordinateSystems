namespace EpsgCoordinateSystems.Other
{
    public class Dealul_Piscului_1933_Stereo_33 : IEpsgCoordinateSystem
    {
        public string Name => "Dealul Piscului 1933/ Stereo 33";
        public long Srid => 31600;

        public string OgcWkt =>
            "PROJCS[Dealul Piscului 1933/ Stereo 33,GEOGCS[Dealul Piscului 1933,DATUM[Dealul_Piscului_1933,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6316]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4316]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,45.9],PARAMETER[central_meridian,25.39246588888889],PARAMETER[scale_factor,0.9996667],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,31600],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Dealul Piscului 1933/ Stereo 33,GEOGCS[Dealul Piscului 1933,DATUM[Dealul_Piscului_1933,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6316]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4316]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,45.9],PARAMETER[central_meridian,25.39246588888889],PARAMETER[scale_factor,0.9996667],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,31600],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}