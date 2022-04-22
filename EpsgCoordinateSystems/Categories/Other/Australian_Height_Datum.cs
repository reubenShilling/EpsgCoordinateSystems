using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Australian_Height_Datum : IEpsgCoordinateSystem
    {private const int _srid = 5711; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Australian Height Datum";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Australian Height Datum,VERT_DATUM[Australian Height Datum,2005,AUTHORITY[EPSG,5111]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5711]]";

        public string EsriWkt => "VERT_CS[Australian Height Datum,VERT_DATUM[Australian Height Datum,2005],UNIT[m,1.0]]";
    }
}