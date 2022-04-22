namespace EpsgCoordinateSystems.Other
{
    public class IRENET95 : IEpsgCoordinateSystem
    {
        public string Name => "IRENET95";
        public string Units => "Unspecified";
public long Srid => 4943;

        public string OgcWkt =>
            "GEOGCS[IRENET95,DATUM[IRENET95,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6173]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4943]]";

        public string EsriWkt => "GEOGCS[IRENET95,DATUM[D_IRENET95,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}