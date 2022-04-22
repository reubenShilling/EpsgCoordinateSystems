namespace EpsgCoordinateSystems.Other
{
    public class Unspecified_datum_based_upon_the_Hughes_1980_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unspecified datum based upon the Hughes 1980 ellipsoid";
        public string Units => "Unspecified";
public long Srid => 4054;

        public string OgcWkt =>
            "GEOGCS[Unspecified datum based upon the Hughes 1980 ellipsoid,DATUM[Not_specified_based_on_Hughes_1980_ellipsoid,SPHEROID[Hughes 1980,6378273,298.279411123064,AUTHORITY[EPSG,7058]],AUTHORITY[EPSG,6054]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4054]]";

        public string EsriWkt => "GEOGCS[Unspecified datum based upon the Hughes 1980 ellipsoid,DATUM[D_,SPHEROID[Hughes_1980,6378273,298.279411123064]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}