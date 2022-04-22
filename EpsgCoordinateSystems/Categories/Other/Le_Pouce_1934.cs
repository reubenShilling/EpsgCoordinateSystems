namespace EpsgCoordinateSystems.Categories.Other
{
    public class Le_Pouce_1934 : IEpsgCoordinateSystem
    {
        public string Name => "Le Pouce 1934";
        public string Units => "Unspecified";
public int Srid => 4699;

        public string OgcWkt =>
            "GEOGCS[Le Pouce 1934,DATUM[Le_Pouce_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-770.1,158.4,-498.2,0,0,0,0],AUTHORITY[EPSG,6699]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4699]]";

        public string EsriWkt => "GEOGCS[Le Pouce 1934,DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}