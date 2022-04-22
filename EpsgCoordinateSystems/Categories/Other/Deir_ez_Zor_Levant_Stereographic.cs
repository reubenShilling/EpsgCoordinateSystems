using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Deir_ez_Zor_Levant_Stereographic : IEpsgCoordinateSystem
    {private const int _srid = 22780; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Deir ez Zor / Levant Stereographic";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Deir ez Zor / Levant Stereographic,GEOGCS[Deir ez Zor,DATUM[Deir_ez_Zor,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6227]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4227]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,34.2],PARAMETER[central_meridian,39.15],PARAMETER[scale_factor,0.9995341],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,22780],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Deir ez Zor / Levant Stereographic,GEOGCS[Deir ez Zor,DATUM[D_Deir_ez_Zor,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,34.2],PARAMETER[central_meridian,39.15],PARAMETER[scale_factor,0.9995341],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}