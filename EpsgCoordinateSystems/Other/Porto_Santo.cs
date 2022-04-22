namespace EpsgCoordinateSystems.Other
{
    public class Porto_Santo : IEpsgCoordinateSystem
    {
        public string Name => "Porto Santo";
        public string Units => "Unspecified";
public long Srid => 4615;

        public string OgcWkt =>
            "GEOGCS[Porto Santo,DATUM[Porto_Santo_1936,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-499,-249,314,0,0,0,0],AUTHORITY[EPSG,6615]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4615]]";

        public string EsriWkt => "GEOGCS[Porto Santo,DATUM[D_Porto_Santo_1936,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}