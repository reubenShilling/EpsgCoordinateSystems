using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Stewart_Island : IEpsgCoordinateSystem
    {private const int _srid = 5772; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Stewart Island";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Stewart Island,VERT_DATUM[Stewart Island,2005,AUTHORITY[EPSG,5170]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5772]]";

        public string EsriWkt => "VERT_CS[Stewart Island,VERT_DATUM[Stewart Island,2005],UNIT[m,1.0]]";
    }
}