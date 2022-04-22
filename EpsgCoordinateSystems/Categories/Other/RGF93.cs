namespace EpsgCoordinateSystems.Categories.Other
{
    public class RGF93 : IEpsgCoordinateSystem
    {
        public string Name => "RGF93";
        public string Units => "Unspecified";
public int Srid => 4965;

        public string OgcWkt =>
            "GEOGCS[RGF93,DATUM[Reseau Geodesique Francais 1993,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4965]]";

        public string EsriWkt => "GEOGCS[RGF93,DATUM[D_Reseau Geodesique Francais 1993,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}