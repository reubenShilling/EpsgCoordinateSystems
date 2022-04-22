using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Maturin_Grid : IEpsgCoordinateSystem
    {private const int _srid = 5803; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maturin Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Maturin Grid,LOCAL_DATUM[Maturin,0,AUTHORITY[EPSG,9302]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5803]]";

        public string EsriWkt => "";
    }
}