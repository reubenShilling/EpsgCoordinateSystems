namespace EpsgCoordinateSystems.Other
{
    public class ID74 : IEpsgCoordinateSystem
    {
        public string Name => "ID74";
        public long Srid => 4238;

        public string OgcWkt =>
            "GEOGCS[ID74,DATUM[Indonesian_Datum_1974,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6238]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4238]]";

        public string EsriWkt =>
            "GEOGCS[ID74,DATUM[Indonesian_Datum_1974,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6238]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4238]]";
    }
}