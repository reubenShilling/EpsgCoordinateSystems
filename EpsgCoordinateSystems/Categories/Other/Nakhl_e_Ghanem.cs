namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nakhl_e_Ghanem : IEpsgCoordinateSystem
    {
        public string Name => "Nakhl-e Ghanem";
        public string Units => "Unspecified";
public int Srid => 4693;

        public string OgcWkt =>
            "GEOGCS[Nakhl-e Ghanem,DATUM[Nakhl_e_Ghanem,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,-0.15,0.68,0,0,0,0],AUTHORITY[EPSG,6693]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4693]]";

        public string EsriWkt => "GEOGCS[Nakhl-e Ghanem,DATUM[D_Nakhl-e_Ghanem,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}