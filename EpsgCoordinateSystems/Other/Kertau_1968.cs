namespace EpsgCoordinateSystems.Other
{
    public class Kertau_1968 : IEpsgCoordinateSystem
    {
        public string Name => "Kertau 1968";
        public string Units => "Unspecified";
public long Srid => 4245;

        public string OgcWkt =>
            "GEOGCS[Kertau 1968,DATUM[Kertau_1968,SPHEROID[Everest 1830 Modified,6377304.063,300.8017,AUTHORITY[EPSG,7018]],TOWGS84[-11,851,5,0,0,0,0],AUTHORITY[EPSG,6245]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4245]]";

        public string EsriWkt => "GEOGCS[Kertau 1968,DATUM[D_Kertau,SPHEROID[Everest_1830_Modified,6377304.063,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}