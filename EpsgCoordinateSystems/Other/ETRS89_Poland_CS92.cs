namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Poland_CS92 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Poland CS92";
        public string Units => "Unspecified";
public long Srid => 2180;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Poland CS92,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,19],PARAMETER[scale_factor,0.9993],PARAMETER[false_easting,500000],PARAMETER[false_northing,-5300000],AUTHORITY[EPSG,2180],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ETRS89 / Poland CS92,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,19],PARAMETER[scale_factor,0.9993],PARAMETER[false_easting,500000],PARAMETER[false_northing,-5300000],AUTHORITY[EPSG,2180],AXIS[y,EAST],AXIS[x,NORTH]]";
    }
}