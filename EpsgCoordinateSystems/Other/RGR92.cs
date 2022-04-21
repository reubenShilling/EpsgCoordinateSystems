namespace EpsgCoordinateSystems.Other
{
    public class RGR92 : IEpsgCoordinateSystem
    {
        public string Name => "RGR92";
        public long Srid => 4971;

        public string OgcWkt =>
            "GEOGCS[RGR92,DATUM[Reseau Geodesique de la Reunion 1992,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6627]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4971]]";

        public string EsriWkt =>
            "GEOGCS[RGR92,DATUM[Reseau Geodesique de la Reunion 1992,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6627]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4971]]";
    }
}