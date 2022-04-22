using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dabajuro : IEpsgCoordinateSystem
    {private const int _srid = 5813; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Dabajuro";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Dabajuro,LOCAL_DATUM[Dabajuro,0,AUTHORITY[EPSG,9307]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5813]]";

        public string EsriWkt => "";
    }
}