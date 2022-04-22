namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lerwick : IEpsgCoordinateSystem
    {
        public string Name => "Lerwick";
        public string Units => "Unspecified";
public int Srid => 5742;

        public string OgcWkt =>
            "VERT_CS[Lerwick,VERT_DATUM[Lerwick,2005,AUTHORITY[EPSG,5140]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5742]]";

        public string EsriWkt => "VERT_CS[Lerwick,VERT_DATUM[Lerwick,2005],UNIT[m,1.0]]";
    }
}