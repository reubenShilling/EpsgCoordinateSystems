namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_72BE : IEpsgCoordinateSystem
    {
        public string Name => "WGS 72BE";
        public string Units => "Unspecified";
public int Srid => 4987;

        public string OgcWkt =>
            "GEOGCS[WGS 72BE,DATUM[WGS 72 Transit Broadcast Ephemeris,SPHEROID[WGS 72,6378135.0,298.26,AUTHORITY[EPSG,7043]],TOWGS84[0.0,0.0,1.9,0.0,0.0,0.814,-0.07838062637389662],AUTHORITY[EPSG,6324]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4987]]";

        public string EsriWkt => "GEOGCS[WGS 72BE,DATUM[D_WGS 72 Transit Broadcast Ephemeris,SPHEROID[WGS_1972,6378135.0,298.26]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}