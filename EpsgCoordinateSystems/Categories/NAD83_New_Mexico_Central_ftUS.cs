using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_Mexico_Central_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2258;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Mexico Central";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Mexico Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-106.25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2258],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Mexico Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-106.25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-106.328012, 33.3920358181818, 0),
                    new Vector(-106.323386, 33.0596118181819, 0),
                    new Vector(-106.878803, 32.8294818181819, 0),
                    new Vector(-106.878227, 32.7893868181818, 0),
                    new Vector(-107.285477, 32.7812148181819, 0),
                    new Vector(-107.286503, 32.6072358181819, 0),
                    new Vector(-107.28356, 31.7850858181818, 0),
                    new Vector(-106.539521, 31.7863098181818, 0),
                    new Vector(-106.614986, 31.8178368181819, 0),
                    new Vector(-106.616129, 31.84473781818181, 0),
                    new Vector(-106.644083, 31.8952098181819, 0),
                    new Vector(-106.633742, 31.9141008181819, 0),
                    new Vector(-106.632608, 31.9722138181819, 0),
                    new Vector(-106.650068, 31.9803228181819, 0),
                    new Vector(-106.623626, 32.0010948181818, 0),
                    new Vector(-106.378394, 32.0007438181819, 0),
                    new Vector(-106.003238, 32.0016528181818, 0),
                    new Vector(-104.922311, 32.0043798181818, 0),
                    new Vector(-104.851076, 32.0032638181818, 0),
                    new Vector(-104.84024, 32.2534188181818, 0),
                    new Vector(-104.848898, 32.2537338181818, 0),
                    new Vector(-104.842481, 32.5230588181818, 0),
                    new Vector(-105.346292, 32.5253718181819, 0),
                    new Vector(-105.342548, 32.9618178181818, 0),
                    new Vector(-105.3059, 32.9615568181819, 0),
                    new Vector(-105.30482, 33.1368858181819, 0),
                    new Vector(-104.893907, 33.1397298181819, 0),
                    new Vector(-104.894699, 33.3037278181819, 0),
                    new Vector(-104.871641, 33.3028998181819, 0),
                    new Vector(-104.88146, 33.4621728181818, 0),
                    new Vector(-104.880578, 33.8149188181819, 0),
                    new Vector(-104.891036, 33.8157468181818, 0),
                    new Vector(-104.884628, 34.0948908181817, 0),
                    new Vector(-104.880542, 34.3503828181819, 0),
                    new Vector(-105.29996, 34.3503828181819, 0),
                    new Vector(-105.301778, 34.6159458181818, 0),
                    new Vector(-105.277748, 34.6160898181819, 0),
                    new Vector(-105.27764, 35.0473698181818, 0),
                    new Vector(-105.705266, 35.0474238181818, 0),
                    new Vector(-105.703979, 35.2999368181819, 0),
                    new Vector(-105.710198, 35.2996578181819, 0),
                    new Vector(-105.706355, 35.6641938181819, 0),
                    new Vector(-105.698912, 35.6662638181819, 0),
                    new Vector(-105.713105, 35.8882038181819, 0),
                    new Vector(-105.711053, 35.9748468181819, 0),
                    new Vector(-105.648656, 35.9708328181818, 0),
                    new Vector(-105.627569, 35.9974728181819, 0),
                    new Vector(-105.557252, 35.9800398181819, 0),
                    new Vector(-105.541025, 35.9863758181819, 0),
                    new Vector(-105.504107, 36.0220608181818, 0),
                    new Vector(-105.473228, 36.0497538181818, 0),
                    new Vector(-105.431864, 36.0694008181819, 0),
                    new Vector(-105.420578, 36.103564818182, 0),
                    new Vector(-105.385118, 36.141994818182, 0),
                    new Vector(-105.39014, 36.1920708181819, 0),
                    new Vector(-105.409985, 36.2067498181818, 0),
                    new Vector(-105.417473, 36.2292048181818, 0),
                    new Vector(-105.344699, 36.2705778181818, 0),
                    new Vector(-105.312029, 36.2963538181818, 0),
                    new Vector(-105.31328, 36.4230288181818, 0),
                    new Vector(-105.337436, 36.4555368181819, 0),
                    new Vector(-105.309617, 36.497341818182, 0),
                    new Vector(-105.350999, 36.5535288181818, 0),
                    new Vector(-105.338804, 36.5803848181819, 0),
                    new Vector(-105.358046, 36.6213528181819, 0),
                    new Vector(-105.338507, 36.6452748181818, 0),
                    new Vector(-105.354869, 36.6866118181819, 0),
                    new Vector(-105.337463, 36.7019658181818, 0),
                    new Vector(-105.306755, 36.7073748181819, 0),
                    new Vector(-105.290132, 36.7300098181819, 0),
                    new Vector(-105.257822, 36.7326378181819, 0),
                    new Vector(-105.231398, 36.7209198181819, 0),
                    new Vector(-105.199115, 36.7457688181818, 0),
                    new Vector(-105.214991, 36.7843878181818, 0),
                    new Vector(-105.204236, 36.8262558181819, 0),
                    new Vector(-105.217304, 36.8525268181819, 0),
                    new Vector(-105.184265, 36.902305818182, 0),
                    new Vector(-105.21698, 36.9614178181819, 0),
                    new Vector(-105.213092, 36.9926028181818, 0),
                    new Vector(-105.713465, 36.9945648181818, 0),
                    new Vector(-105.991988, 36.9922878181819, 0),
                    new Vector(-106.472174, 36.9914958181819, 0),
                    new Vector(-106.861244, 36.9894978181819, 0),
                    new Vector(-106.890377, 36.9990828181819, 0),
                    new Vector(-107.41082, 36.9975258181818, 0),
                    new Vector(-107.441447, 36.9661788181818, 0),
                    new Vector(-107.453615, 36.9064908181819, 0),
                    new Vector(-107.592998, 36.8406288181819, 0),
                    new Vector(-107.607263, 36.8158518181819, 0),
                    new Vector(-107.625182, 36.8110728181819, 0),
                    new Vector(-107.623364, 36.2209878181818, 0),
                    new Vector(-107.62448, 36.0032418181819, 0),
                    new Vector(-107.302055, 36.0018108181818, 0),
                    new Vector(-107.294801, 35.3123298181818, 0),
                    new Vector(-107.228309, 35.3117988181819, 0),
                    new Vector(-107.18078, 35.2252728181818, 0),
                    new Vector(-107.054312, 34.9634718181819, 0),
                    new Vector(-107.217932, 34.963723818182, 0),
                    new Vector(-107.204333, 34.6135248181819, 0),
                    new Vector(-107.195486, 34.6109328181819, 0),
                    new Vector(-107.195423, 34.5835728181819, 0),
                    new Vector(-107.718404, 34.5843108181818, 0),
                    new Vector(-107.720825, 34.2690048181819, 0),
                    new Vector(-107.711384, 34.2684468181818, 0),
                    new Vector(-107.71304, 33.8329818181818, 0),
                    new Vector(-107.70422, 33.8315148181819, 0),
                    new Vector(-107.701223, 33.4790118181818, 0),
                    new Vector(-106.362518, 33.4783818181818, 0),
                    new Vector(-106.360997, 33.3923418181819, 0),
                    new Vector(-106.328012, 33.3920358181818, 0)
                })
            }
        };
    }
}