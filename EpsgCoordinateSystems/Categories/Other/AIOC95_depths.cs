namespace EpsgCoordinateSystems.Categories.Other
{
    public class AIOC95_depths : IEpsgCoordinateSystem
    {
        public string Name => "AIOC95 depths";
        public string Units => "Unspecified";
public int Srid => 5734;

        public string OgcWkt =>
            "VERT_CS[AIOC95 depths,VERT_DATUM[AIOC 1995,2005,AUTHORITY[EPSG,5133]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5734]]";

        public string EsriWkt => "VERT_CS[AIOC95 depths,VERT_DATUM[AIOC 1995,2005],UNIT[m,1.0]]";
    }
}