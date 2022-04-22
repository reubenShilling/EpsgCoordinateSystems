namespace EpsgCoordinateSystems.Categories.Other
{
    public class NGO_1948 : IEpsgCoordinateSystem
    {
        public string Name => "NGO 1948";
        public string Units => "Unspecified";
public int Srid => 4273;

        public string OgcWkt =>
            "GEOGCS[NGO 1948,DATUM[NGO_1948,SPHEROID[Bessel Modified,6377492.018,299.1528128,AUTHORITY[EPSG,7005]],TOWGS84[278.3,93,474.5,7.889,0.05,-6.61,6.21],AUTHORITY[EPSG,6273]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4273]]";

        public string EsriWkt => "GEOGCS[NGO 1948,DATUM[D_NGO_1948,SPHEROID[Bessel_Modified,6377492.018,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}