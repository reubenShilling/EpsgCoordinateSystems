using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bora_Bora_SAU_2001 : IEpsgCoordinateSystem
    {private const int _srid = 5607; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bora Bora SAU 2001";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Bora Bora SAU 2001,VERT_DATUM[Bora Bora SAU 2001,2005,AUTHORITY[EPSG,5202]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5607]]";

        public string EsriWkt => "VERT_CS[Bora Bora SAU 2001,VERT_DATUM[Bora Bora SAU 2001,2005],UNIT[m,1.0]]";
    }
}