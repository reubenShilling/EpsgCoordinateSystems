using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Texas_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2275;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Texas North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Texas North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.18333333333333],PARAMETER[standard_parallel_2,34.65],PARAMETER[latitude_of_origin,34],PARAMETER[central_meridian,-101.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,3280833.333],AUTHORITY[EPSG,2275],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Texas North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.18333333333333],PARAMETER[standard_parallel_2,34.65],PARAMETER[latitude_of_origin,34],PARAMETER[central_meridian,-101.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,3280833.333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-100.947191, 34.3159308181819, 0),
                    new Vector(-100.519385, 34.3140768181819, 0),
                    new Vector(-100.420925, 34.3153818181819, 0),
                    new Vector(-99.998159, 34.3125108181819, 0),
                    new Vector(-99.996476, 34.5623778181818, 0),
                    new Vector(-99.99926600000001, 34.7472468181819, 0),
                    new Vector(-99.996458, 35.0310528181819, 0),
                    new Vector(-99.997574, 35.1822348181819, 0),
                    new Vector(-99.994748, 35.4246138181819, 0),
                    new Vector(-100.000391, 35.618851818182, 0),
                    new Vector(-99.99812300000002, 35.8838388181819, 0),
                    new Vector(-99.997556, 36.0575928181819, 0),
                    new Vector(-100.001543, 36.4925538181819, 0),
                    new Vector(-100.007276, 36.4939128181819, 0),
                    new Vector(-100.549841, 36.4894848181818, 0),
                    new Vector(-100.957343, 36.4896378181819, 0),
                    new Vector(-101.090102, 36.4880538181819, 0),
                    new Vector(-101.62076, 36.4920228181819, 0),
                    new Vector(-102.034652, 36.4929858181818, 0),
                    new Vector(-102.165674, 36.4902408181819, 0),
                    new Vector(-102.9974, 36.4923738181818, 0),
                    new Vector(-103.027289, 36.4915908181818, 0),
                    new Vector(-103.024049, 36.0560628181818, 0),
                    new Vector(-103.022609, 35.7423228181818, 0),
                    new Vector(-103.022294, 35.6236488181818, 0),
                    new Vector(-103.026155, 35.1772668181819, 0),
                    new Vector(-103.025255, 34.9647858181819, 0),
                    new Vector(-103.022663, 34.7453388181819, 0),
                    new Vector(-103.029638, 34.3078218181818, 0),
                    new Vector(-102.609968, 34.3082448181818, 0),
                    new Vector(-102.522074, 34.3088208181819, 0),
                    new Vector(-102.086402, 34.3083528181819, 0),
                    new Vector(-101.992991, 34.3104498181818, 0),
                    new Vector(-101.561801, 34.3088478181818, 0),
                    new Vector(-101.468912, 34.3096038181819, 0),
                    new Vector(-101.048396, 34.3123308181819, 0),
                    new Vector(-100.947191, 34.3159308181819, 0)
                })
            }
        };
    }
}