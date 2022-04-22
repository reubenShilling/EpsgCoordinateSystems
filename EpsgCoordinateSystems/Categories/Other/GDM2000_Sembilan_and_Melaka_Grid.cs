using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDM2000_Sembilan_and_Melaka_Grid : IEpsgCoordinateSystem
    {private const int _srid = 3378; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "GDM2000 / Sembilan and Melaka Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[GDM2000 / Sembilan and Melaka Grid,GEOGCS[GDM2000,DATUM[Geodetic_Datum_of_Malaysia_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4742]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,2.682347636111111],PARAMETER[central_meridian,101.9749050416667],PARAMETER[false_easting,3673.785],PARAMETER[false_northing,-4240.573],AUTHORITY[EPSG,3378],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDM2000 / Sembilan and Melaka Grid,GEOGCS[GDM2000,DATUM[D_GDM_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,2.682347636111111],PARAMETER[central_meridian,101.9749050416667],PARAMETER[false_easting,3673.785],PARAMETER[false_northing,-4240.573],UNIT[Meter,1]]";
    }
}