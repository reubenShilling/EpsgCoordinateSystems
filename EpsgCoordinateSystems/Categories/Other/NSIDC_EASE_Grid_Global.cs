using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NSIDC_EASE_Grid_Global : IEpsgCoordinateSystem
    {private const int _srid = 3410; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NSIDC EASE-Grid Global";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NSIDC EASE-Grid Global,GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cylindrical_Equal_Area],PARAMETER[standard_parallel_1,30],PARAMETER[central_meridian,0],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3410],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NSIDC EASE-Grid Global,GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[D_,SPHEROID[International_1924_Authalic_Sphere,6371228,0]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cylindrical_Equal_Area],PARAMETER[standard_parallel_1,30],PARAMETER[central_meridian,0],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}