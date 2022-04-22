namespace EpsgCoordinateSystems.Other
{
    public class Timbalai_1948_UTM_zone_49N : IEpsgCoordinateSystem
    {
        public string Name => "Timbalai 1948 / UTM zone 49N";
        public string Units => "Unspecified";
public long Srid => 29849;

        public string OgcWkt =>
            "PROJCS[Timbalai 1948 / UTM zone 49N,GEOGCS[Timbalai 1948,DATUM[Timbalai_1948,SPHEROID[Everest 1830 (1967 Definition),6377298.556,300.8017,AUTHORITY[EPSG,7016]],AUTHORITY[EPSG,6298]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4298]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,111],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,29849],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Timbalai 1948 / UTM zone 49N,GEOGCS[Timbalai 1948,DATUM[Timbalai_1948,SPHEROID[Everest 1830 (1967 Definition),6377298.556,300.8017,AUTHORITY[EPSG,7016]],AUTHORITY[EPSG,6298]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4298]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,111],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,29849],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}