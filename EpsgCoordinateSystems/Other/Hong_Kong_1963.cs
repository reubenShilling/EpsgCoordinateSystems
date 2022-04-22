namespace EpsgCoordinateSystems.Other
{
    public class Hong_Kong_1963 : IEpsgCoordinateSystem
    {
        public string Name => "Hong Kong 1963";
        public string Units => "Unspecified";
public long Srid => 4738;

        public string OgcWkt =>
            "GEOGCS[Hong Kong 1963,DATUM[Hong_Kong_1963,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6738]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4738]]";

        public string EsriWkt =>
            "GEOGCS[Hong Kong 1963,DATUM[Hong_Kong_1963,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6738]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4738]]";
    }
}