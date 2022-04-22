namespace EpsgCoordinateSystems.Other
{
    public class Astra_Minas_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Astra Minas Grid";
        public string Units => "Unspecified";
public long Srid => 5800;

        public string OgcWkt =>
            "LOCAL_CS[Astra Minas Grid,LOCAL_DATUM[Astra Minas,0,AUTHORITY[EPSG,9300]],UNIT[m,1.0],AXIS[First local axis,NORTH],AXIS[Second local axis,WEST],AUTHORITY[EPSG,5800]]";

        public string EsriWkt =>
            "LOCAL_CS[Astra Minas Grid,LOCAL_DATUM[Astra Minas,0,AUTHORITY[EPSG,9300]],UNIT[m,1.0],AXIS[First local axis,NORTH],AXIS[Second local axis,WEST],AUTHORITY[EPSG,5800]]";
    }
}