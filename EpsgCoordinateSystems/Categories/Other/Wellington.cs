namespace EpsgCoordinateSystems.Categories.Other
{
    public class Wellington : IEpsgCoordinateSystem
    {
        public string Name => "Wellington";
        public string Units => "Unspecified";
public int Srid => 5770;

        public string OgcWkt =>
            "VERT_CS[Wellington,VERT_DATUM[Wellington,2005,AUTHORITY[EPSG,5168]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5770]]";

        public string EsriWkt => "VERT_CS[Wellington,VERT_DATUM[Wellington,2005],UNIT[m,1.0]]";
    }
}