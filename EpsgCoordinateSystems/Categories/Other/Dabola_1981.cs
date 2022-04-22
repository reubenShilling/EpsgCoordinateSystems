using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dabola_1981 : IEpsgCoordinateSystem
    {private const int _srid = 4155; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Dabola 1981";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Dabola 1981,DATUM[Dabola_1981,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-83,37,124,0,0,0,0],AUTHORITY[EPSG,6155]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4155]]";

        public string EsriWkt => "GEOGCS[Dabola 1981,DATUM[D_Dabola_1981,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}