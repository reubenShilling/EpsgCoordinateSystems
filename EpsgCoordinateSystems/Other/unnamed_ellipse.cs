namespace EpsgCoordinateSystems.Other
{
    public class unnamed_ellipse : IEpsgCoordinateSystem
    {
        public string Name => "unnamed ellipse";
        public string Units => "Unspecified";
public long Srid => 4901;

        public string OgcWkt =>
            "GEOGCS[unnamed ellipse,DATUM[unknown,SPHEROID[unnamed,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[degree,0.0174532925199433],AUTHORITY[EPSG,4901]]";

        public string EsriWkt => "GEOGCS[unnamed ellipse,DATUM[D_unknown,SPHEROID[Unknown,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[Degree,0.017453292519943295]]";
    }
}