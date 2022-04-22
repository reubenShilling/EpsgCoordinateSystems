namespace EpsgCoordinateSystems.Other
{
    public class Kuwait_PWD : IEpsgCoordinateSystem
    {
        public string Name => "Kuwait PWD";
        public string Units => "Unspecified";
public long Srid => 5788;

        public string OgcWkt =>
            "VERT_CS[Kuwait PWD,VERT_DATUM[Kuwait PWD,2005,AUTHORITY[EPSG,5186]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5788]]";

        public string EsriWkt =>
            "VERT_CS[Kuwait PWD,VERT_DATUM[Kuwait PWD,2005,AUTHORITY[EPSG,5186]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5788]]";
    }
}