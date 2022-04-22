namespace EpsgCoordinateSystems.Other
{
    public class NTF_Paris_France_II_NGF_Lallemand : IEpsgCoordinateSystem
    {
        public string Name => "NTF (Paris) / France II + NGF Lallemand";
        public string Units => "Unspecified";
public long Srid => 7401;

        public string OgcWkt =>
            "COMPD_CS[NTF (Paris) / France II + NGF Lallemand,PROJCS[NTF (Paris) / France II,GEOGCS[NTF (Paris),DATUM[Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.5969213,AUTHORITY[EPSG,8903]],UNIT[grade,0.015707963267948967],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4807]],PROJECTION[Lambert Conic Conformal (1SP),AUTHORITY[EPSG,9801]],PARAMETER[central_meridian,0.0],PARAMETER[latitude_of_origin,52.0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000.0],PARAMETER[false_northing,2200000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,27582]],VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005,AUTHORITY[EPSG,5118]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5719]],AUTHORITY[EPSG,7401]]";

        public string EsriWkt =>
            "COMPD_CS[NTF (Paris) / France II + NGF Lallemand,PROJCS[NTF (Paris) / France II,GEOGCS[NTF (Paris),DATUM[Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.5969213,AUTHORITY[EPSG,8903]],UNIT[grade,0.015707963267948967],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4807]],PROJECTION[Lambert Conic Conformal (1SP),AUTHORITY[EPSG,9801]],PARAMETER[central_meridian,0.0],PARAMETER[latitude_of_origin,52.0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000.0],PARAMETER[false_northing,2200000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,27582]],VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005,AUTHORITY[EPSG,5118]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5719]],AUTHORITY[EPSG,7401]]";
    }
}