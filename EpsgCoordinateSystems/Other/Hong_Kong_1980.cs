namespace EpsgCoordinateSystems.Other
{
    public class Hong_Kong_1980 : IEpsgCoordinateSystem
    {
        public string Name => "Hong Kong 1980";
        public long Srid => 4611;

        public string OgcWkt =>
            "GEOGCS[Hong Kong 1980,DATUM[Hong_Kong_1980,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-162.619,-276.959,-161.764,0.067753,-2.24365,-1.15883,-1.09425],AUTHORITY[EPSG,6611]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4611]]";

        public string EsriWkt =>
            "GEOGCS[Hong Kong 1980,DATUM[Hong_Kong_1980,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-162.619,-276.959,-161.764,0.067753,-2.24365,-1.15883,-1.09425],AUTHORITY[EPSG,6611]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4611]]";
    }
}