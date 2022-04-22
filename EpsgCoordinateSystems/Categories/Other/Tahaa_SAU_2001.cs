using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tahaa_SAU_2001 : IEpsgCoordinateSystem
    {private const int _srid = 5606; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tahaa SAU 2001";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Tahaa SAU 2001,VERT_DATUM[Tahaa SAU 2001,2005,AUTHORITY[EPSG,5201]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5606]]";

        public string EsriWkt => "VERT_CS[Tahaa SAU 2001,VERT_DATUM[Tahaa SAU 2001,2005],UNIT[m,1.0]]";
    }
}