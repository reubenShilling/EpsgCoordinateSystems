using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_OSU86F_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4032; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the OSU86F ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the OSU86F ellipsoid,DATUM[Not_specified_based_on_OSU86F_ellipsoid,SPHEROID[OSU86F,6378136.2,298.257223563,AUTHORITY[EPSG,7032]],AUTHORITY[EPSG,6032]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4032]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the OSU86F ellipsoid,DATUM[D_OSU_86F,SPHEROID[OSU86F,6378136.2,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}