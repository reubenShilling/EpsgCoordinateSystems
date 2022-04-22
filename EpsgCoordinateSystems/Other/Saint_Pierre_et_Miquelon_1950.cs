namespace EpsgCoordinateSystems.Other
{
    public class Saint_Pierre_et_Miquelon_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Saint Pierre et Miquelon 1950";
        public string Units => "Unspecified";
public long Srid => 4638;

        public string OgcWkt =>
            "GEOGCS[Saint Pierre et Miquelon 1950,DATUM[Saint_Pierre_et_Miquelon_1950,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[30,430,368,0,0,0,0],AUTHORITY[EPSG,6638]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4638]]";

        public string EsriWkt => "GEOGCS[Saint Pierre et Miquelon 1950,DATUM[D_Saint_Pierre_et_Miquelon_1950,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}