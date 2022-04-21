namespace EpsgCoordinateSystems.Other
{
    public class Egypt_Gulf_of_Suez_S_650_TL : IEpsgCoordinateSystem
    {
        public string Name => "Egypt Gulf of Suez S-650 TL";
        public long Srid => 4706;

        public string OgcWkt =>
            "GEOGCS[Egypt Gulf of Suez S-650 TL,DATUM[Egypt_Gulf_of_Suez_S_650_TL,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],TOWGS84[-146.21,112.63,4.05,0,0,0,0],AUTHORITY[EPSG,6706]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4706]]";

        public string EsriWkt =>
            "GEOGCS[Egypt Gulf of Suez S-650 TL,DATUM[Egypt_Gulf_of_Suez_S_650_TL,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],TOWGS84[-146.21,112.63,4.05,0,0,0,0],AUTHORITY[EPSG,6706]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4706]]";
    }
}