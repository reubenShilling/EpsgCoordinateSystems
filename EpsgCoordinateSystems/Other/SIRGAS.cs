namespace EpsgCoordinateSystems.Other
{
    public class SIRGAS : IEpsgCoordinateSystem
    {
        public string Name => "SIRGAS";
        public string Units => "Unspecified";
public long Srid => 4975;

        public string OgcWkt =>
            "GEOGCS[SIRGAS,DATUM[Sistema de Referencia Geocentrico para America del Sur 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6170]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4975]]";

        public string EsriWkt => "GEOGCS[SIRGAS,DATUM[D_Sistema de Referencia Geocentrico para America del Sur 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}