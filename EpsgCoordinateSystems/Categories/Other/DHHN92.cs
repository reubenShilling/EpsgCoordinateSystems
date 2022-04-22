using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class DHHN92 : IEpsgCoordinateSystem
    {private const int _srid = 5783; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "DHHN92";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[DHHN92,VERT_DATUM[Deutches Haupthohennetz 1992,2005,AUTHORITY[EPSG,5181]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5783]]";

        public string EsriWkt => "VERT_CS[DHHN92,VERT_DATUM[Deutches Haupthohennetz 1992,2005],UNIT[m,1.0]]";
    }
}