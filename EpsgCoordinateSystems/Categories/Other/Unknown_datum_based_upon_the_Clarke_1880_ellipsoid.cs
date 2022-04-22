using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4034; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the Clarke 1880 ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_ellipsoid,SPHEROID[Clarke 1880,6378249.144808011,293.4663076556303,AUTHORITY[EPSG,7034]],AUTHORITY[EPSG,6034]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4034]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Clarke 1880 ellipsoid,DATUM[D_Clarke_1880,SPHEROID[Clarke_1880,6378249.144808011,293.4663076556303]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}