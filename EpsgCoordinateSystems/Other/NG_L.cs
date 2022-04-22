namespace EpsgCoordinateSystems.Other
{
    public class NG_L : IEpsgCoordinateSystem
    {
        public string Name => "NG-L";
        public string Units => "Unspecified";
public long Srid => 5774;

        public string OgcWkt =>
            "VERT_CS[NG-L,VERT_DATUM[Nivellement General du Luxembourg,2005,AUTHORITY[EPSG,5172]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5774]]";

        public string EsriWkt =>
            "VERT_CS[NG-L,VERT_DATUM[Nivellement General du Luxembourg,2005,AUTHORITY[EPSG,5172]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5774]]";
    }
}