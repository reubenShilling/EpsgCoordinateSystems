using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_Mexico_West_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2259;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Mexico West";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Mexico West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-107.8333333333333],PARAMETER[scale_factor,0.999916667],PARAMETER[false_easting,2723091.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2259],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Mexico West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-107.8333333333333],PARAMETER[scale_factor,0.999916667],PARAMETER[false_easting,2723091.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-106.328012, 33.3920358181818, 0),
                    new Vector(-106.360997, 33.3923418181819, 0),
                    new Vector(-106.362518, 33.4783818181818, 0),
                    new Vector(-107.701223, 33.4790118181818, 0),
                    new Vector(-107.70422, 33.8315148181819, 0),
                    new Vector(-107.71304, 33.8329818181818, 0),
                    new Vector(-107.711384, 34.2684468181818, 0),
                    new Vector(-107.720825, 34.2690048181819, 0),
                    new Vector(-107.718404, 34.5843108181818, 0),
                    new Vector(-107.195423, 34.5835728181819, 0),
                    new Vector(-107.195486, 34.6109328181819, 0),
                    new Vector(-107.204333, 34.6135248181819, 0),
                    new Vector(-107.217932, 34.963723818182, 0),
                    new Vector(-107.054312, 34.9634718181819, 0),
                    new Vector(-107.18078, 35.2252728181818, 0),
                    new Vector(-107.228309, 35.3117988181819, 0),
                    new Vector(-107.294801, 35.3123298181818, 0),
                    new Vector(-107.302055, 36.0018108181818, 0),
                    new Vector(-107.62448, 36.0032418181819, 0),
                    new Vector(-107.623364, 36.2209878181818, 0),
                    new Vector(-107.625182, 36.8110728181819, 0),
                    new Vector(-107.607263, 36.8158518181819, 0),
                    new Vector(-107.592998, 36.8406288181819, 0),
                    new Vector(-107.453615, 36.9064908181819, 0),
                    new Vector(-107.441447, 36.9661788181818, 0),
                    new Vector(-107.41082, 36.9975258181818, 0),
                    new Vector(-107.47247, 36.9987768181817, 0),
                    new Vector(-108.37247, 36.9994698181819, 0),
                    new Vector(-109.048478, 36.9966438181818, 0),
                    new Vector(-109.047857, 35.9966628181818, 0),
                    new Vector(-109.046642, 34.9546428181818, 0),
                    new Vector(-109.048658, 34.5917808181819, 0),
                    new Vector(-109.050341, 33.7833018181819, 0),
                    new Vector(-109.050521, 33.2051598181819, 0),
                    new Vector(-109.051349, 32.7795588181818, 0),
                    new Vector(-109.049495, 32.4420498181818, 0),
                    new Vector(-109.045616, 31.3434558181819, 0),
                    new Vector(-108.210641, 31.3438518181818, 0),
                    new Vector(-108.203252, 31.7869038181819, 0),
                    new Vector(-107.28356, 31.7850858181818, 0),
                    new Vector(-107.286503, 32.6072358181819, 0),
                    new Vector(-107.285477, 32.7812148181819, 0),
                    new Vector(-106.878227, 32.7893868181818, 0),
                    new Vector(-106.878803, 32.8294818181819, 0),
                    new Vector(-106.323386, 33.0596118181819, 0),
                    new Vector(-106.328012, 33.3920358181818, 0)
                })
            }
        };
    }
}