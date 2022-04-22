using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Kertau_R_S_O_Malaya_ch_deprecated : IEpsgCoordinateSystem{private const int _srid = 24571; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Kertau / R.S.O. Malaya (ch) (deprecated)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Kertau / R.S.O. Malaya (ch) (deprecated),GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]],UNIT[British chain (Benoit 1895 B),20.11678249437587,AUTHORITY[EPSG,9062]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257905],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,40000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24571],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[Kertau / R.S.O. Malaya (ch) (deprecated),GEOGCS[Kertau 1968,DATUM[D_Kertau,SPHEROID[Everest_1830_Modified,6377304.063,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257905],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,40000],PARAMETER[false_northing,0],UNIT[British chain (Benoit 1895 B),20.11678249437587]]";}}