namespace EpsgCoordinateSystems.Other
{
    public class Maupiti_83_UTM_zone_5S : IEpsgCoordinateSystem
    {
        public string Name => "Maupiti 83 / UTM zone 5S";
        public string Units => "Unspecified";
public long Srid => 3306;

        public string OgcWkt =>
            "PROJCS[Maupiti 83 / UTM zone 5S,GEOGCS[Maupiti 83,DATUM[Maupiti_83,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[217.037,86.959,23.956,0,0,0,0],AUTHORITY[EPSG,6692]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4692]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3306],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Maupiti 83 / UTM zone 5S,GEOGCS[Maupiti 83,DATUM[D_Maupiti_1983,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}