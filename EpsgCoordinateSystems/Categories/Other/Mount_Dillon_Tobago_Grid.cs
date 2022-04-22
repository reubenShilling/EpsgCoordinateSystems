using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mount_Dillon_Tobago_Grid : IEpsgCoordinateSystem
    {private const int _srid = 2066; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mount Dillon / Tobago Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Mount Dillon / Tobago Grid,GEOGCS[Mount Dillon,DATUM[Mount_Dillon,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6157]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4157]],UNIT[Clarke's link,0.201166195164,AUTHORITY[EPSG,9039]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,11.25217861111111],PARAMETER[central_meridian,-60.68600888888889],PARAMETER[false_easting,187500],PARAMETER[false_northing,180000],AUTHORITY[EPSG,2066],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Mount Dillon / Tobago Grid,GEOGCS[Mount Dillon,DATUM[D_Mount_Dillon,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,11.25217861111111],PARAMETER[central_meridian,-60.68600888888889],PARAMETER[false_easting,187500],PARAMETER[false_northing,180000],UNIT[Clarke's link,0.201166195164]]";
    }
}