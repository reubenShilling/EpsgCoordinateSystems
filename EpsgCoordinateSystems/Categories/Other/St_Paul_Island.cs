using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class St_Paul_Island : IEpsgCoordinateSystem
    {private const int _srid = 4137; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "St. Paul Island";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[St. Paul Island,DATUM[St_Paul_Island,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6137]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4137]]";

        public string EsriWkt => "GEOGCS[St. Paul Island,DATUM[D_St_Paul_Island,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}