namespace EpsgCoordinateSystems.Categories.Other
{
    public class Saint_Pierre_et_Miquelon_1950_UTM_zone_21N : IEpsgCoordinateSystem
    {
        public string Name => "Saint Pierre et Miquelon 1950 / UTM zone 21N";
        public string Units => "Unspecified";
public int Srid => 2987;

        public string OgcWkt =>
            "PROJCS[Saint Pierre et Miquelon 1950 / UTM zone 21N,GEOGCS[Saint Pierre et Miquelon 1950,DATUM[Saint_Pierre_et_Miquelon_1950,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[30,430,368,0,0,0,0],AUTHORITY[EPSG,6638]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4638]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2987],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Saint Pierre et Miquelon 1950 / UTM zone 21N,GEOGCS[Saint Pierre et Miquelon 1950,DATUM[D_Saint_Pierre_et_Miquelon_1950,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}