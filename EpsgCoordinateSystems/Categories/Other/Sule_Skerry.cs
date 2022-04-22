using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Sule_Skerry : IEpsgCoordinateSystem
    {private const int _srid = 5744; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Sule Skerry";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Sule Skerry,VERT_DATUM[Sule Skerry,2005,AUTHORITY[EPSG,5142]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5744]]";

        public string EsriWkt => "VERT_CS[Sule Skerry,VERT_DATUM[Sule Skerry,2005],UNIT[m,1.0]]";
    }
}