namespace EpsgCoordinateSystems.Categories.Other
{
    public class Schwarzeck : IEpsgCoordinateSystem
    {
        public string Name => "Schwarzeck";
        public string Units => "Unspecified";
public int Srid => 4293;

        public string OgcWkt =>
            "GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]]";

        public string EsriWkt => "GEOGCS[Schwarzeck,DATUM[D_Schwarzeck,SPHEROID[Bessel_Namibia_GLM,6377483.865280419,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}