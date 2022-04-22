namespace EpsgCoordinateSystems.Other
{
    public class Hon_Dau_1992 : IEpsgCoordinateSystem
    {
        public string Name => "Hon Dau 1992";
        public string Units => "Unspecified";
public long Srid => 5727;

        public string OgcWkt =>
            "VERT_CS[Hon Dau 1992,VERT_DATUM[Hon Dau 1992,2005,AUTHORITY[EPSG,5126]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5727]]";

        public string EsriWkt => "VERT_CS[Hon Dau 1992,VERT_DATUM[Hon Dau 1992,2005],UNIT[m,1.0]]";
    }
}