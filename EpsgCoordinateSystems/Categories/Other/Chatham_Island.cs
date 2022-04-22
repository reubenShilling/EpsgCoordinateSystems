using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Chatham_Island : IEpsgCoordinateSystem
    {private const int _srid = 5771; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Chatham Island";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Chatham Island,VERT_DATUM[Chatham Island,2005,AUTHORITY[EPSG,5169]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5771]]";

        public string EsriWkt => "VERT_CS[Chatham Island,VERT_DATUM[Chatham Island,2005],UNIT[m,1.0]]";
    }
}