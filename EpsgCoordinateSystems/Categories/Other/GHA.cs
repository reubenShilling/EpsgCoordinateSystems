using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class GHA : IEpsgCoordinateSystem
    {private const int _srid = 5778; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "GHA";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[GHA,VERT_DATUM[Gebrauchshohen ADRIA,2005,AUTHORITY[EPSG,5176]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5778]]";

        public string EsriWkt => "VERT_CS[GHA,VERT_DATUM[Gebrauchshohen ADRIA,2005],UNIT[m,1.0]]";
    }
}