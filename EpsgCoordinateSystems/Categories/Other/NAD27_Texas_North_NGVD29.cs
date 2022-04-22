using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD27_Texas_North_NGVD29 : IEpsgCoordinateSystem
    {private const int _srid = 7407; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD27 / Texas North + NGVD29";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "COMPD_CS[NAD27 / Texas North + NGVD29,PROJCS[NAD27 / Texas North,GEOGCS[NAD27,DATUM[North American Datum 1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-4.2,135.4,181.9,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4267]],PROJECTION[Lambert Conic Conformal (2SP),AUTHORITY[EPSG,9802]],PARAMETER[central_meridian,-101.5],PARAMETER[latitude_of_origin,34.0],PARAMETER[standard_parallel_1,34.65],PARAMETER[false_easting,2000000.0],PARAMETER[false_northing,0.0],PARAMETER[standard_parallel_2,36.18333333333333],UNIT[foot_survey_us,0.30480060960121924],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,32037]],VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005,AUTHORITY[EPSG,5102]],UNIT[foot_survey_us,0.30480060960121924],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5702]],AUTHORITY[EPSG,7407]]";

        public string EsriWkt => "COMPD_CS[NAD27 / Texas North + NGVD29,PROJCS[NAD27 / Texas North,GEOGCS[GCS_North_American_1927,DATUM[D_North American Datum 1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert Conic Conformal (2SP)],PARAMETER[central_meridian,-101.5],PARAMETER[latitude_of_origin,34.0],PARAMETER[standard_parallel_1,34.65],PARAMETER[false_easting,2000000.0],PARAMETER[false_northing,0.0],PARAMETER[standard_parallel_2,36.18333333333333],UNIT[Foot_US,0.30480060960121924]],VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005],UNIT[foot_survey_us,0.30480060960121924]]]";
    }
}