namespace EpsgCoordinateSystems.Other
{
    public class DGN95 : IEpsgCoordinateSystem
    {
        public string Name => "DGN95";
        public string Units => "Unspecified";
public long Srid => 4898;

        public string OgcWkt =>
            "GEOGCS[DGN95,DATUM[Datum Geodesi Nasional 1995,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6755]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4898]]";

        public string EsriWkt =>
            "GEOGCS[DGN95,DATUM[Datum Geodesi Nasional 1995,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6755]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4898]]";
    }
}