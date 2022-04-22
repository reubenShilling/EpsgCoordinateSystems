namespace EpsgCoordinateSystems.Other
{
    public class Monte_Mario : IEpsgCoordinateSystem
    {
        public string Name => "Monte Mario";
        public string Units => "Unspecified";
public long Srid => 4265;

        public string OgcWkt =>
            "GEOGCS[Monte Mario,DATUM[Monte_Mario,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6265]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4265]]";

        public string EsriWkt => "GEOGCS[Monte Mario,DATUM[D_Monte_Mario,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}