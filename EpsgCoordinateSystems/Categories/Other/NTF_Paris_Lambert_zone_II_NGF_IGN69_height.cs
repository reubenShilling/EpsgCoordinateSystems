using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NTF_Paris_Lambert_zone_II_NGF_IGN69_height : IEpsgCoordinateSystem
    {private const int _srid = 7421; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NTF (Paris) / Lambert zone II + NGF IGN69 height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "COMPD_CS[NTF (Paris) / Lambert zone II + NGF IGN69 height,PROJCS[NTF (Paris) / Lambert zone II,GEOGCS[NTF (Paris),DATUM[Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.5969213,AUTHORITY[EPSG,8903]],UNIT[grade,0.015707963267948967],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4807]],PROJECTION[Lambert Conic Conformal (1SP),AUTHORITY[EPSG,9801]],PARAMETER[central_meridian,0.0],PARAMETER[latitude_of_origin,52.0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000.0],PARAMETER[false_northing,2200000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,27572]],VERT_CS[NGF IGN69 height,VERT_DATUM[Nivellement General de la France - IGN69,2005,AUTHORITY[EPSG,5119]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5720]],AUTHORITY[EPSG,7421]]";

        public string EsriWkt => "COMPD_CS[NTF (Paris) / Lambert zone II + NGF IGN69 height,PROJCS[NTF (Paris) / Lambert zone II,GEOGCS[NTF (Paris),DATUM[D_Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Paris,2.5969213],UNIT[grade,0.015707963267948967]],PROJECTION[Lambert Conic Conformal (1SP)],PARAMETER[central_meridian,0.0],PARAMETER[latitude_of_origin,52.0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000.0],PARAMETER[false_northing,2200000.0],UNIT[m,1.0]],VERT_CS[NGF IGN69 height,VERT_DATUM[Nivellement General de la France - IGN69,2005],UNIT[m,1.0]]]";
    }
}