namespace EpsgCoordinateSystems.Other
{
    public class Belge_1972 : IEpsgCoordinateSystem
    {
        public string Name => "Belge 1972";
        public string Units => "Unspecified";
public long Srid => 4313;

        public string OgcWkt =>
            "GEOGCS[Belge 1972,DATUM[Reseau_National_Belge_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[106.869,-52.2978,103.724,-0.33657,0.456955,-1.84218,1],AUTHORITY[EPSG,6313]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4313]]";

        public string EsriWkt =>
            "GEOGCS[Belge 1972,DATUM[Reseau_National_Belge_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[106.869,-52.2978,103.724,-0.33657,0.456955,-1.84218,1],AUTHORITY[EPSG,6313]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4313]]";
    }
}