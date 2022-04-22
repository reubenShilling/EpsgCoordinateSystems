namespace EpsgCoordinateSystems.Other
{
    public class HD72_EOV : IEpsgCoordinateSystem
    {
        public string Name => "HD72 / EOV";
        public string Units => "Unspecified";
public long Srid => 23700;

        public string OgcWkt =>
            "PROJCS[HD72 / EOV,GEOGCS[HD72,DATUM[Hungarian_Datum_1972,SPHEROID[GRS 1967,6378160,298.247167427,AUTHORITY[EPSG,7036]],AUTHORITY[EPSG,6237]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4237]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,47.14439372222222],PARAMETER[longitude_of_center,19.04857177777778],PARAMETER[azimuth,90],PARAMETER[rectified_grid_angle,90],PARAMETER[scale_factor,0.99993],PARAMETER[false_easting,650000],PARAMETER[false_northing,200000],AUTHORITY[EPSG,23700],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[HD72 / EOV,GEOGCS[HD72,DATUM[D_Hungarian_1972,SPHEROID[GRS_1967,6378160,298.247167427]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Center],PARAMETER[latitude_of_center,47.14439372222222],PARAMETER[longitude_of_center,19.04857177777778],PARAMETER[azimuth,90],PARAMETER[scale_factor,0.99993],PARAMETER[false_easting,650000],PARAMETER[false_northing,200000],UNIT[Meter,1]]";
    }
}