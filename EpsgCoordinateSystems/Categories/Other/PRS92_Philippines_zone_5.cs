namespace EpsgCoordinateSystems.Categories.Other
{
    public class PRS92_Philippines_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "PRS92 / Philippines zone 5";
        public string Units => "Unspecified";
public int Srid => 3125;

        public string OgcWkt =>
            "PROJCS[PRS92 / Philippines zone 5,GEOGCS[PRS92,DATUM[Philippine_Reference_System_1992,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-127.62,-67.24,-47.04,-3.068,4.903,1.578,-1.06],AUTHORITY[EPSG,6683]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4683]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,125],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3125],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[PRS92 / Philippines zone 5,GEOGCS[PRS92,DATUM[D_Phillipine_Reference_System_1992,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,125],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}