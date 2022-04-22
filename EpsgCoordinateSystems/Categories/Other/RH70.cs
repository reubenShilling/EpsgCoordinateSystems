using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RH70 : IEpsgCoordinateSystem
    {private const int _srid = 5718; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RH70";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005,AUTHORITY[EPSG,5117]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5718]]";

        public string EsriWkt => "VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005],UNIT[m,1.0]]";
    }
}