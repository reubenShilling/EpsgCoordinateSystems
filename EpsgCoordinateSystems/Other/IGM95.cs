namespace EpsgCoordinateSystems.Other
{
    public class IGM95 : IEpsgCoordinateSystem
    {
        public string Name => "IGM95";
        public long Srid => 4983;

        public string OgcWkt =>
            "GEOGCS[IGM95,DATUM[Istituto Geografico Militaire 1995,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6670]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4983]]";

        public string EsriWkt =>
            "GEOGCS[IGM95,DATUM[Istituto Geografico Militaire 1995,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6670]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4983]]";
    }
}