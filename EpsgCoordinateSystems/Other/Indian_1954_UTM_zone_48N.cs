namespace EpsgCoordinateSystems.Other
{
    public class Indian_1954_UTM_zone_48N : IEpsgCoordinateSystem
    {
        public string Name => "Indian 1954 / UTM zone 48N";
        public long Srid => 23948;

        public string OgcWkt =>
            "PROJCS[Indian 1954 / UTM zone 48N,GEOGCS[Indian 1954,DATUM[Indian_1954,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[217,823,299,0,0,0,0],AUTHORITY[EPSG,6239]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4239]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,23948],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Indian 1954 / UTM zone 48N,GEOGCS[Indian 1954,DATUM[Indian_1954,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[217,823,299,0,0,0,0],AUTHORITY[EPSG,6239]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4239]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,23948],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}