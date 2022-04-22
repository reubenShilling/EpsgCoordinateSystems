using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_GEM_10C_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4031; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the GEM 10C ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the GEM 10C ellipsoid,DATUM[Not_specified_based_on_GEM_10C_ellipsoid,SPHEROID[GEM 10C,6378137,298.257223563,AUTHORITY[EPSG,7031]],AUTHORITY[EPSG,6031]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4031]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the GEM 10C ellipsoid,DATUM[D_GEM_10C,SPHEROID[GEM_10C,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}