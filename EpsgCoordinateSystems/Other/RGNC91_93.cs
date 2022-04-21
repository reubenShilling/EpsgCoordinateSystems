namespace EpsgCoordinateSystems.Other
{
    public class RGNC91_93 : IEpsgCoordinateSystem
    {
        public string Name => "RGNC91-93";
        public long Srid => 4907;

        public string OgcWkt =>
            "GEOGCS[RGNC91-93,DATUM[Reseau Geodesique de Nouvelle Caledonie 91-93,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6749]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4907]]";

        public string EsriWkt =>
            "GEOGCS[RGNC91-93,DATUM[Reseau Geodesique de Nouvelle Caledonie 91-93,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6749]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4907]]";
    }
}