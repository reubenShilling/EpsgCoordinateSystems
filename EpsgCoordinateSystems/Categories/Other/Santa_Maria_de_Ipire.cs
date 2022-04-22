namespace EpsgCoordinateSystems.Categories.Other
{
    public class Santa_Maria_de_Ipire : IEpsgCoordinateSystem
    {
        public string Name => "Santa Maria de Ipire";
        public string Units => "Unspecified";
public int Srid => 5815;

        public string OgcWkt =>
            "LOCAL_CS[Santa Maria de Ipire,LOCAL_DATUM[Santa Maria de Ipire,0,AUTHORITY[EPSG,9310]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5815]]";

        public string EsriWkt => "";
    }
}