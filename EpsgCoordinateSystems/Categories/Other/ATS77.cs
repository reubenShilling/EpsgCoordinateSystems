using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ATS77 : IEpsgCoordinateSystem
    {private const int _srid = 4122; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ATS77";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]]";

        public string EsriWkt => "GEOGCS[ATS77,DATUM[D_ATS_1977,SPHEROID[Average_Terrestrial_System_1977,6378135,298.257]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}