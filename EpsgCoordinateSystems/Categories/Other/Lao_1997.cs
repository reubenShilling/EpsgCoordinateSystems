using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lao_1997 : IEpsgCoordinateSystem
    {private const int _srid = 4993; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Lao 1997";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Lao 1997,DATUM[Lao National Datum 1997,SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[44.585,-131.212,-39.544,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6678]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4993]]";

        public string EsriWkt => "GEOGCS[Lao 1997,DATUM[D_Lao National Datum 1997,SPHEROID[Krassowsky_1940,6378245.0,298.3]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}