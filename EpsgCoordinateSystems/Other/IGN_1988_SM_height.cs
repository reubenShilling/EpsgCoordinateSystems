namespace EpsgCoordinateSystems.Other
{
    public class IGN_1988_SM_height : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1988 SM height";
        public string Units => "Unspecified";
public long Srid => 5620;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 SM height,VERT_DATUM[IGN 1988 SM,2005,AUTHORITY[EPSG,5214]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5620]]";

        public string EsriWkt => "VERT_CS[IGN 1988 SM height,VERT_DATUM[IGN 1988 SM,2005],UNIT[m,1.0]]";
    }
}