using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Antalya : IEpsgCoordinateSystem
    {private const int _srid = 5775; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Antalya";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Antalya,VERT_DATUM[Antalya,2005,AUTHORITY[EPSG,5173]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5775]]";

        public string EsriWkt => "VERT_CS[Antalya,VERT_DATUM[Antalya,2005],UNIT[m,1.0]]";
    }
}