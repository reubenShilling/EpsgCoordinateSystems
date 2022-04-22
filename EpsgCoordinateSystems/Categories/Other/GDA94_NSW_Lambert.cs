using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDA94_NSW_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 3308; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "GDA94 / NSW Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[GDA94 / NSW Lambert,GEOGCS[GDA94,DATUM[Geocentric_Datum_of_Australia_1994,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4283]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-30.75],PARAMETER[standard_parallel_2,-35.75],PARAMETER[latitude_of_origin,-33.25],PARAMETER[central_meridian,147],PARAMETER[false_easting,9300000],PARAMETER[false_northing,4500000],AUTHORITY[EPSG,3308],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDA94 / NSW Lambert,GEOGCS[GDA94,DATUM[D_GDA_1994,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-30.75],PARAMETER[standard_parallel_2,-35.75],PARAMETER[latitude_of_origin,-33.25],PARAMETER[central_meridian,147],PARAMETER[false_easting,9300000],PARAMETER[false_northing,4500000],UNIT[Meter,1]]";
    }
}