namespace EpsgCoordinateSystems.Other
{
    public class LKS92 : IEpsgCoordinateSystem
    {
        public string Name => "LKS92";
        public string Units => "Unspecified";
public long Srid => 4949;

        public string OgcWkt =>
            "GEOGCS[LKS92,DATUM[Latvia 1992,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6661]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4949]]";

        public string EsriWkt => "GEOGCS[LKS92,DATUM[D_Latvia 1992,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}