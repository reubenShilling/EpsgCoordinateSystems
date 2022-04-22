namespace EpsgCoordinateSystems.Other
{
    public class NSWC_9Z_2 : IEpsgCoordinateSystem
    {
        public string Name => "NSWC 9Z-2";
        public string Units => "Unspecified";
public long Srid => 4276;

        public string OgcWkt =>
            "GEOGCS[NSWC 9Z-2,DATUM[NSWC_9Z_2,SPHEROID[NWL 9D,6378145,298.25,AUTHORITY[EPSG,7025]],AUTHORITY[EPSG,6276]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4276]]";

        public string EsriWkt => "GEOGCS[NSWC 9Z-2,DATUM[D_NSWC_9Z_2,SPHEROID[NWL_9D,6378145,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}