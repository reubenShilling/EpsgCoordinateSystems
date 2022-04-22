using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class North_Rona : IEpsgCoordinateSystem
    {private const int _srid = 5745; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "North Rona";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[North Rona,VERT_DATUM[North Rona,2005,AUTHORITY[EPSG,5143]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5745]]";

        public string EsriWkt => "VERT_CS[North Rona,VERT_DATUM[North Rona,2005],UNIT[m,1.0]]";
    }
}