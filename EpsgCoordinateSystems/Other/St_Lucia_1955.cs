namespace EpsgCoordinateSystems.Other
{
    public class St_Lucia_1955 : IEpsgCoordinateSystem
    {
        public string Name => "St. Lucia 1955";
        public string Units => "Unspecified";
public long Srid => 4606;

        public string OgcWkt =>
            "GEOGCS[St. Lucia 1955,DATUM[St_Lucia_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-149,128,296,0,0,0,0],AUTHORITY[EPSG,6606]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4606]]";

        public string EsriWkt =>
            "GEOGCS[St. Lucia 1955,DATUM[St_Lucia_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-149,128,296,0,0,0,0],AUTHORITY[EPSG,6606]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4606]]";
    }
}