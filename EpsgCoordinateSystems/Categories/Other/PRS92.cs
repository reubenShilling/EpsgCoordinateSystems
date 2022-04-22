using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class PRS92 : IEpsgCoordinateSystem
    {private const int _srid = 4995; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "PRS92";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[PRS92,DATUM[Philippine Reference System 1992,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-127.62,-67.24,-47.04,-3.068,-4.903,-1.578,-0.21864069462192215],AUTHORITY[EPSG,6683]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4995]]";

        public string EsriWkt => "GEOGCS[PRS92,DATUM[D_Philippine Reference System 1992,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}