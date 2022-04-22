namespace EpsgCoordinateSystems.Other
{
    public class Slovenia_1996 : IEpsgCoordinateSystem
    {
        public string Name => "Slovenia 1996";
        public string Units => "Unspecified";
public long Srid => 4883;

        public string OgcWkt =>
            "GEOGCS[Slovenia 1996,DATUM[Slovenia Geodetic Datum 1996,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6765]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4883]]";

        public string EsriWkt => "GEOGCS[Slovenia 1996,DATUM[D_Slovenia Geodetic Datum 1996,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}