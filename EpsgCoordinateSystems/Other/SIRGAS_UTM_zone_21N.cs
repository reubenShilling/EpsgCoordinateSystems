namespace EpsgCoordinateSystems.Other
{
    public class SIRGAS_UTM_zone_21N : IEpsgCoordinateSystem
    {
        public string Name => "SIRGAS / UTM zone 21N";
        public string Units => "Unspecified";
public long Srid => 31990;

        public string OgcWkt =>
            "PROJCS[SIRGAS / UTM zone 21N,GEOGCS[SIRGAS,DATUM[Sistema_de_Referencia_Geocentrico_para_America_del_Sur_1995,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6170]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4170]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31990],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[SIRGAS / UTM zone 21N,GEOGCS[SIRGAS,DATUM[Sistema_de_Referencia_Geocentrico_para_America_del_Sur_1995,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6170]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4170]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31990],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}