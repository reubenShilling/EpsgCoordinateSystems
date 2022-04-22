namespace EpsgCoordinateSystems.Categories.Other
{
    public class NEA74_Noumea : IEpsgCoordinateSystem
    {
        public string Name => "NEA74 Noumea";
        public string Units => "Unspecified";
public int Srid => 4644;

        public string OgcWkt =>
            "GEOGCS[NEA74 Noumea,DATUM[NEA74_Noumea,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6644]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4644]]";

        public string EsriWkt => "GEOGCS[NEA74 Noumea,DATUM[D_NEA74_Noumea,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}