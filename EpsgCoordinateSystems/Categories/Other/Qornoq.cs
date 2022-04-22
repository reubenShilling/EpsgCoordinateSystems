using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Qornoq : IEpsgCoordinateSystem
    {private const int _srid = 4287; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Qornoq";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Qornoq,DATUM[Qornoq,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[164,138,-189,0,0,0,0],AUTHORITY[EPSG,6287]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4287]]";

        public string EsriWkt => "GEOGCS[Qornoq,DATUM[D_Qornoq,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}