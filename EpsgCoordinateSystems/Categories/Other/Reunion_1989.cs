using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Reunion_1989 : IEpsgCoordinateSystem
    {private const int _srid = 5758; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Reunion 1989";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Reunion 1989,VERT_DATUM[Reunion 1989,2005,AUTHORITY[EPSG,5156]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5758]]";

        public string EsriWkt => "VERT_CS[Reunion 1989,VERT_DATUM[Reunion 1989,2005],UNIT[m,1.0]]";
    }
}