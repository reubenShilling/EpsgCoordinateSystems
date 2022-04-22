using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Grand_Cayman_1959 : IEpsgCoordinateSystem
    {private const int _srid = 4723; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Grand Cayman 1959";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Grand Cayman 1959,DATUM[Grand_Cayman_1959,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[67.8,106.1,138.8,0,0,0,0],AUTHORITY[EPSG,6723]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4723]]";

        public string EsriWkt => "GEOGCS[Grand Cayman 1959,DATUM[D_Grand_Cayman_1959,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}