namespace EpsgCoordinateSystems.Categories.Other
{
    public class ETRS89 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89";
        public string Units => "Unspecified";
public int Srid => 4937;

        public string OgcWkt =>
            "GEOGCS[ETRS89,DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4937]]";

        public string EsriWkt => "GEOGCS[ETRS89,DATUM[D_European Terrestrial Reference System 1989,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}