namespace EpsgCoordinateSystems.Other
{
    public class IGC_1962_6th_Parallel_South : IEpsgCoordinateSystem
    {
        public string Name => "IGC 1962 6th Parallel South";
        public long Srid => 4697;

        public string OgcWkt =>
            "GEOGCS[IGC 1962 6th Parallel South,DATUM[IGC_1962_Arc_of_the_6th_Parallel_South,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6697]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4697]]";

        public string EsriWkt =>
            "GEOGCS[IGC 1962 6th Parallel South,DATUM[IGC_1962_Arc_of_the_6th_Parallel_South,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6697]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4697]]";
    }
}