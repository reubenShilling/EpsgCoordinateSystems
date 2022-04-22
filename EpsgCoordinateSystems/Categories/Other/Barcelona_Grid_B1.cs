using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Barcelona_Grid_B1 : IEpsgCoordinateSystem
    {private const int _srid = 5801; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Barcelona Grid B1";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Barcelona Grid B1,LOCAL_DATUM[Barcelona,0,AUTHORITY[EPSG,9301]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5801]]";

        public string EsriWkt => "";
    }
}