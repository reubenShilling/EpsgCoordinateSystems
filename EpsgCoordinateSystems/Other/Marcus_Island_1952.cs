namespace EpsgCoordinateSystems.Other
{
    public class Marcus_Island_1952 : IEpsgCoordinateSystem
    {
        public string Name => "Marcus Island 1952";
        public string Units => "Unspecified";
public long Srid => 4711;

        public string OgcWkt =>
            "GEOGCS[Marcus Island 1952,DATUM[Marcus_Island_1952,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[124,-234,-25,0,0,0,0],AUTHORITY[EPSG,6711]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4711]]";

        public string EsriWkt => "GEOGCS[Marcus Island 1952,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}