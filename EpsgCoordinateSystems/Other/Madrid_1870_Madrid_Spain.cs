namespace EpsgCoordinateSystems.Other
{
    public class Madrid_1870_Madrid_Spain : IEpsgCoordinateSystem
    {
        public string Name => "Madrid 1870 (Madrid) / Spain";
        public string Units => "Unspecified";
public long Srid => 2062;

        public string OgcWkt =>
            "PROJCS[Madrid 1870 (Madrid) / Spain,GEOGCS[Madrid 1870 (Madrid),DATUM[Madrid_1870_Madrid,SPHEROID[Struve 1860,6378298.3,294.73,AUTHORITY[EPSG,7028]],AUTHORITY[EPSG,6903]],PRIMEM[Madrid,-3.687938888888889,AUTHORITY[EPSG,8905]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4903]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.9988085293],PARAMETER[false_easting,600000],PARAMETER[false_northing,600000],AUTHORITY[EPSG,2062],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Madrid 1870 (Madrid) / Spain,GEOGCS[Madrid 1870 (Madrid),DATUM[D_Madrid_1870,SPHEROID[Struve_1860,6378298.3,294.73]],PRIMEM[Madrid,-3.687938888888889],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.9988085293],PARAMETER[false_easting,600000],PARAMETER[false_northing,600000],UNIT[Meter,1]]";
    }
}