namespace EpsgCoordinateSystems.Categories.Other
{
    public class Japanese_Standard_Levelling_Datum : IEpsgCoordinateSystem
    {
        public string Name => "Japanese Standard Levelling Datum";
        public string Units => "Unspecified";
public int Srid => 5723;

        public string OgcWkt =>
            "VERT_CS[Japanese Standard Levelling Datum,VERT_DATUM[Japanese Standard Levelling Datum 1949,2005,AUTHORITY[EPSG,5122]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5723]]";

        public string EsriWkt => "VERT_CS[Japanese Standard Levelling Datum,VERT_DATUM[Japanese Standard Levelling Datum 1949,2005],UNIT[m,1.0]]";
    }
}