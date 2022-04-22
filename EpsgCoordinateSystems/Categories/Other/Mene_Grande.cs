using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mene_Grande : IEpsgCoordinateSystem
    {private const int _srid = 5811; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mene Grande";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Mene Grande,LOCAL_DATUM[Mene Grande,0,AUTHORITY[EPSG,9305]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5811]]";

        public string EsriWkt => "";
    }
}