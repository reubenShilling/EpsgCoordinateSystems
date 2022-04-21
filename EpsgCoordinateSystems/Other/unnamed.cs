namespace EpsgCoordinateSystems.Other
{
    public class unnamed : IEpsgCoordinateSystem
    {
        public string Name => "unnamed";
        public long Srid => 27500;

        public string OgcWkt =>
            "PROJCS[unnamed,GEOGCS[unnamed ellipse,DATUM[unknown,SPHEROID[unnamed,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[degree,0.0174532925199433]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,49.5],PARAMETER[central_meridian,5.4],PARAMETER[scale_factor,0.99950908],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],UNIT[Meter,1],AUTHORITY[EPSG,27500]]";

        public string EsriWkt =>
            "PROJCS[unnamed,GEOGCS[unnamed ellipse,DATUM[unknown,SPHEROID[unnamed,6376523,308.6399999999995]],PRIMEM[paris,2.3372291666985],UNIT[degree,0.0174532925199433]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,49.5],PARAMETER[central_meridian,5.4],PARAMETER[scale_factor,0.99950908],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],UNIT[Meter,1],AUTHORITY[EPSG,27500]]";
    }
}