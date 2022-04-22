namespace EpsgCoordinateSystems.Other
{
    public class Sierra_Leone_1968_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Sierra Leone 1968 / UTM zone 28N";
        public string Units => "Unspecified";
public long Srid => 2161;

        public string OgcWkt =>
            "PROJCS[Sierra Leone 1968 / UTM zone 28N,GEOGCS[Sierra Leone 1968,DATUM[Sierra_Leone_1968,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-88,4,101,0,0,0,0],AUTHORITY[EPSG,6175]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4175]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2161],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Sierra Leone 1968 / UTM zone 28N,GEOGCS[Sierra Leone 1968,DATUM[Sierra_Leone_1968,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-88,4,101,0,0,0,0],AUTHORITY[EPSG,6175]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4175]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2161],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}