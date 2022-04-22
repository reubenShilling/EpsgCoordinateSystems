namespace EpsgCoordinateSystems.Other
{
    public class IGN_1988_MG_height : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1988 MG height";
        public string Units => "Unspecified";
public long Srid => 5617;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 MG height,VERT_DATUM[IGN 1988 MG,2005,AUTHORITY[EPSG,5211]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5617]]";

        public string EsriWkt =>
            "VERT_CS[IGN 1988 MG height,VERT_DATUM[IGN 1988 MG,2005,AUTHORITY[EPSG,5211]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5617]]";
    }
}