using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class St_Lawrence_Island : IEpsgCoordinateSystem
    {private const int _srid = 4136; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "St. Lawrence Island";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[St. Lawrence Island,DATUM[St_Lawrence_Island,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6136]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4136]]";

        public string EsriWkt => "GEOGCS[St. Lawrence Island,DATUM[D_St_Lawrence_Island,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}