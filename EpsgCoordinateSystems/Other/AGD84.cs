namespace EpsgCoordinateSystems.Other
{
    public class AGD84 : IEpsgCoordinateSystem
    {
        public string Name => "AGD84";
        public long Srid => 4203;

        public string OgcWkt =>
            "GEOGCS[AGD84,DATUM[Australian_Geodetic_Datum_1984,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6203]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4203]]";

        public string EsriWkt =>
            "GEOGCS[AGD84,DATUM[Australian_Geodetic_Datum_1984,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6203]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4203]]";
    }
}