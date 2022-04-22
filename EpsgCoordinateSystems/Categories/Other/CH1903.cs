namespace EpsgCoordinateSystems.Categories.Other
{
    public class CH1903 : IEpsgCoordinateSystem
    {
        public string Name => "CH1903";
        public string Units => "Unspecified";
public int Srid => 4149;

        public string OgcWkt =>
            "GEOGCS[CH1903,DATUM[CH1903,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[674.374,15.056,405.346,0,0,0,0],AUTHORITY[EPSG,6149]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4149]]";

        public string EsriWkt => "GEOGCS[CH1903,DATUM[D_CH1903,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}