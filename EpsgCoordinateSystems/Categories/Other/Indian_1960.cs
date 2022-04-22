using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Indian_1960 : IEpsgCoordinateSystem
    {private const int _srid = 4131; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Indian 1960";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Indian 1960,DATUM[Indian_1960,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6131]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4131]]";

        public string EsriWkt => "GEOGCS[Indian 1960,DATUM[D_Indian_1960,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}