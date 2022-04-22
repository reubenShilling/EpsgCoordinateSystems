namespace EpsgCoordinateSystems.Other
{
    public class Pico_de_la_Nieves : IEpsgCoordinateSystem
    {
        public string Name => "Pico de la Nieves";
        public string Units => "Unspecified";
public long Srid => 4728;

        public string OgcWkt =>
            "GEOGCS[Pico de la Nieves,DATUM[Pico_de_la_Nieves,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-307,-92,127,0,0,0,0],AUTHORITY[EPSG,6728]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4728]]";

        public string EsriWkt => "GEOGCS[Pico de la Nieves,DATUM[D_Pico_de_Las_Nieves,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}