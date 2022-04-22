namespace EpsgCoordinateSystems.Other
{
    public class PZ_90 : IEpsgCoordinateSystem
    {
        public string Name => "PZ-90";
        public string Units => "Unspecified";
public long Srid => 4923;

        public string OgcWkt =>
            "GEOGCS[PZ-90,DATUM[Parametrop Zemp 1990,SPHEROID[PZ-90,6378136.0,298.257839303,AUTHORITY[EPSG,7054]],TOWGS84[0.0,0.0,1.5,-0.0,0.0,-0.076,0.0],AUTHORITY[EPSG,6740]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4923]]";

        public string EsriWkt => "GEOGCS[PZ-90,DATUM[D_Parametrop Zemp 1990,SPHEROID[PZ_90,6378136.0,298.257839303]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}