namespace EpsgCoordinateSystems.Other
{
    public class TM75_Irish_Grid : IEpsgCoordinateSystem
    {
        public string Name => "TM75 / Irish Grid";
        public string Units => "Unspecified";
public long Srid => 29903;

        public string OgcWkt =>
            "PROJCS[TM75 / Irish Grid,GEOGCS[TM75,DATUM[Geodetic_Datum_of_1965,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6300]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4300]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1.000035],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,29903],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[TM75 / Irish Grid,GEOGCS[TM75,DATUM[D_TM75,SPHEROID[Airy_Modified_1849,6377340.189,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1.000035],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],UNIT[Meter,1]]";
    }
}