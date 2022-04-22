namespace EpsgCoordinateSystems.Categories.Other
{
    public class Locodjo_1965 : IEpsgCoordinateSystem
    {
        public string Name => "Locodjo 1965";
        public string Units => "Unspecified";
public int Srid => 4142;

        public string OgcWkt =>
            "GEOGCS[Locodjo 1965,DATUM[Locodjo_1965,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-125,53,467,0,0,0,0],AUTHORITY[EPSG,6142]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4142]]";

        public string EsriWkt => "GEOGCS[Locodjo 1965,DATUM[D_Locodjo_1965,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}