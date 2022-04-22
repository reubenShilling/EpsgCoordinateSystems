namespace EpsgCoordinateSystems.Categories.Other
{
    public class Alicante : IEpsgCoordinateSystem
    {
        public string Name => "Alicante";
        public string Units => "Unspecified";
public int Srid => 5782;

        public string OgcWkt =>
            "VERT_CS[Alicante,VERT_DATUM[Alicante,2005,AUTHORITY[EPSG,5180]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5782]]";

        public string EsriWkt => "VERT_CS[Alicante,VERT_DATUM[Alicante,2005],UNIT[m,1.0]]";
    }
}