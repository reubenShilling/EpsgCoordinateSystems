namespace EpsgCoordinateSystems.Other
{
    public class Sierra_Leone_1968 : IEpsgCoordinateSystem
    {
        public string Name => "Sierra Leone 1968";
        public string Units => "Unspecified";
public long Srid => 4175;

        public string OgcWkt =>
            "GEOGCS[Sierra Leone 1968,DATUM[Sierra_Leone_1968,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-88,4,101,0,0,0,0],AUTHORITY[EPSG,6175]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4175]]";

        public string EsriWkt =>
            "GEOGCS[Sierra Leone 1968,DATUM[Sierra_Leone_1968,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-88,4,101,0,0,0,0],AUTHORITY[EPSG,6175]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4175]]";
    }
}