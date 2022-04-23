using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_6_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2230;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "California zone 6";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / California zone 6 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,33.88333333333333],PARAMETER[standard_parallel_2,32.78333333333333],PARAMETER[latitude_of_origin,32.16666666666666],PARAMETER[central_meridian,-116.25],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2230],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / California zone 6 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,33.88333333333333],PARAMETER[standard_parallel_2,32.78333333333333],PARAMETER[latitude_of_origin,32.16666666666666],PARAMETER[central_meridian,-116.25],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-114.722042, 32.7208518181819, 0),
                    new Vector(-114.712691, 32.7350088181819, 0),
                    new Vector(-114.694034, 32.7414258181819, 0),
                    new Vector(-114.603944, 32.7262788181819, 0),
                    new Vector(-114.60353, 32.7358818181818, 0),
                    new Vector(-114.571958, 32.7374388181819, 0),
                    new Vector(-114.57221, 32.7488238181818, 0),
                    new Vector(-114.560753, 32.748940818182, 0),
                    new Vector(-114.561581, 32.7607578181818, 0),
                    new Vector(-114.542996, 32.7607488181818, 0),
                    new Vector(-114.543185, 32.7712338181819, 0),
                    new Vector(-114.53009, 32.7714048181819, 0),
                    new Vector(-114.535076, 32.7880458181819, 0),
                    new Vector(-114.52622, 32.8099068181818, 0),
                    new Vector(-114.461447, 32.8454208181818, 0),
                    new Vector(-114.476441, 32.9359068181818, 0),
                    new Vector(-114.468395, 32.9777928181819, 0),
                    new Vector(-114.520622, 33.0277068181819, 0),
                    new Vector(-114.559079, 33.0367788181818, 0),
                    new Vector(-114.609929, 33.0269958181818, 0),
                    new Vector(-114.633968, 33.0335658181819, 0),
                    new Vector(-114.645164, 33.0444108181818, 0),
                    new Vector(-114.663956, 33.0389208181817, 0),
                    new Vector(-114.711359, 33.0953778181819, 0),
                    new Vector(-114.70946, 33.1223688181819, 0),
                    new Vector(-114.678122, 33.1672518181819, 0),
                    new Vector(-114.680057, 33.2245908181819, 0),
                    new Vector(-114.687707, 33.2392518181819, 0),
                    new Vector(-114.67769, 33.2680158181818, 0),
                    new Vector(-114.735416, 33.3057078181819, 0),
                    new Vector(-114.703601, 33.3524178181819, 0),
                    new Vector(-114.724931, 33.4110618181819, 0),
                    new Vector(-114.645092, 33.4191168181818, 0),
                    new Vector(-114.630575, 33.4394298181819, 0),
                    new Vector(-114.621089, 33.4685988181818, 0),
                    new Vector(-114.598085, 33.4861308181818, 0),
                    new Vector(-114.58706, 33.5094498181818, 0),
                    new Vector(-114.529415, 33.5600748181819, 0),
                    new Vector(-114.540242, 33.5805048181819, 0),
                    new Vector(-114.527174, 33.6221388181818, 0),
                    new Vector(-114.525275, 33.6655008181819, 0),
                    new Vector(-114.536426, 33.6827358181819, 0),
                    new Vector(-114.495674, 33.7083768181819, 0),
                    new Vector(-114.51029, 33.743197818182, 0),
                    new Vector(-114.504557, 33.7717188181819, 0),
                    new Vector(-114.521117, 33.8260248181819, 0),
                    new Vector(-114.511721, 33.8419638181819, 0),
                    new Vector(-114.520964, 33.8629248181818, 0),
                    new Vector(-114.498194, 33.9250338181819, 0),
                    new Vector(-114.525635, 33.9524118181818, 0),
                    new Vector(-114.51821, 33.9650658181818, 0),
                    new Vector(-114.428984, 34.0298478181819, 0),
                    new Vector(-114.424025, 34.0783398181819, 0),
                    new Vector(-115.312091, 34.0779258181819, 0),
                    new Vector(-115.312343, 34.0406568181818, 0),
                    new Vector(-115.973249, 34.0333938181818, 0),
                    new Vector(-116.924918, 34.0347528181819, 0),
                    new Vector(-116.924405, 34.0056558181818, 0),
                    new Vector(-117.22361, 34.0072938181818, 0),
                    new Vector(-117.223079, 34.0182018181818, 0),
                    new Vector(-117.371606, 34.0205418181818, 0),
                    new Vector(-117.372785, 34.0346358181819, 0),
                    new Vector(-117.554594, 34.0334478181819, 0),
                    new Vector(-117.554846, 33.9920838181819, 0),
                    new Vector(-117.605651, 33.9731928181819, 0),
                    new Vector(-117.608081, 33.9286248181818, 0),
                    new Vector(-117.653468, 33.9265638181818, 0),
                    new Vector(-117.655493, 33.9056388181819, 0),
                    new Vector(-117.680936, 33.9041268181819, 0),
                    new Vector(-117.677408, 33.880960818182, 0),
                    new Vector(-117.78323, 33.9507648181819, 0),
                    new Vector(-117.970295, 33.9447978181819, 0),
                    new Vector(-117.971573, 33.9138738181819, 0),
                    new Vector(-117.990185, 33.8982678181819, 0),
                    new Vector(-117.99221, 33.8832378181819, 0),
                    new Vector(-118.012649, 33.8807898181819, 0),
                    new Vector(-118.042286, 33.8627898181819, 0),
                    new Vector(-118.065353, 33.8102928181819, 0),
                    new Vector(-118.091642, 33.7941378181818, 0),
                    new Vector(-118.087889, 33.7623498181819, 0),
                    new Vector(-118.106717, 33.7475628181818, 0),
                    new Vector(-117.597326, 33.3945378181819, 0),
                    new Vector(-117.410144, 33.2340948181819, 0),
                    new Vector(-117.328433, 33.1114788181819, 0),
                    new Vector(-117.254876, 32.8881708181819, 0),
                    new Vector(-117.285314, 32.8512168181819, 0),
                    new Vector(-117.248207, 32.6800908181819, 0),
                    new Vector(-117.19877, 32.7389328181819, 0),
                    new Vector(-117.12452, 32.6789298181819, 0),
                    new Vector(-117.120605, 32.6028708181819, 0),
                    new Vector(-117.199796, 32.7184488181818, 0),
                    new Vector(-117.128111, 32.5357848181819, 0),
                    new Vector(-116.106962, 32.6194758181817, 0),
                    new Vector(-114.722042, 32.7208518181819, 0)
                })
            }
        };
    }
}