using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Egypt_1907 : IEpsgCoordinateSystem
    {private const int _srid = 4229; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Egypt 1907";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Egypt 1907,DATUM[Egypt_1907,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6229]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4229]]";

        public string EsriWkt => "GEOGCS[Egypt 1907,DATUM[D_Egypt_1907,SPHEROID[Helmert_1906,6378200,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}