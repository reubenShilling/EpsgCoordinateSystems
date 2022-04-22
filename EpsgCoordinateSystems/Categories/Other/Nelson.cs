using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nelson : IEpsgCoordinateSystem
    {private const int _srid = 5766; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nelson";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Nelson,VERT_DATUM[Nelson,2005,AUTHORITY[EPSG,5164]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5766]]";

        public string EsriWkt => "VERT_CS[Nelson,VERT_DATUM[Nelson,2005],UNIT[m,1.0]]";
    }
}