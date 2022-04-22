namespace EpsgCoordinateSystems.Categories.Other
{
    public class One_Tree_Point : IEpsgCoordinateSystem
    {
        public string Name => "One Tree Point";
        public string Units => "Unspecified";
public int Srid => 5767;

        public string OgcWkt =>
            "VERT_CS[One Tree Point,VERT_DATUM[One Tree Point,2005,AUTHORITY[EPSG,5165]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5767]]";

        public string EsriWkt => "VERT_CS[One Tree Point,VERT_DATUM[One Tree Point,2005],UNIT[m,1.0]]";
    }
}