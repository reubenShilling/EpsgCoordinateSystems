using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Black_Sea : IEpsgCoordinateSystem
    {private const int _srid = 5735; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Black Sea";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Black Sea,VERT_DATUM[Black Sea,2005,AUTHORITY[EPSG,5134]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5735]]";

        public string EsriWkt => "VERT_CS[Black Sea,VERT_DATUM[Black Sea,2005],UNIT[m,1.0]]";
    }
}