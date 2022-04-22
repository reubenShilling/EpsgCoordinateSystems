namespace EpsgCoordinateSystems.Other
{
    public class NGPF : IEpsgCoordinateSystem
    {
        public string Name => "NGPF";
        public string Units => "Unspecified";
public long Srid => 5600;

        public string OgcWkt =>
            "VERT_CS[NGPF,VERT_DATUM[Nivellement General de Polynesie Francaise,2005,AUTHORITY[EPSG,5195]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5600]]";

        public string EsriWkt =>
            "VERT_CS[NGPF,VERT_DATUM[Nivellement General de Polynesie Francaise,2005,AUTHORITY[EPSG,5195]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5600]]";
    }
}