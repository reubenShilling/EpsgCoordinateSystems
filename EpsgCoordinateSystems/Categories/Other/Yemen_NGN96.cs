namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yemen_NGN96 : IEpsgCoordinateSystem
    {
        public string Name => "Yemen NGN96";
        public string Units => "Unspecified";
public int Srid => 4981;

        public string OgcWkt =>
            "GEOGCS[Yemen NGN96,DATUM[Yemen National Geodetic Network 1996,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6163]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4981]]";

        public string EsriWkt => "GEOGCS[Yemen NGN96,DATUM[D_Yemen National Geodetic Network 1996,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}