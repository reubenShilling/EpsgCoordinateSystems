namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_EVRF2000 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 + EVRF2000";
        public long Srid => 7409;

        public string OgcWkt =>
            "COMPD_CS[ETRS89 + EVRF2000,GEOGCS[ETRS89,DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4258]],VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005,AUTHORITY[EPSG,5129]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5730]],AUTHORITY[EPSG,7409]]";

        public string EsriWkt =>
            "COMPD_CS[ETRS89 + EVRF2000,GEOGCS[ETRS89,DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4258]],VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005,AUTHORITY[EPSG,5129]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5730]],AUTHORITY[EPSG,7409]]";
    }
}