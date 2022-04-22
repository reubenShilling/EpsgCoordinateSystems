namespace EpsgCoordinateSystems.Categories.Other
{
    public class Stornoway : IEpsgCoordinateSystem
    {
        public string Name => "Stornoway";
        public string Units => "Unspecified";
public int Srid => 5746;

        public string OgcWkt =>
            "VERT_CS[Stornoway,VERT_DATUM[Stornoway,2005,AUTHORITY[EPSG,5144]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5746]]";

        public string EsriWkt => "VERT_CS[Stornoway,VERT_DATUM[Stornoway,2005],UNIT[m,1.0]]";
    }
}