namespace EpsgCoordinateSystems.Other
{
    public class Kertau_1968_UTM_zone_48N : IEpsgCoordinateSystem
    {
        public string Name => "Kertau 1968 / UTM zone 48N";
        public long Srid => 24548;

        public string OgcWkt =>
            "PROJCS[Kertau 1968 / UTM zone 48N,GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24548],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Kertau 1968 / UTM zone 48N,GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24548],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}