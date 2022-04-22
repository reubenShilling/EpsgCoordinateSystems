using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bermuda_1957 : IEpsgCoordinateSystem
    {private const int _srid = 4216; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bermuda 1957";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Bermuda 1957,DATUM[Bermuda_1957,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6216]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4216]]";

        public string EsriWkt => "GEOGCS[Bermuda 1957,DATUM[D_Bermuda_1957,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}