namespace EpsgCoordinateSystems.Categories.Other
{
    public class JGD2000_Japan_Plane_Rectangular_CS_XVI : IEpsgCoordinateSystem
    {
        public string Name => "JGD2000 / Japan Plane Rectangular CS XVI";
        public string Units => "Unspecified";
public int Srid => 2458;

        public string OgcWkt =>
            "PROJCS[JGD2000 / Japan Plane Rectangular CS XVI,GEOGCS[JGD2000,DATUM[Japanese_Geodetic_Datum_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6612]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4612]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,124],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2458],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[JGD2000 / Japan Plane Rectangular CS XVI,GEOGCS[JGD2000,DATUM[D_JGD_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,124],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}