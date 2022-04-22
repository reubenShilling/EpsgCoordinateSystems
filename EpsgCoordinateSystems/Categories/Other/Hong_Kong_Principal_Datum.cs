using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hong_Kong_Principal_Datum : IEpsgCoordinateSystem
    {private const int _srid = 5738; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hong Kong Principal Datum";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Hong Kong Principal Datum,VERT_DATUM[Hong Kong Principal Datum,2005,AUTHORITY[EPSG,5135]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5738]]";

        public string EsriWkt => "VERT_CS[Hong Kong Principal Datum,VERT_DATUM[Hong Kong Principal Datum,2005],UNIT[m,1.0]]";
    }
}