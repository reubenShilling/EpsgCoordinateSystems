using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class MGI : IEpsgCoordinateSystem
    {private const int _srid = 4312; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "MGI";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]]";

        public string EsriWkt => "GEOGCS[MGI,DATUM[D_MGI,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}