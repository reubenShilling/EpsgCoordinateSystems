namespace EpsgCoordinateSystems.Other
{
    public class WGS_72 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 72";
        public string Units => "Unspecified";
public long Srid => 4985;

        public string OgcWkt =>
            "GEOGCS[WGS 72,DATUM[World Geodetic System 1972,SPHEROID[WGS 72,6378135.0,298.26,AUTHORITY[EPSG,7043]],TOWGS84[0.0,0.0,4.5,0.0,0.0,0.554,0.045171992568114105],AUTHORITY[EPSG,6322]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4985]]";

        public string EsriWkt => "GEOGCS[WGS 72,DATUM[D_World Geodetic System 1972,SPHEROID[WGS_1972,6378135.0,298.26]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}