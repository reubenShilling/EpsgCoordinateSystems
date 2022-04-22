using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1962 : IEpsgCoordinateSystem
    {private const int _srid = 4145; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kalianpur 1962";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]]";

        public string EsriWkt => "GEOGCS[Kalianpur 1962,DATUM[D_Kalianpur_1962,SPHEROID[Everest_1830_1962_Definition,6377301.243,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}