using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moorea_SAU_1981 : IEpsgCoordinateSystem
    {private const int _srid = 5602; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Moorea SAU 1981";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Moorea SAU 1981,VERT_DATUM[Moorea SAU 1981,2005,AUTHORITY[EPSG,5197]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5602]]";

        public string EsriWkt => "VERT_CS[Moorea SAU 1981,VERT_DATUM[Moorea SAU 1981,2005],UNIT[m,1.0]]";
    }
}