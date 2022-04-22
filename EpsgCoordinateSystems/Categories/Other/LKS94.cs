namespace EpsgCoordinateSystems.Categories.Other
{
    public class LKS94 : IEpsgCoordinateSystem
    {
        public string Name => "LKS94";
        public string Units => "Unspecified";
public int Srid => 4951;

        public string OgcWkt =>
            "GEOGCS[LKS94,DATUM[Lithuania 1994 (ETRS89),SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6126]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4951]]";

        public string EsriWkt => "GEOGCS[LKS94,DATUM[D_Lithuania 1994 (ETRS89),SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}