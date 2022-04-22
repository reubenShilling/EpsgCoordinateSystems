using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ID74 : IEpsgCoordinateSystem
    {private const int _srid = 4238; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ID74";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[ID74,DATUM[Indonesian_Datum_1974,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6238]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4238]]";

        public string EsriWkt => "GEOGCS[ID74,DATUM[D_Indonesian_1974,SPHEROID[Indonesian_National_Spheroid,6378160,298.247]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}