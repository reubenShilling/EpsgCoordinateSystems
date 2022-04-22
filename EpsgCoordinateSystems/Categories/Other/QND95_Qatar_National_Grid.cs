namespace EpsgCoordinateSystems.Categories.Other
{
    public class QND95_Qatar_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "QND95 / Qatar National Grid";
        public string Units => "Unspecified";
public int Srid => 2932;

        public string OgcWkt =>
            "PROJCS[QND95 / Qatar National Grid,GEOGCS[QND95,DATUM[Qatar_National_Datum_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-119.425,-303.659,-11.0006,1.1643,0.174458,1.09626,3.65706],AUTHORITY[EPSG,6614]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4614]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.45],PARAMETER[central_meridian,51.21666666666667],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,2932],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[QND95 / Qatar National Grid,GEOGCS[QND95,DATUM[D_QND_1995,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.45],PARAMETER[central_meridian,51.21666666666667],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}