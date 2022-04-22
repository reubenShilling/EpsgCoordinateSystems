using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class La_Rosa_Grid : IEpsgCoordinateSystem
    {private const int _srid = 5810; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "La Rosa Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[La Rosa Grid,LOCAL_DATUM[La Rosa,0,AUTHORITY[EPSG,9304]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5810]]";

        public string EsriWkt => "";
    }
}