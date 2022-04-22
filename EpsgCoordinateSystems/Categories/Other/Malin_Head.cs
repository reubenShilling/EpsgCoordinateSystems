using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Malin_Head : IEpsgCoordinateSystem
    {private const int _srid = 5731; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Malin Head";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Malin Head,VERT_DATUM[Malin Head,2005,AUTHORITY[EPSG,5130]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5731]]";

        public string EsriWkt => "VERT_CS[Malin Head,VERT_DATUM[Malin Head,2005],UNIT[m,1.0]]";
    }
}