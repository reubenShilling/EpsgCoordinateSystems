namespace EpsgCoordinateSystems.Other
{
    public class RGNC_1991 : IEpsgCoordinateSystem
    {
        public string Name => "RGNC 1991";
        public string Units => "Unspecified";
public long Srid => 4969;

        public string OgcWkt =>
            "GEOGCS[RGNC 1991,DATUM[Reseau Geodesique Nouvelle Caledonie 1991,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6645]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4969]]";

        public string EsriWkt =>
            "GEOGCS[RGNC 1991,DATUM[Reseau Geodesique Nouvelle Caledonie 1991,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6645]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4969]]";
    }
}