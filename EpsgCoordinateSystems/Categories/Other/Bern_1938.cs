using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bern_1938 : IEpsgCoordinateSystem
    {private const int _srid = 4306; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bern 1938";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Bern 1938,DATUM[Bern_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6306]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4306]]";

        public string EsriWkt => "GEOGCS[Bern 1938,DATUM[D_Bern_1938,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}