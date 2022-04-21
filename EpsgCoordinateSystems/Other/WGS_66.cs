namespace EpsgCoordinateSystems.Other
{
    public class WGS_66 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 66";
        public long Srid => 4891;

        public string OgcWkt =>
            "GEOGCS[WGS 66,DATUM[World Geodetic System 1966,SPHEROID[NWL 9D,6378145.0,298.25,AUTHORITY[EPSG,7025]],AUTHORITY[EPSG,6760]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4891]]";

        public string EsriWkt =>
            "GEOGCS[WGS 66,DATUM[World Geodetic System 1966,SPHEROID[NWL 9D,6378145.0,298.25,AUTHORITY[EPSG,7025]],AUTHORITY[EPSG,6760]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4891]]";
    }
}