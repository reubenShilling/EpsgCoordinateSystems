using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Barinas_west_base : IEpsgCoordinateSystem
    {private const int _srid = 5816; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Barinas west base";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Barinas west base,LOCAL_DATUM[Barinas west base,0,AUTHORITY[EPSG,9311]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5816]]";

        public string EsriWkt => "";
    }
}