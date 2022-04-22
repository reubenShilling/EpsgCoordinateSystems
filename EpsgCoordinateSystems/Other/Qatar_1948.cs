namespace EpsgCoordinateSystems.Other
{
    public class Qatar_1948 : IEpsgCoordinateSystem
    {
        public string Name => "Qatar 1948";
        public string Units => "Unspecified";
public long Srid => 4286;

        public string OgcWkt =>
            "GEOGCS[Qatar 1948,DATUM[Qatar_1948,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6286]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4286]]";

        public string EsriWkt =>
            "GEOGCS[Qatar 1948,DATUM[Qatar_1948,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6286]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4286]]";
    }
}