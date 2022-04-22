using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Caspian_height : IEpsgCoordinateSystem
    {private const int _srid = 5611; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Caspian height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Caspian height,VERT_DATUM[Caspian Sea,2005,AUTHORITY[EPSG,5106]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5611]]";

        public string EsriWkt => "VERT_CS[Caspian height,VERT_DATUM[Caspian Sea,2005],UNIT[m,1.0]]";
    }
}