using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Maracaibo_Cross_Grid_M5 : IEpsgCoordinateSystem
    {private const int _srid = 5809; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maracaibo Cross Grid M5";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Maracaibo Cross Grid M5,LOCAL_DATUM[Maracaibo Cross,0,AUTHORITY[EPSG,9303]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5809]]";

        public string EsriWkt => "";
    }
}