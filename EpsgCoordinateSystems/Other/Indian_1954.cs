namespace EpsgCoordinateSystems.Other
{
    public class Indian_1954 : IEpsgCoordinateSystem
    {
        public string Name => "Indian 1954";
        public string Units => "Unspecified";
public long Srid => 4239;

        public string OgcWkt =>
            "GEOGCS[Indian 1954,DATUM[Indian_1954,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[217,823,299,0,0,0,0],AUTHORITY[EPSG,6239]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4239]]";

        public string EsriWkt => "GEOGCS[Indian 1954,DATUM[D_Indian_1954,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}