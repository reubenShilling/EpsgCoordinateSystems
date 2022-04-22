using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class St_Lucia_1955 : IEpsgCoordinateSystem
    {private const int _srid = 4606; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "St. Lucia 1955";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[St. Lucia 1955,DATUM[St_Lucia_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-149,128,296,0,0,0,0],AUTHORITY[EPSG,6606]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4606]]";

        public string EsriWkt => "GEOGCS[St. Lucia 1955,DATUM[D_St_Lucia_1955,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}