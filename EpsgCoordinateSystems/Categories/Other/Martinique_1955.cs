using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Martinique_1955 : IEpsgCoordinateSystem
    {private const int _srid = 5794; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Martinique 1955";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Martinique 1955,VERT_DATUM[Martinique 1955,2005,AUTHORITY[EPSG,5192]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5794]]";

        public string EsriWkt => "VERT_CS[Martinique 1955,VERT_DATUM[Martinique 1955,2005],UNIT[m,1.0]]";
    }
}