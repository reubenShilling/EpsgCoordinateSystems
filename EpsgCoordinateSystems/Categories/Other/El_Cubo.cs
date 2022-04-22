using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class El_Cubo : IEpsgCoordinateSystem
    {private const int _srid = 5812; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "El Cubo";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[El Cubo,LOCAL_DATUM[El Cubo,0,AUTHORITY[EPSG,9306]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5812]]";

        public string EsriWkt => "";
    }
}