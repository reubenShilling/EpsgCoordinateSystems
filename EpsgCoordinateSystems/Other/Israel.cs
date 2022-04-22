namespace EpsgCoordinateSystems.Other
{
    public class Israel : IEpsgCoordinateSystem
    {
        public string Name => "Israel";
        public string Units => "Unspecified";
public long Srid => 4141;

        public string OgcWkt =>
            "GEOGCS[Israel,DATUM[Israel,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-48,55,52,0,0,0,0],AUTHORITY[EPSG,6141]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4141]]";

        public string EsriWkt => "GEOGCS[Israel,DATUM[D_Israel,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}