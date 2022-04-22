namespace EpsgCoordinateSystems.Other
{
    public class Fair_Isle : IEpsgCoordinateSystem
    {
        public string Name => "Fair Isle";
        public string Units => "Unspecified";
public long Srid => 5741;

        public string OgcWkt =>
            "VERT_CS[Fair Isle,VERT_DATUM[Fair Isle,2005,AUTHORITY[EPSG,5139]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5741]]";

        public string EsriWkt => "VERT_CS[Fair Isle,VERT_DATUM[Fair Isle,2005],UNIT[m,1.0]]";
    }
}