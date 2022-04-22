namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fahud_Height_Datum_1993 : IEpsgCoordinateSystem
    {
        public string Name => "Fahud Height Datum 1993";
        public string Units => "Unspecified";
public int Srid => 5725;

        public string OgcWkt =>
            "VERT_CS[Fahud Height Datum 1993,VERT_DATUM[Fahud Height Datum,2005,AUTHORITY[EPSG,5124]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5725]]";

        public string EsriWkt => "VERT_CS[Fahud Height Datum 1993,VERT_DATUM[Fahud Height Datum,2005],UNIT[m,1.0]]";
    }
}