namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_84_World_Equidistant_Cylindrical : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / World Equidistant Cylindrical";
        public string Units => "Unspecified";
public int Srid => 32663;

        public string OgcWkt =>
            "PROJCS[WGS 84 / World Equidistant Cylindrical,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[WGS 84 / World Equidistant Cylindrical,GEOGCS[GCS_WGS_1984,DATUM[D_WGS_1984,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}