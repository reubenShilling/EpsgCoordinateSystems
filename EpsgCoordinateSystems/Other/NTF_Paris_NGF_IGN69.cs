namespace EpsgCoordinateSystems.Other
{
    public class NTF_Paris_NGF_IGN69 : IEpsgCoordinateSystem
    {
        public string Name => "NTF (Paris) + NGF IGN69";
        public string Units => "Unspecified";
public long Srid => 7400;

        public string OgcWkt =>
            "COMPD_CS[NTF (Paris) + NGF IGN69,GEOGCS[NTF (Paris),DATUM[Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.5969213,AUTHORITY[EPSG,8903]],UNIT[grade,0.015707963267948967],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4807]],VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005,AUTHORITY[EPSG,5119]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5720]],AUTHORITY[EPSG,7400]]";

        public string EsriWkt => "COMPD_CS[NTF (Paris) + NGF IGN69,GEOGCS[NTF (Paris),DATUM[D_Nouvelle Triangulation Francaise (Paris),SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Paris,2.5969213],UNIT[grade,0.015707963267948967]],VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005],UNIT[m,1.0]]]";
    }
}