namespace EpsgCoordinateSystems.Other
{
    public class Popular_Visualisation_CRS_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "Popular Visualisation CRS / Mercator";
        public string Units => "Unspecified";
public long Srid => 3785;

        public string OgcWkt =>
            "PROJCS[Popular Visualisation CRS / Mercator,GEOGCS[Popular Visualisation CRS,DATUM[Popular_Visualisation_Datum,SPHEROID[Popular Visualisation Sphere,6378137,0,AUTHORITY[EPSG,7059]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6055]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4055]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,0],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3785],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Popular Visualisation CRS / Mercator,GEOGCS[Popular Visualisation CRS,DATUM[Popular_Visualisation_Datum,SPHEROID[Popular Visualisation Sphere,6378137,0,AUTHORITY[EPSG,7059]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6055]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4055]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,0],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3785],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}