namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Faroe_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Faroe Lambert";
        public string Units => "Unspecified";
public long Srid => 3145;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Faroe Lambert,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[ETRS89 / Faroe Lambert,GEOGCS[ETRS89,DATUM[D_ETRS_1989,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}