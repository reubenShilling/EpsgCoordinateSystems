using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class PDO_Height_Datum_1993 : IEpsgCoordinateSystem
    {private const int _srid = 5724; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "PDO Height Datum 1993";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[PDO Height Datum 1993,VERT_DATUM[PDO Height Datum 1993,2005,AUTHORITY[EPSG,5123]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5724]]";

        public string EsriWkt => "VERT_CS[PDO Height Datum 1993,VERT_DATUM[PDO Height Datum 1993,2005],UNIT[m,1.0]]";
    }
}