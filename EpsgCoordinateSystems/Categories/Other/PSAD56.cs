namespace EpsgCoordinateSystems.Categories.Other
{
    public class PSAD56 : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56";
        public string Units => "Unspecified";
public int Srid => 4248;

        public string OgcWkt =>
            "GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]]";

        public string EsriWkt => "GEOGCS[PSAD56,DATUM[D_Provisional_S_American_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}