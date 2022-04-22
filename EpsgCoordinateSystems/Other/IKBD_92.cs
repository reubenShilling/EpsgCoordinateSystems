namespace EpsgCoordinateSystems.Other
{
    public class IKBD_92 : IEpsgCoordinateSystem
    {
        public string Name => "IKBD-92";
        public string Units => "Unspecified";
public long Srid => 4667;

        public string OgcWkt =>
            "GEOGCS[IKBD-92,DATUM[Iraq_Kuwait_Boundary_Datum_1992,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6667]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4667]]";

        public string EsriWkt =>
            "GEOGCS[IKBD-92,DATUM[Iraq_Kuwait_Boundary_Datum_1992,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6667]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4667]]";
    }
}