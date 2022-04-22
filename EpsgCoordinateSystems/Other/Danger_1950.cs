namespace EpsgCoordinateSystems.Other
{
    public class Danger_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Danger 1950";
        public string Units => "Unspecified";
public long Srid => 5792;

        public string OgcWkt =>
            "VERT_CS[Danger 1950,VERT_DATUM[Danger 1950,2005,AUTHORITY[EPSG,5190]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5792]]";

        public string EsriWkt => "VERT_CS[Danger 1950,VERT_DATUM[Danger 1950,2005],UNIT[m,1.0]]";
    }
}