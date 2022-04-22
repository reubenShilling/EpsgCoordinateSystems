namespace EpsgCoordinateSystems.Other
{
    public class Tokyo_JSLD : IEpsgCoordinateSystem
    {
        public string Name => "Tokyo + JSLD";
        public string Units => "Unspecified";
public long Srid => 7414;

        public string OgcWkt =>
            "COMPD_CS[Tokyo + JSLD,GEOGCS[Tokyo,DATUM[Tokyo,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-147.0,506.0,687.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6301]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4301]],VERT_CS[Japanese Standard Levelling Datum,VERT_DATUM[Japanese Standard Levelling Datum 1949,2005,AUTHORITY[EPSG,5122]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5723]],AUTHORITY[EPSG,7414]]";

        public string EsriWkt =>
            "COMPD_CS[Tokyo + JSLD,GEOGCS[Tokyo,DATUM[Tokyo,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-147.0,506.0,687.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6301]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4301]],VERT_CS[Japanese Standard Levelling Datum,VERT_DATUM[Japanese Standard Levelling Datum 1949,2005,AUTHORITY[EPSG,5122]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5723]],AUTHORITY[EPSG,7414]]";
    }
}