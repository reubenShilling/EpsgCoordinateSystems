namespace EpsgCoordinateSystems.Other
{
    public class EVRF2000 : IEpsgCoordinateSystem
    {
        public string Name => "EVRF2000";
        public string Units => "Unspecified";
public long Srid => 5730;

        public string OgcWkt =>
            "VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005,AUTHORITY[EPSG,5129]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5730]]";

        public string EsriWkt => "VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005],UNIT[m,1.0]]";
    }
}