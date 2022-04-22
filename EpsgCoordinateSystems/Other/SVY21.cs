namespace EpsgCoordinateSystems.Other
{
    public class SVY21 : IEpsgCoordinateSystem
    {
        public string Name => "SVY21";
        public string Units => "Unspecified";
public long Srid => 4757;

        public string OgcWkt =>
            "GEOGCS[SVY21,DATUM[SVY21,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6757]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4757]]";

        public string EsriWkt =>
            "GEOGCS[SVY21,DATUM[SVY21,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6757]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4757]]";
    }
}