namespace EpsgCoordinateSystems.Other
{
    public class RRAF_1991 : IEpsgCoordinateSystem
    {
        public string Name => "RRAF 1991";
        public string Units => "Unspecified";
public long Srid => 4973;

        public string OgcWkt =>
            "GEOGCS[RRAF 1991,DATUM[Reseau de Reference des Antilles Francaises 1991,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6640]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4973]]";

        public string EsriWkt => "GEOGCS[RRAF 1991,DATUM[D_Reseau de Reference des Antilles Francaises 1991,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}