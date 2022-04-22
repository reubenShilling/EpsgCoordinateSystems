using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class AGD66 : IEpsgCoordinateSystem
    {private const int _srid = 4202; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "AGD66";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[AGD66,DATUM[Australian_Geodetic_Datum_1966,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6202]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4202]]";

        public string EsriWkt => "GEOGCS[AGD66,DATUM[D_Australian_1966,SPHEROID[Australian_National_Spheroid,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}