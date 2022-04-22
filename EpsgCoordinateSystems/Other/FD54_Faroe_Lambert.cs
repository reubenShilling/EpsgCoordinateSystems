namespace EpsgCoordinateSystems.Other
{
    public class FD54_Faroe_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "FD54 / Faroe Lambert";
        public string Units => "Unspecified";
public long Srid => 3144;

        public string OgcWkt =>
            "PROJCS[FD54 / Faroe Lambert,GEOGCS[FD54,DATUM[Faroe_Datum_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6741]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4741],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt =>
            "PROJCS[FD54 / Faroe Lambert,GEOGCS[FD54,DATUM[Faroe_Datum_1954,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6741]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4741],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";
    }
}