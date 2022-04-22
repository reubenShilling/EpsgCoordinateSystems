namespace EpsgCoordinateSystems.Other
{
    public class DVR90 : IEpsgCoordinateSystem
    {
        public string Name => "DVR90";
        public string Units => "Unspecified";
public long Srid => 5799;

        public string OgcWkt =>
            "VERT_CS[DVR90,VERT_DATUM[Dansk Vertikal Reference 1990,2005,AUTHORITY[EPSG,5206]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5799]]";

        public string EsriWkt => "VERT_CS[DVR90,VERT_DATUM[Dansk Vertikal Reference 1990,2005],UNIT[m,1.0]]";
    }
}