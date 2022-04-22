namespace EpsgCoordinateSystems.Other
{
    public class Mount_Dillon : IEpsgCoordinateSystem
    {
        public string Name => "Mount Dillon";
        public string Units => "Unspecified";
public long Srid => 4157;

        public string OgcWkt =>
            "GEOGCS[Mount Dillon,DATUM[Mount_Dillon,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6157]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4157]]";

        public string EsriWkt =>
            "GEOGCS[Mount Dillon,DATUM[Mount_Dillon,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6157]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4157]]";
    }
}