namespace EpsgCoordinateSystems.Categories.Other
{
    public class HVRS71_height : IEpsgCoordinateSystem
    {
        public string Name => "HVRS71 height";
        public string Units => "Unspecified";
public int Srid => 5610;

        public string OgcWkt =>
            "VERT_CS[HVRS71 height,VERT_DATUM[Croatian Vertical Reference System 1971,2005,AUTHORITY[EPSG,5207]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5610]]";

        public string EsriWkt => "VERT_CS[HVRS71 height,VERT_DATUM[Croatian Vertical Reference System 1971,2005],UNIT[m,1.0]]";
    }
}