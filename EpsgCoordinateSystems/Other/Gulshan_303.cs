namespace EpsgCoordinateSystems.Other
{
    public class Gulshan_303 : IEpsgCoordinateSystem
    {
        public string Name => "Gulshan 303";
        public string Units => "Unspecified";
public long Srid => 4682;

        public string OgcWkt =>
            "GEOGCS[Gulshan 303,DATUM[Gulshan_303,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6682]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4682]]";

        public string EsriWkt =>
            "GEOGCS[Gulshan 303,DATUM[Gulshan_303,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6682]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4682]]";
    }
}