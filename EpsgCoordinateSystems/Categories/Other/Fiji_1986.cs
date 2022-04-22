namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fiji_1986 : IEpsgCoordinateSystem
    {
        public string Name => "Fiji 1986";
        public string Units => "Unspecified";
public int Srid => 4720;

        public string OgcWkt =>
            "GEOGCS[Fiji 1986,DATUM[Fiji_Geodetic_Datum_1986,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6720]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4720]]";

        public string EsriWkt => "GEOGCS[Fiji 1986,DATUM[D_Fiji_1986,SPHEROID[WGS_1972,6378135,298.26]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}