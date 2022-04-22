using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class SAD69 : IEpsgCoordinateSystem
    {private const int _srid = 4618; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "SAD69";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[SAD69,DATUM[South_American_Datum_1969,SPHEROID[GRS 1967 (SAD69),6378160,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,6618]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4618]]";

        public string EsriWkt => "GEOGCS[SAD69,DATUM[D_South_American_1969,SPHEROID[GRS_1967_SAD69,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}