using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Plessis_1817_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4027; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the Plessis 1817 ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Plessis 1817 ellipsoid,DATUM[Not_specified_based_on_Plessis_1817_ellipsoid,SPHEROID[Plessis 1817,6376523,308.64,AUTHORITY[EPSG,7027]],AUTHORITY[EPSG,6027]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4027]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Plessis 1817 ellipsoid,DATUM[D_Plessis_1817,SPHEROID[Plessis_1817,6376523,308.64]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}