using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Manoca_1962 : IEpsgCoordinateSystem
    {private const int _srid = 4193; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Manoca 1962";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Manoca 1962,DATUM[Manoca_1962,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6193]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4193]]";

        public string EsriWkt => "GEOGCS[Manoca 1962,DATUM[D_Manoca_1962,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}