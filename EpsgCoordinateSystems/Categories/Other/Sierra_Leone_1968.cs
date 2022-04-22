using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Sierra_Leone_1968 : IEpsgCoordinateSystem
    {private const int _srid = 4175; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Sierra Leone 1968";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Sierra Leone 1968,DATUM[Sierra_Leone_1968,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-88,4,101,0,0,0,0],AUTHORITY[EPSG,6175]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4175]]";

        public string EsriWkt => "GEOGCS[Sierra Leone 1968,DATUM[D_Sierra_Leone_1968,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}