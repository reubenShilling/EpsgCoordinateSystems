using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KUDAMS : IEpsgCoordinateSystem
    {private const int _srid = 4319; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KUDAMS";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[KUDAMS,DATUM[Kuwait_Utility,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6319]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4319]]";

        public string EsriWkt => "GEOGCS[KUDAMS,DATUM[D_Kuwait_Utility,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}