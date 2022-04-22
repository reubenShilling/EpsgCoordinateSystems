using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class St_Vincent_1945 : IEpsgCoordinateSystem
    {private const int _srid = 4607; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "St. Vincent 1945";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[St. Vincent 1945,DATUM[St_Vincent_1945,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[195.671,332.517,274.607,0,0,0,0],AUTHORITY[EPSG,6607]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4607]]";

        public string EsriWkt => "GEOGCS[St. Vincent 1945,DATUM[D_St_Vincent_1945,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}