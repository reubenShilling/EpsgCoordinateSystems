namespace EpsgCoordinateSystems.Other
{
    public class Indian_1975 : IEpsgCoordinateSystem
    {
        public string Name => "Indian 1975";
        public string Units => "Unspecified";
public long Srid => 4240;

        public string OgcWkt =>
            "GEOGCS[Indian 1975,DATUM[Indian_1975,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6240]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4240]]";

        public string EsriWkt => "GEOGCS[Indian 1975,DATUM[D_Indian_1975,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}