using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Australian_Antarctic : IEpsgCoordinateSystem
    {private const int _srid = 4931; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Australian Antarctic";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Australian Antarctic,DATUM[Australian Antarctic Datum 1998,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6176]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4931]]";

        public string EsriWkt => "GEOGCS[Australian Antarctic,DATUM[D_Australian Antarctic Datum 1998,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}