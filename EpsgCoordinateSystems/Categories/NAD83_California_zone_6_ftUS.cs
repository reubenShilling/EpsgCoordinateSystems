using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_6_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2230;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "California zone 6";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / California zone 6 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,33.88333333333333],PARAMETER[standard_parallel_2,32.78333333333333],PARAMETER[latitude_of_origin,32.16666666666666],PARAMETER[central_meridian,-116.25],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2230],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / California zone 6 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,33.88333333333333],PARAMETER[standard_parallel_2,32.78333333333333],PARAMETER[latitude_of_origin,32.16666666666666],PARAMETER[central_meridian,-116.25],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(32.7208518181819, -114.722042),
                    new Vector(32.7350088181819, -114.712691),
                    new Vector(32.7414258181819, -114.694034),
                    new Vector(32.7262788181819, -114.603944),
                    new Vector(32.7358818181818, -114.60353),
                    new Vector(32.7374388181819, -114.571958),
                    new Vector(32.7488238181818, -114.57221),
                    new Vector(32.748940818182, -114.560753),
                    new Vector(32.7607578181818, -114.561581),
                    new Vector(32.7607488181818, -114.542996),
                    new Vector(32.7712338181819, -114.543185),
                    new Vector(32.7714048181819, -114.53009),
                    new Vector(32.7880458181819, -114.535076),
                    new Vector(32.8099068181818, -114.52622),
                    new Vector(32.8454208181818, -114.461447),
                    new Vector(32.9359068181818, -114.476441),
                    new Vector(32.9777928181819, -114.468395),
                    new Vector(33.0277068181819, -114.520622),
                    new Vector(33.0367788181818, -114.559079),
                    new Vector(33.0269958181818, -114.609929),
                    new Vector(33.0335658181819, -114.633968),
                    new Vector(33.0444108181818, -114.645164),
                    new Vector(33.0389208181817, -114.663956),
                    new Vector(33.0953778181819, -114.711359),
                    new Vector(33.1223688181819, -114.70946),
                    new Vector(33.1672518181819, -114.678122),
                    new Vector(33.2245908181819, -114.680057),
                    new Vector(33.2392518181819, -114.687707),
                    new Vector(33.2680158181818, -114.67769),
                    new Vector(33.3057078181819, -114.735416),
                    new Vector(33.3524178181819, -114.703601),
                    new Vector(33.4110618181819, -114.724931),
                    new Vector(33.4191168181818, -114.645092),
                    new Vector(33.4394298181819, -114.630575),
                    new Vector(33.4685988181818, -114.621089),
                    new Vector(33.4861308181818, -114.598085),
                    new Vector(33.5094498181818, -114.58706),
                    new Vector(33.5600748181819, -114.529415),
                    new Vector(33.5805048181819, -114.540242),
                    new Vector(33.6221388181818, -114.527174),
                    new Vector(33.6655008181819, -114.525275),
                    new Vector(33.6827358181819, -114.536426),
                    new Vector(33.7083768181819, -114.495674),
                    new Vector(33.743197818182, -114.51029),
                    new Vector(33.7717188181819, -114.504557),
                    new Vector(33.8260248181819, -114.521117),
                    new Vector(33.8419638181819, -114.511721),
                    new Vector(33.8629248181818, -114.520964),
                    new Vector(33.9250338181819, -114.498194),
                    new Vector(33.9524118181818, -114.525635),
                    new Vector(33.9650658181818, -114.51821),
                    new Vector(34.0298478181819, -114.428984),
                    new Vector(34.0783398181819, -114.424025),
                    new Vector(34.0779258181819, -115.312091),
                    new Vector(34.0406568181818, -115.312343),
                    new Vector(34.0333938181818, -115.973249),
                    new Vector(34.0347528181819, -116.924918),
                    new Vector(34.0056558181818, -116.924405),
                    new Vector(34.0072938181818, -117.22361),
                    new Vector(34.0182018181818, -117.223079),
                    new Vector(34.0205418181818, -117.371606),
                    new Vector(34.0346358181819, -117.372785),
                    new Vector(34.0334478181819, -117.554594),
                    new Vector(33.9920838181819, -117.554846),
                    new Vector(33.9731928181819, -117.605651),
                    new Vector(33.9286248181818, -117.608081),
                    new Vector(33.9265638181818, -117.653468),
                    new Vector(33.9056388181819, -117.655493),
                    new Vector(33.9041268181819, -117.680936),
                    new Vector(33.880960818182, -117.677408),
                    new Vector(33.9507648181819, -117.78323),
                    new Vector(33.9447978181819, -117.970295),
                    new Vector(33.9138738181819, -117.971573),
                    new Vector(33.8982678181819, -117.990185),
                    new Vector(33.8832378181819, -117.99221),
                    new Vector(33.8807898181819, -118.012649),
                    new Vector(33.8627898181819, -118.042286),
                    new Vector(33.8102928181819, -118.065353),
                    new Vector(33.7941378181818, -118.091642),
                    new Vector(33.7623498181819, -118.087889),
                    new Vector(33.7475628181818, -118.106717),
                    new Vector(33.3945378181819, -117.597326),
                    new Vector(33.2340948181819, -117.410144),
                    new Vector(33.1114788181819, -117.328433),
                    new Vector(32.8881708181819, -117.254876),
                    new Vector(32.8512168181819, -117.285314),
                    new Vector(32.6800908181819, -117.248207),
                    new Vector(32.7389328181819, -117.19877),
                    new Vector(32.6789298181819, -117.12452),
                    new Vector(32.6028708181819, -117.120605),
                    new Vector(32.7184488181818, -117.199796),
                    new Vector(32.5357848181819, -117.128111),
                    new Vector(32.6194758181817, -116.106962),
                    new Vector(32.7208518181819, -114.722042)
                })
            }
        };
    }
}