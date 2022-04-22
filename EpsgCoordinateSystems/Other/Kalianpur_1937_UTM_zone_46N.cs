namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1937_UTM_zone_46N : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1937 / UTM zone 46N";
        public string Units => "Unspecified";
public long Srid => 24306;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1937 / UTM zone 46N,GEOGCS[Kalianpur 1937,DATUM[Kalianpur_1937,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6144]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4144]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,93],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24306],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1937 / UTM zone 46N,GEOGCS[Kalianpur 1937,DATUM[D_Kalianpur_1937,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,93],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}