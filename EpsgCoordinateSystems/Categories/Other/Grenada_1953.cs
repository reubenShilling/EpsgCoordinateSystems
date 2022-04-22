using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Grenada_1953 : IEpsgCoordinateSystem
    {private const int _srid = 4603; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Grenada 1953";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Grenada 1953,DATUM[Grenada_1953,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[72,213.7,93,0,0,0,0],AUTHORITY[EPSG,6603]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4603]]";

        public string EsriWkt => "GEOGCS[Grenada 1953,DATUM[D_Grenada_1953,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}