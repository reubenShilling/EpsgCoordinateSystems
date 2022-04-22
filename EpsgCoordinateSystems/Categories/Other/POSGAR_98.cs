namespace EpsgCoordinateSystems.Categories.Other
{
    public class POSGAR_98 : IEpsgCoordinateSystem
    {
        public string Name => "POSGAR 98";
        public string Units => "Unspecified";
public int Srid => 4961;

        public string OgcWkt =>
            "GEOGCS[POSGAR 98,DATUM[Posiciones Geodesicas Argentinas 1998,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6190]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4961]]";

        public string EsriWkt => "GEOGCS[POSGAR 98,DATUM[D_Posiciones Geodesicas Argentinas 1998,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}