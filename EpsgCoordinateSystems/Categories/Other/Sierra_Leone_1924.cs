using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Sierra_Leone_1924 : IEpsgCoordinateSystem
    {private const int _srid = 4174; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Sierra Leone 1924";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Sierra Leone 1924,DATUM[Sierra_Leone_Colony_1924,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],AUTHORITY[EPSG,6174]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4174]]";

        public string EsriWkt => "GEOGCS[Sierra Leone 1924,DATUM[D_Sierra_Leone_1924,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}