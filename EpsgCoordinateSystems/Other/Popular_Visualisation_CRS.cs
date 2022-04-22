namespace EpsgCoordinateSystems.Other
{
    public class Popular_Visualisation_CRS : IEpsgCoordinateSystem
    {
        public string Name => "Popular Visualisation CRS";
        public string Units => "Unspecified";
public long Srid => 4055;

        public string OgcWkt =>
            "GEOGCS[Popular Visualisation CRS,DATUM[Popular_Visualisation_Datum,SPHEROID[Popular Visualisation Sphere,6378137,0,AUTHORITY[EPSG,7059]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6055]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4055]]";

        public string EsriWkt =>
            "GEOGCS[Popular Visualisation CRS,DATUM[Popular_Visualisation_Datum,SPHEROID[Popular Visualisation Sphere,6378137,0,AUTHORITY[EPSG,7059]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6055]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4055]]";
    }
}