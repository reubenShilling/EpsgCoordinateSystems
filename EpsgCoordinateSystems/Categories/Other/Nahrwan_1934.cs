using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nahrwan_1934 : IEpsgCoordinateSystem
    {private const int _srid = 4744; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nahrwan 1934";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Nahrwan 1934,DATUM[Nahrwan_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6744]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4744]]";

        public string EsriWkt => "GEOGCS[Nahrwan 1934,DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}