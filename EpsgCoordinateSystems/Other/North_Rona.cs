namespace EpsgCoordinateSystems.Other
{
    public class North_Rona : IEpsgCoordinateSystem
    {
        public string Name => "North Rona";
        public string Units => "Unspecified";
public long Srid => 5745;

        public string OgcWkt =>
            "VERT_CS[North Rona,VERT_DATUM[North Rona,2005,AUTHORITY[EPSG,5143]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5745]]";

        public string EsriWkt => "VERT_CS[North Rona,VERT_DATUM[North Rona,2005],UNIT[m,1.0]]";
    }
}