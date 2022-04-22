namespace EpsgCoordinateSystems.Other
{
    public class Puerto_Rico : IEpsgCoordinateSystem
    {
        public string Name => "Puerto Rico";
        public string Units => "Unspecified";
public long Srid => 4139;

        public string OgcWkt =>
            "GEOGCS[Puerto Rico,DATUM[Puerto_Rico,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[11,72,-101,0,0,0,0],AUTHORITY[EPSG,6139]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4139]]";

        public string EsriWkt => "GEOGCS[Puerto Rico,DATUM[D_Puerto_Rico,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}