namespace EpsgCoordinateSystems.Other
{
    public class Baltic : IEpsgCoordinateSystem
    {
        public string Name => "Baltic";
        public string Units => "Unspecified";
public long Srid => 5705;

        public string OgcWkt =>
            "VERT_CS[Baltic,VERT_DATUM[Baltic Sea,2005,AUTHORITY[EPSG,5105]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5705]]";

        public string EsriWkt =>
            "VERT_CS[Baltic,VERT_DATUM[Baltic Sea,2005,AUTHORITY[EPSG,5105]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5705]]";
    }
}