namespace EpsgCoordinateSystems.Other
{
    public class ATS77 : IEpsgCoordinateSystem
    {
        public string Name => "ATS77";
        public long Srid => 4122;

        public string OgcWkt =>
            "GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]]";

        public string EsriWkt =>
            "GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]]";
    }
}