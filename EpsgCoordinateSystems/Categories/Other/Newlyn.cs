namespace EpsgCoordinateSystems.Categories.Other
{
    public class Newlyn : IEpsgCoordinateSystem
    {
        public string Name => "Newlyn";
        public string Units => "Unspecified";
public int Srid => 5701;

        public string OgcWkt =>
            "VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005,AUTHORITY[EPSG,5101]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5701]]";

        public string EsriWkt => "VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005],UNIT[m,1.0]]";
    }
}