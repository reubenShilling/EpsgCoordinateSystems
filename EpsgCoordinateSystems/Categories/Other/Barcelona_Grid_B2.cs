using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Barcelona_Grid_B2 : IEpsgCoordinateSystem
    {private const int _srid = 5802; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Barcelona Grid B2";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Barcelona Grid B2,LOCAL_DATUM[Barcelona,0,AUTHORITY[EPSG,9301]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5802]]";

        public string EsriWkt => "";
    }
}