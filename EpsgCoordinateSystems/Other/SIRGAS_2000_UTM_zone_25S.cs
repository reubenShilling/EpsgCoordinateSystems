namespace EpsgCoordinateSystems.Other
{
    public class SIRGAS_2000_UTM_zone_25S : IEpsgCoordinateSystem
    {
        public string Name => "SIRGAS 2000 / UTM zone 25S";
        public long Srid => 31985;

        public string OgcWkt =>
            "PROJCS[SIRGAS 2000 / UTM zone 25S,GEOGCS[SIRGAS 2000,DATUM[Sistema_de_Referencia_Geocentrico_para_America_del_Sur_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6674]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4674]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,31985],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[SIRGAS 2000 / UTM zone 25S,GEOGCS[SIRGAS 2000,DATUM[Sistema_de_Referencia_Geocentrico_para_America_del_Sur_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6674]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4674]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,31985],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}