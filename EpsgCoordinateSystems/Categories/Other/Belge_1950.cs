namespace EpsgCoordinateSystems.Categories.Other
{
    public class Belge_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Belge 1950";
        public string Units => "Unspecified";
public int Srid => 4215;

        public string OgcWkt =>
            "GEOGCS[Belge 1950,DATUM[Reseau_National_Belge_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6215]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4215]]";

        public string EsriWkt => "GEOGCS[Belge 1950,DATUM[D_Belge_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}