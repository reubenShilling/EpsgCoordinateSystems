namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1962 : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1962";
        public string Units => "Unspecified";
public long Srid => 4145;

        public string OgcWkt =>
            "GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]]";

        public string EsriWkt =>
            "GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]]";
    }
}