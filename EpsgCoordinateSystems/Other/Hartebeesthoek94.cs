namespace EpsgCoordinateSystems.Other
{
    public class Hartebeesthoek94 : IEpsgCoordinateSystem
    {
        public string Name => "Hartebeesthoek94";
        public string Units => "Unspecified";
public long Srid => 4941;

        public string OgcWkt =>
            "GEOGCS[Hartebeesthoek94,DATUM[Hartebeesthoek94,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6148]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4941]]";

        public string EsriWkt => "GEOGCS[Hartebeesthoek94,DATUM[D_Hartebeesthoek_1994,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}