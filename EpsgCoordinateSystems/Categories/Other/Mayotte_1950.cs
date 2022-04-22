namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mayotte_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Mayotte 1950";
        public string Units => "Unspecified";
public int Srid => 5793;

        public string OgcWkt =>
            "VERT_CS[Mayotte 1950,VERT_DATUM[Mayotte 1950,2005,AUTHORITY[EPSG,5191]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5793]]";

        public string EsriWkt => "VERT_CS[Mayotte 1950,VERT_DATUM[Mayotte 1950,2005],UNIT[m,1.0]]";
    }
}