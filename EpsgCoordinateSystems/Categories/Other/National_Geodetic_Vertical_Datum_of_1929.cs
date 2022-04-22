using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class National_Geodetic_Vertical_Datum_of_1929 : IEpsgCoordinateSystem
    {private const int _srid = 5702; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "National Geodetic Vertical Datum of 1929";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005,AUTHORITY[EPSG,5102]],UNIT[foot_survey_us,0.30480060960121924],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5702]]";

        public string EsriWkt => "VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005],UNIT[foot_survey_us,0.30480060960121924]]";
    }
}