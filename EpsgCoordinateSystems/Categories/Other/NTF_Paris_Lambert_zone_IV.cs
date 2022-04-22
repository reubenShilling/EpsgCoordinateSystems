using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NTF_Paris_Lambert_zone_IV : IEpsgCoordinateSystem
    {private const int _srid = 27574; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NTF (Paris) / Lambert zone IV";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NTF (Paris) / Lambert zone IV,GEOGCS[NTF (Paris),DATUM[Nouvelle_Triangulation_Francaise_Paris,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168,-60,320,0,0,0,0],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4807]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,46.85],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.99994471],PARAMETER[false_easting,234.358],PARAMETER[false_northing,4185861.369],AUTHORITY[EPSG,27574],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NTF (Paris) / Lambert zone IV,GEOGCS[NTF (Paris),DATUM[D_NTF,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Paris,2.33722917],UNIT[grad,0.01570796326794897]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,46.85],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.99994471],PARAMETER[false_easting,234.358],PARAMETER[false_northing,4185861.369],UNIT[Meter,1]]";
    }
}