using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Danger_1950 : IEpsgCoordinateSystem
    {private const int _srid = 5792; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Danger 1950";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Danger 1950,VERT_DATUM[Danger 1950,2005,AUTHORITY[EPSG,5190]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5792]]";

        public string EsriWkt => "VERT_CS[Danger 1950,VERT_DATUM[Danger 1950,2005],UNIT[m,1.0]]";
    }
}