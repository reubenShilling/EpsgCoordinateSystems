namespace EpsgCoordinateSystems.Categories.Other{public class ATS77_New_Brunswick_Stereographic_ATS77 : IEpsgCoordinateSystem{public string Name => "ATS77 / New Brunswick Stereographic (ATS77)";public string Units => "Unspecified";
public int Srid => 2200;public string OgcWkt => "PROJCS[ATS77 / New Brunswick Stereographic (ATS77),GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,-66.5],PARAMETER[scale_factor,0.999912],PARAMETER[false_easting,300000],PARAMETER[false_northing,800000],AUTHORITY[EPSG,2200],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[ATS77 / New Brunswick Stereographic (ATS77),GEOGCS[ATS77,DATUM[D_ATS_1977,SPHEROID[Average_Terrestrial_System_1977,6378135,298.257]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,46.5],PARAMETER[central_meridian,-66.5],PARAMETER[scale_factor,0.999912],PARAMETER[false_easting,300000],PARAMETER[false_northing,800000],UNIT[Meter,1]]";}}