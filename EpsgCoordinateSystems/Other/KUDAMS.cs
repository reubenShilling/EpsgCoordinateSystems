namespace EpsgCoordinateSystems.Other
{
    public class KUDAMS : IEpsgCoordinateSystem
    {
        public string Name => "KUDAMS";
        public string Units => "Unspecified";
public long Srid => 4319;

        public string OgcWkt =>
            "GEOGCS[KUDAMS,DATUM[Kuwait_Utility,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6319]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4319]]";

        public string EsriWkt =>
            "GEOGCS[KUDAMS,DATUM[Kuwait_Utility,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6319]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4319]]";
    }
}