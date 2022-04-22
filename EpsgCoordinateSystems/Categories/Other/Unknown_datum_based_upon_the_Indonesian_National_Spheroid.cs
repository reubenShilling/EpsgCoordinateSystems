using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Indonesian_National_Spheroid : IEpsgCoordinateSystem
    {private const int _srid = 4021; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the Indonesian National Spheroid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Indonesian National Spheroid,DATUM[Not_specified_based_on_Indonesian_National_Spheroid,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6021]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4021]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Indonesian National Spheroid,DATUM[D_Indonesian,SPHEROID[Indonesian_National_Spheroid,6378160,298.247]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}