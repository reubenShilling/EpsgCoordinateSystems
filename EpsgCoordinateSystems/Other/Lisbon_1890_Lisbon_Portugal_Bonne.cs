namespace EpsgCoordinateSystems.Other
{
    public class Lisbon_1890_Lisbon_Portugal_Bonne : IEpsgCoordinateSystem
    {
        public string Name => "Lisbon 1890 (Lisbon) / Portugal Bonne";
        public string Units => "Unspecified";
public long Srid => 2963;

        public string OgcWkt =>
            "PROJCS[Lisbon 1890 (Lisbon) / Portugal Bonne,GEOGCS[Lisbon 1890 (Lisbon),DATUM[Lisbon_1890_Lisbon,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6904]],PRIMEM[Lisbon,-9.131906111111112,AUTHORITY[EPSG,8902]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4904],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[Lisbon 1890 (Lisbon) / Portugal Bonne,GEOGCS[Lisbon 1890 (Lisbon),DATUM[D_Lisbon_1890,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Lisbon,-9.131906111111112],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}