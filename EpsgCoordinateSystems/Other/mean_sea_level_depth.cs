namespace EpsgCoordinateSystems.Other
{
    public class mean_sea_level_depth : IEpsgCoordinateSystem
    {
        public string Name => "mean sea level depth";
        public string Units => "Unspecified";
public long Srid => 5715;

        public string OgcWkt =>
            "VERT_CS[mean sea level depth,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5715]]";

        public string EsriWkt =>
            "VERT_CS[mean sea level depth,VERT_DATUM[Mean Sea Level,2005,AUTHORITY[EPSG,5100]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5715]]";
    }
}