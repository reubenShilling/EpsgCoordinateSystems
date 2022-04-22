using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Loma_Quintana : IEpsgCoordinateSystem
    {private const int _srid = 4288; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Loma Quintana";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Loma Quintana,DATUM[Loma_Quintana,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6288]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4288]]";

        public string EsriWkt => "GEOGCS[Loma Quintana,DATUM[D_Loma_Quintana,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}