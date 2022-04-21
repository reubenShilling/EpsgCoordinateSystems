namespace EpsgCoordinateSystems.Other
{
    public class IGM95_UTM_zone_33N : IEpsgCoordinateSystem
    {
        public string Name => "IGM95 / UTM zone 33N";
        public long Srid => 3065;

        public string OgcWkt =>
            "PROJCS[IGM95 / UTM zone 33N,GEOGCS[IGM95,DATUM[Istituto_Geografico_Militaire_1995,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6670]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4670]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3065],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[IGM95 / UTM zone 33N,GEOGCS[IGM95,DATUM[Istituto_Geografico_Militaire_1995,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6670]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4670]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3065],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}