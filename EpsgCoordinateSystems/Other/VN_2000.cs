namespace EpsgCoordinateSystems.Other
{
    public class VN_2000 : IEpsgCoordinateSystem
    {
        public string Name => "VN-2000";
        public string Units => "Unspecified";
public long Srid => 4756;

        public string OgcWkt =>
            "GEOGCS[VN-2000,DATUM[Vietnam_2000,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6756]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4756]]";

        public string EsriWkt => "GEOGCS[VN-2000,DATUM[D_,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}