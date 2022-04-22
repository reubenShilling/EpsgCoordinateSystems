using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nouakchott_1965 : IEpsgCoordinateSystem
    {private const int _srid = 4680; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nouakchott 1965";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Nouakchott 1965,DATUM[Nouakchott_1965,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[124.5,-63.5,-281,0,0,0,0],AUTHORITY[EPSG,6680]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4680]]";

        public string EsriWkt => "GEOGCS[Nouakchott 1965,DATUM[D_Nouakchott_1965,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}