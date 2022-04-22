using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Newlyn : IEpsgCoordinateSystem
    {private const int _srid = 5701; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Newlyn";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005,AUTHORITY[EPSG,5101]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5701]]";

        public string EsriWkt => "VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005],UNIT[m,1.0]]";
    }
}