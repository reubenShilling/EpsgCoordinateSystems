using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class DHHN85 : IEpsgCoordinateSystem
    {private const int _srid = 5784; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "DHHN85";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[DHHN85,VERT_DATUM[Deutches Haupthohennetz 1985,2005,AUTHORITY[EPSG,5182]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5784]]";

        public string EsriWkt => "VERT_CS[DHHN85,VERT_DATUM[Deutches Haupthohennetz 1985,2005],UNIT[m,1.0]]";
    }
}