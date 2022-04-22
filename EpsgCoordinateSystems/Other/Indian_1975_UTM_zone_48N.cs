namespace EpsgCoordinateSystems.Other
{
    public class Indian_1975_UTM_zone_48N : IEpsgCoordinateSystem
    {
        public string Name => "Indian 1975 / UTM zone 48N";
        public string Units => "Unspecified";
public long Srid => 24048;

        public string OgcWkt =>
            "PROJCS[Indian 1975 / UTM zone 48N,GEOGCS[Indian 1975,DATUM[Indian_1975,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6240]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4240]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24048],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Indian 1975 / UTM zone 48N,GEOGCS[Indian 1975,DATUM[Indian_1975,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6240]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4240]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24048],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}