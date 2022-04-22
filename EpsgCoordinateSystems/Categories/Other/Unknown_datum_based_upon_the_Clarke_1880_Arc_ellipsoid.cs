using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Clarke_1880_Arc_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4013; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the Clarke 1880 (Arc) ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Clarke 1880 (Arc) ellipsoid,DATUM[Not_specified_based_on_Clarke_1880_Arc_ellipsoid,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],AUTHORITY[EPSG,6013]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4013]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Clarke 1880 (Arc) ellipsoid,DATUM[D_Clarke_1880_Arc,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}