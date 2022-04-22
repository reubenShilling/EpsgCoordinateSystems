using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moznet : IEpsgCoordinateSystem
    {private const int _srid = 4953; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Moznet";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Moznet,DATUM[Moznet (ITRF94),SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,-0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6130]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4953]]";

        public string EsriWkt => "GEOGCS[Moznet,DATUM[D_Moznet (ITRF94),SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}