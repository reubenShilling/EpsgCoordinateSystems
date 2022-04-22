using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class EGM96_geoid : IEpsgCoordinateSystem
    {private const int _srid = 5773; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "EGM96 geoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[EGM96 geoid,VERT_DATUM[EGM96 geoid,2005,AUTHORITY[EPSG,5171]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5773]]";

        public string EsriWkt => "VERT_CS[EGM96 geoid,VERT_DATUM[EGM96 geoid,2005],UNIT[m,1.0]]";
    }
}