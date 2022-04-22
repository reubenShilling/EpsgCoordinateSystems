namespace EpsgCoordinateSystems.Categories.Other
{
    public class RD_NAP : IEpsgCoordinateSystem
    {
        public string Name => "RD/NAP";
        public string Units => "Unspecified";
public int Srid => 7408;

        public string OgcWkt =>
            "COMPD_CS[RD/NAP,GEOGCS[Amersfoort,DATUM[Amersfoort,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[565.04,49.91,465.84,-0.40939438743923684,-0.35970519561431136,1.868491000350572,0.8409828680306614],AUTHORITY[EPSG,6289]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4289]],VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005,AUTHORITY[EPSG,5109]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5709]],AUTHORITY[EPSG,7408]]";

        public string EsriWkt => "COMPD_CS[RD/NAP,GEOGCS[Amersfoort,DATUM[D_Amersfoort,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005],UNIT[m,1.0]]]";
    }
}