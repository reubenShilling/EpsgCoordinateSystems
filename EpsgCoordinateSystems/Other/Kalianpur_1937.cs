namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1937 : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1937";
        public string Units => "Unspecified";
public long Srid => 4144;

        public string OgcWkt =>
            "GEOGCS[Kalianpur 1937,DATUM[Kalianpur_1937,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6144]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4144]]";

        public string EsriWkt => "GEOGCS[Kalianpur 1937,DATUM[D_Kalianpur_1937,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}