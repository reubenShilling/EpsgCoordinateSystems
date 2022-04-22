namespace EpsgCoordinateSystems.Other
{
    public class Pitcairn_2006 : IEpsgCoordinateSystem
    {
        public string Name => "Pitcairn 2006";
        public string Units => "Unspecified";
public long Srid => 4763;

        public string OgcWkt =>
            "GEOGCS[Pitcairn 2006,DATUM[Pitcairn_2006,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6763]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4763]]";

        public string EsriWkt => "GEOGCS[Pitcairn 2006,DATUM[D_Pitcairn_2006,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}