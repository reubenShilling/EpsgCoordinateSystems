namespace EpsgCoordinateSystems.Categories.Other
{
    public class MAGNA_SIRGAS : IEpsgCoordinateSystem
    {
        public string Name => "MAGNA-SIRGAS";
        public string Units => "Unspecified";
public int Srid => 4997;

        public string OgcWkt =>
            "GEOGCS[MAGNA-SIRGAS,DATUM[Marco Geocentrico Nacional de Referencia,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6686]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4997]]";

        public string EsriWkt => "GEOGCS[MAGNA-SIRGAS,DATUM[D_Marco Geocentrico Nacional de Referencia,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}