namespace EpsgCoordinateSystems.Other
{
    public class Douglas : IEpsgCoordinateSystem
    {
        public string Name => "Douglas";
        public string Units => "Unspecified";
public long Srid => 5750;

        public string OgcWkt =>
            "VERT_CS[Douglas,VERT_DATUM[Douglas,2005,AUTHORITY[EPSG,5148]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5750]]";

        public string EsriWkt =>
            "VERT_CS[Douglas,VERT_DATUM[Douglas,2005,AUTHORITY[EPSG,5148]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5750]]";
    }
}