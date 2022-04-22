namespace EpsgCoordinateSystems.Other
{
    public class Hong_Kong_1980_Grid_System : IEpsgCoordinateSystem
    {
        public string Name => "Hong Kong 1980 Grid System";
        public string Units => "Unspecified";
public long Srid => 2326;

        public string OgcWkt =>
            "PROJCS[Hong Kong 1980 Grid System,GEOGCS[Hong Kong 1980,DATUM[Hong_Kong_1980,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-162.619,-276.959,-161.764,0.067753,-2.24365,-1.15883,-1.09425],AUTHORITY[EPSG,6611]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4611]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,22.31213333333334],PARAMETER[central_meridian,114.1785555555556],PARAMETER[scale_factor,1],PARAMETER[false_easting,836694.05],PARAMETER[false_northing,819069.8],AUTHORITY[EPSG,2326],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Hong Kong 1980 Grid System,GEOGCS[Hong Kong 1980,DATUM[D_Hong_Kong_1980,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,22.31213333333334],PARAMETER[central_meridian,114.1785555555556],PARAMETER[scale_factor,1],PARAMETER[false_easting,836694.05],PARAMETER[false_northing,819069.8],UNIT[Meter,1]]";
    }
}