namespace EpsgCoordinateSystems.Categories.Other
{
    public class Korean_1995 : IEpsgCoordinateSystem
    {
        public string Name => "Korean 1995";
        public string Units => "Unspecified";
public int Srid => 4166;

        public string OgcWkt =>
            "GEOGCS[Korean 1995,DATUM[Korean_Datum_1995,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6166]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4166]]";

        public string EsriWkt => "GEOGCS[Korean 1995,DATUM[D_Korean_Datum_1995,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}