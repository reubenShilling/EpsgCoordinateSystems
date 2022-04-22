using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ST87_Ouvea : IEpsgCoordinateSystem
    {private const int _srid = 4750; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ST87 Ouvea";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[ST87 Ouvea,DATUM[ST87_Ouvea,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-56.263,16.136,-22.856,0,0,0,0],AUTHORITY[EPSG,6750]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4750]]";

        public string EsriWkt => "GEOGCS[ST87 Ouvea,DATUM[D_ST87_Ouvea,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}