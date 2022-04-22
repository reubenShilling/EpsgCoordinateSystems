namespace EpsgCoordinateSystems.Other
{
    public class La_Rosa_Grid : IEpsgCoordinateSystem
    {
        public string Name => "La Rosa Grid";
        public string Units => "Unspecified";
public long Srid => 5810;

        public string OgcWkt =>
            "LOCAL_CS[La Rosa Grid,LOCAL_DATUM[La Rosa,0,AUTHORITY[EPSG,9304]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5810]]";

        public string EsriWkt => "";
    }
}