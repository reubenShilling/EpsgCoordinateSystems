using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Canadian_Geodetic_Vertical_Datum_of_1928 : IEpsgCoordinateSystem
    {private const int _srid = 5713; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Canadian Geodetic Vertical Datum of 1928";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Canadian Geodetic Vertical Datum of 1928,VERT_DATUM[Canadian Geodetic Vertical Datum of 1928,2005,AUTHORITY[EPSG,5114]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5713]]";

        public string EsriWkt => "VERT_CS[Canadian Geodetic Vertical Datum of 1928,VERT_DATUM[Canadian Geodetic Vertical Datum of 1928,2005],UNIT[m,1.0]]";
    }
}