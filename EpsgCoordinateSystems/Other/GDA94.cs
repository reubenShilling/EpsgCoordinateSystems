namespace EpsgCoordinateSystems.Other
{
    public class GDA94 : IEpsgCoordinateSystem
    {
        public string Name => "GDA94";
        public string Units => "Unspecified";
public long Srid => 4939;

        public string OgcWkt =>
            "GEOGCS[GDA94,DATUM[Geocentric Datum of Australia 1994,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4939]]";

        public string EsriWkt =>
            "GEOGCS[GDA94,DATUM[Geocentric Datum of Australia 1994,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4939]]";
    }
}