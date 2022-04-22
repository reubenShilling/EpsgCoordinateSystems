using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IKBD_92 : IEpsgCoordinateSystem
    {private const int _srid = 4667; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IKBD-92";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IKBD-92,DATUM[Iraq_Kuwait_Boundary_Datum_1992,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6667]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4667]]";

        public string EsriWkt => "GEOGCS[IKBD-92,DATUM[D_Iraq_Kuwait_Boundary_1992,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}