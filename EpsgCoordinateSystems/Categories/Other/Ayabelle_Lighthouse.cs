using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Ayabelle_Lighthouse : IEpsgCoordinateSystem
    {private const int _srid = 4713; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Ayabelle Lighthouse";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Ayabelle Lighthouse,DATUM[Ayabelle_Lighthouse,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79,-129,145,0,0,0,0],AUTHORITY[EPSG,6713]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4713]]";

        public string EsriWkt => "GEOGCS[Ayabelle Lighthouse,DATUM[D_Ayabelle,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}