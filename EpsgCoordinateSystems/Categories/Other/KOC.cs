using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KOC : IEpsgCoordinateSystem
    {private const int _srid = 4246; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KOC";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[KOC,DATUM[Kuwait_Oil_Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0,0,0,0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4246]]";

        public string EsriWkt => "GEOGCS[KOC,DATUM[D_Kuwait_Oil_Company,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}