using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Katanga_1955_Katanga_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 3314; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Katanga 1955 / Katanga Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Katanga 1955 / Katanga Lambert,GEOGCS[Katanga 1955,DATUM[Katanga_1955,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6695]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4695]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-6.5],PARAMETER[standard_parallel_2,-11.5],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,26],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3314],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Katanga 1955 / Katanga Lambert,GEOGCS[Katanga 1955,DATUM[D_Katanga_1955,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-6.5],PARAMETER[standard_parallel_2,-11.5],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,26],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}