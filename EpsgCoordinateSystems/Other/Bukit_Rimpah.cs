namespace EpsgCoordinateSystems.Other
{
    public class Bukit_Rimpah : IEpsgCoordinateSystem
    {
        public string Name => "Bukit Rimpah";
        public long Srid => 4219;

        public string OgcWkt =>
            "GEOGCS[Bukit Rimpah,DATUM[Bukit_Rimpah,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-384,664,-48,0,0,0,0],AUTHORITY[EPSG,6219]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4219]]";

        public string EsriWkt =>
            "GEOGCS[Bukit Rimpah,DATUM[Bukit_Rimpah,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-384,664,-48,0,0,0,0],AUTHORITY[EPSG,6219]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4219]]";
    }
}