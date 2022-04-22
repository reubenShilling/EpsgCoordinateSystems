using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class SIRGAS_2000 : IEpsgCoordinateSystem
    {private const int _srid = 4989; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "SIRGAS 2000";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[SIRGAS 2000,DATUM[Sistema de Referencia Geocentrico para America del Sur 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6674]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4989]]";

        public string EsriWkt => "GEOGCS[SIRGAS 2000,DATUM[D_Sistema de Referencia Geocentrico para America del Sur 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}