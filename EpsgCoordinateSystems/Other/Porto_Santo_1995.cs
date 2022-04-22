namespace EpsgCoordinateSystems.Other
{
    public class Porto_Santo_1995 : IEpsgCoordinateSystem
    {
        public string Name => "Porto Santo 1995";
        public string Units => "Unspecified";
public long Srid => 4663;

        public string OgcWkt =>
            "GEOGCS[Porto Santo 1995,DATUM[Porto_Santo_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6663]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4663]]";

        public string EsriWkt => "GEOGCS[Porto Santo 1995,DATUM[D_Porto_Santo_1995,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}