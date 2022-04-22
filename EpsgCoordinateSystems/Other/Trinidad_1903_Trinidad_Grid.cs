namespace EpsgCoordinateSystems.Other
{
    public class Trinidad_1903_Trinidad_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Trinidad 1903 / Trinidad Grid";
        public string Units => "Unspecified";
public long Srid => 30200;

        public string OgcWkt =>
            "PROJCS[Trinidad 1903 / Trinidad Grid,GEOGCS[Trinidad 1903,DATUM[Trinidad_1903,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6302]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4302]],UNIT[Clarke's link,0.201166195164,AUTHORITY[EPSG,9039]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,10.44166666666667],PARAMETER[central_meridian,-61.33333333333334],PARAMETER[false_easting,430000],PARAMETER[false_northing,325000],AUTHORITY[EPSG,30200],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Trinidad 1903 / Trinidad Grid,GEOGCS[Trinidad 1903,DATUM[D_Trinidad_1903,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,10.44166666666667],PARAMETER[central_meridian,-61.33333333333334],PARAMETER[false_easting,430000],PARAMETER[false_northing,325000],UNIT[Clarke's link,0.201166195164]]";
    }
}