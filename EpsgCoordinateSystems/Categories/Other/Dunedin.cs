using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dunedin : IEpsgCoordinateSystem
    {private const int _srid = 5761; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Dunedin";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Dunedin,VERT_DATUM[Dunedin,2005,AUTHORITY[EPSG,5159]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5761]]";

        public string EsriWkt => "VERT_CS[Dunedin,VERT_DATUM[Dunedin,2005],UNIT[m,1.0]]";
    }
}