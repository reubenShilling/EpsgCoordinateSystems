using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RGFG95 : IEpsgCoordinateSystem
    {private const int _srid = 4967; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RGFG95";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[RGFG95,DATUM[Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2.0,2.0,-2.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4967]]";

        public string EsriWkt => "GEOGCS[RGFG95,DATUM[D_Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}