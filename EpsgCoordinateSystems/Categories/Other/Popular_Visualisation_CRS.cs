using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Popular_Visualisation_CRS : IEpsgCoordinateSystem
    {private const int _srid = 4055; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Popular Visualisation CRS";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Popular Visualisation CRS,DATUM[Popular_Visualisation_Datum,SPHEROID[Popular Visualisation Sphere,6378137,0,AUTHORITY[EPSG,7059]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6055]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4055]]";

        public string EsriWkt => "GEOGCS[Popular Visualisation CRS,DATUM[D_Popular_Visualisation_Datum,SPHEROID[Popular_Visualisation_Sphere,6378137,0]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}