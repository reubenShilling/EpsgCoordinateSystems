namespace EpsgCoordinateSystems.Categories.Other
{
    public class Auckland : IEpsgCoordinateSystem
    {
        public string Name => "Auckland";
        public string Units => "Unspecified";
public int Srid => 5759;

        public string OgcWkt =>
            "VERT_CS[Auckland,VERT_DATUM[Auckland,2005,AUTHORITY[EPSG,5157]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5759]]";

        public string EsriWkt => "VERT_CS[Auckland,VERT_DATUM[Auckland,2005],UNIT[m,1.0]]";
    }
}