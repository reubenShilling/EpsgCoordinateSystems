namespace EpsgCoordinateSystems.Other
{
    public class Qornoq_1927_Greenland_zone_7_west : IEpsgCoordinateSystem
    {
        public string Name => "Qornoq 1927 / Greenland zone 7 west";
        public string Units => "Unspecified";
public long Srid => 2306;

        public string OgcWkt =>
            "PROJCS[Qornoq 1927 / Greenland zone 7 west,GEOGCS[Qornoq 1927,DATUM[Qornoq_1927,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6194]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4194],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[Qornoq 1927 / Greenland zone 7 west,GEOGCS[Qornoq 1927,DATUM[D_Qornoq_1927,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}