using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Luzon_1911 : IEpsgCoordinateSystem
    {private const int _srid = 4253; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Luzon 1911";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Luzon 1911,DATUM[Luzon_1911,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6253]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4253]]";

        public string EsriWkt => "GEOGCS[Luzon 1911,DATUM[D_Luzon_1911,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}