namespace EpsgCoordinateSystems.Other
{
    public class OSGB_1936 : IEpsgCoordinateSystem
    {
        public string Name => "OSGB 1936";
        public string Units => "Unspecified";
public long Srid => 4277;

        public string OgcWkt =>
            "GEOGCS[OSGB 1936,DATUM[OSGB_1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4277]]";

        public string EsriWkt =>
            "GEOGCS[OSGB 1936,DATUM[OSGB_1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4277]]";
    }
}