namespace EpsgCoordinateSystems.Other
{
    public class Kandawala : IEpsgCoordinateSystem
    {
        public string Name => "Kandawala";
        public string Units => "Unspecified";
public long Srid => 4244;

        public string OgcWkt =>
            "GEOGCS[Kandawala,DATUM[Kandawala,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[-97,787,86,0,0,0,0],AUTHORITY[EPSG,6244]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4244]]";

        public string EsriWkt =>
            "GEOGCS[Kandawala,DATUM[Kandawala,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[-97,787,86,0,0,0,0],AUTHORITY[EPSG,6244]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4244]]";
    }
}