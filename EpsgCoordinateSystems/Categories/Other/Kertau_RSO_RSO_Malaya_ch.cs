using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Kertau_RSO_RSO_Malaya_ch : IEpsgCoordinateSystem{private const int _srid = 3167; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Kertau (RSO) / RSO Malaya (ch)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Kertau (RSO) / RSO Malaya (ch),GEOGCS[Kertau (RSO),DATUM[Kertau_RSO,SPHEROID[Everest 1830 (RSO 1969),6377295.664,300.8017,AUTHORITY[EPSG,7056]],AUTHORITY[EPSG,6751]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4751]],UNIT[British chain (Sears 1922 truncated),20.116756,AUTHORITY[EPSG,9301]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257905],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,1988.392164223695],PARAMETER[false_northing,0],AUTHORITY[EPSG,3167],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[Kertau (RSO) / RSO Malaya (ch),GEOGCS[Kertau (RSO),DATUM[D_,SPHEROID[Everest_1830_RSO_1969,6377295.664,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257905],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,1988.392164223695],PARAMETER[false_northing,0],UNIT[British chain (Sears 1922 truncated),20.116756]]";}}