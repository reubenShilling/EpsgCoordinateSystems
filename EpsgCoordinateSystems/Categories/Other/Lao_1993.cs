namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lao_1993 : IEpsgCoordinateSystem
    {
        public string Name => "Lao 1993";
        public string Units => "Unspecified";
public int Srid => 4991;

        public string OgcWkt =>
            "GEOGCS[Lao 1993,DATUM[Lao 1993,SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6677]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4991]]";

        public string EsriWkt => "GEOGCS[Lao 1993,DATUM[D_Lao 1993,SPHEROID[Krassowsky_1940,6378245.0,298.3]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}