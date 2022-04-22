namespace EpsgCoordinateSystems.Categories.Other
{
    public class Korean_1985 : IEpsgCoordinateSystem
    {
        public string Name => "Korean 1985";
        public string Units => "Unspecified";
public int Srid => 4162;

        public string OgcWkt =>
            "GEOGCS[Korean 1985,DATUM[Korean_Datum_1985,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6162]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4162]]";

        public string EsriWkt => "GEOGCS[Korean 1985,DATUM[D_Korean_Datum_1985,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}