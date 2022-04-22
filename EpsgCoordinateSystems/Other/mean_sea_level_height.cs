namespace EpsgCoordinateSystems.Other
{
    public class mean_sea_level_height : IEpsgCoordinateSystem
    {
        public string Name => "mean sea level height";
        public string Units => "Unspecified";
public long Srid => 5714;

        public string OgcWkt =>
            "VERT_CS[mean sea level height,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5714]]";

        public string EsriWkt =>
            "VERT_CS[mean sea level height,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5714]]";
    }
}