using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDM2000 : IEpsgCoordinateSystem
    {private const int _srid = 4921; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "GDM2000";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[GDM2000,DATUM[Geodetic Datum of Malaysia 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4921]]";

        public string EsriWkt => "GEOGCS[GDM2000,DATUM[D_Geodetic Datum of Malaysia 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}