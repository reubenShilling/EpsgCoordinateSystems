using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Belfast : IEpsgCoordinateSystem
    {private const int _srid = 5732; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Belfast";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Belfast,VERT_DATUM[Belfast Lough,2005,AUTHORITY[EPSG,5131]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5732]]";

        public string EsriWkt => "VERT_CS[Belfast,VERT_DATUM[Belfast Lough,2005],UNIT[m,1.0]]";
    }
}