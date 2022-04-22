namespace EpsgCoordinateSystems.Other
{
    public class Rassadiran_Nakhl_e_Taqi : IEpsgCoordinateSystem
    {
        public string Name => "Rassadiran / Nakhl e Taqi";
        public string Units => "Unspecified";
public long Srid => 2057;

        public string OgcWkt =>
            "PROJCS[Rassadiran / Nakhl e Taqi,GEOGCS[Rassadiran,DATUM[Rassadiran,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133.63,-157.5,-158.62,0,0,0,0],AUTHORITY[EPSG,6153]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4153]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,27.51882880555555],PARAMETER[longitude_of_center,52.60353916666667],PARAMETER[azimuth,0.5716611944444444],PARAMETER[rectified_grid_angle,0.5716611944444444],PARAMETER[scale_factor,0.999895934],PARAMETER[false_easting,658377.437],PARAMETER[false_northing,3044969.194],AUTHORITY[EPSG,2057],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Rassadiran / Nakhl e Taqi,GEOGCS[Rassadiran,DATUM[D_Rassadiran,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,27.51882880555555],PARAMETER[longitude_of_center,52.60353916666667],PARAMETER[azimuth,0.5716611944444444],PARAMETER[rectified_grid_angle,0.5716611944444444],PARAMETER[scale_factor,0.999895934],PARAMETER[false_easting,658377.437],PARAMETER[false_northing,3044969.194],UNIT[Meter,1]]";
    }
}