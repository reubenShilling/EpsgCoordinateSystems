namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1962_UTM_zone_43N : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1962 / UTM zone 43N";
        public string Units => "Unspecified";
public long Srid => 24313;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1962 / UTM zone 43N,GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,75],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24313],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1962 / UTM zone 43N,GEOGCS[Kalianpur 1962,DATUM[D_Kalianpur_1962,SPHEROID[Everest_1830_1962_Definition,6377301.243,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,75],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}