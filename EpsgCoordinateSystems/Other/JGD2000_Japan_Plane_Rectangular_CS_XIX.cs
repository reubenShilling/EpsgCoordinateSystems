namespace EpsgCoordinateSystems.Other
{
    public class JGD2000_Japan_Plane_Rectangular_CS_XIX : IEpsgCoordinateSystem
    {
        public string Name => "JGD2000 / Japan Plane Rectangular CS XIX";
        public string Units => "Unspecified";
public long Srid => 2461;

        public string OgcWkt =>
            "PROJCS[JGD2000 / Japan Plane Rectangular CS XIX,GEOGCS[JGD2000,DATUM[Japanese_Geodetic_Datum_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6612]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4612]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,154],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2461],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[JGD2000 / Japan Plane Rectangular CS XIX,GEOGCS[JGD2000,DATUM[Japanese_Geodetic_Datum_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6612]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4612]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,154],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2461],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}