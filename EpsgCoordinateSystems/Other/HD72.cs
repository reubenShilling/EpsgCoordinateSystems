namespace EpsgCoordinateSystems.Other
{
    public class HD72 : IEpsgCoordinateSystem
    {
        public string Name => "HD72";
        public long Srid => 4237;

        public string OgcWkt =>
            "GEOGCS[HD72,DATUM[Hungarian_Datum_1972,SPHEROID[GRS 1967,6378160,298.247167427,AUTHORITY[EPSG,7036]],AUTHORITY[EPSG,6237]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4237]]";

        public string EsriWkt =>
            "GEOGCS[HD72,DATUM[Hungarian_Datum_1972,SPHEROID[GRS 1967,6378160,298.247167427,AUTHORITY[EPSG,7036]],AUTHORITY[EPSG,6237]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4237]]";
    }
}