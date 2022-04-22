using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mayotte_1950 : IEpsgCoordinateSystem
    {private const int _srid = 5793; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mayotte 1950";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Mayotte 1950,VERT_DATUM[Mayotte 1950,2005,AUTHORITY[EPSG,5191]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5793]]";

        public string EsriWkt => "VERT_CS[Mayotte 1950,VERT_DATUM[Mayotte 1950,2005],UNIT[m,1.0]]";
    }
}