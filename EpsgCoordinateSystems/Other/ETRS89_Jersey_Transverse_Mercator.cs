namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Jersey_Transverse_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Jersey Transverse Mercator";
        public long Srid => 3109;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Jersey Transverse Mercator,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.225],PARAMETER[central_meridian,-2.135],PARAMETER[scale_factor,0.9999999],PARAMETER[false_easting,40000],PARAMETER[false_northing,70000],AUTHORITY[EPSG,3109],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ETRS89 / Jersey Transverse Mercator,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.225],PARAMETER[central_meridian,-2.135],PARAMETER[scale_factor,0.9999999],PARAMETER[false_easting,40000],PARAMETER[false_northing,70000],AUTHORITY[EPSG,3109],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}