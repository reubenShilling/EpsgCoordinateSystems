namespace EpsgCoordinateSystems.Other
{
    public class Kertau_1968_Singapore_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Kertau 1968 / Singapore Grid";
        public long Srid => 24500;

        public string OgcWkt =>
            "PROJCS[Kertau 1968 / Singapore Grid,GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,1.287646666666667],PARAMETER[central_meridian,103.8530022222222],PARAMETER[false_easting,30000],PARAMETER[false_northing,30000],AUTHORITY[EPSG,24500],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Kertau 1968 / Singapore Grid,GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,1.287646666666667],PARAMETER[central_meridian,103.8530022222222],PARAMETER[false_easting,30000],PARAMETER[false_northing,30000],AUTHORITY[EPSG,24500],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}