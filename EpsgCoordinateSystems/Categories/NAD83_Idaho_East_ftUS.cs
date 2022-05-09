using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Idaho_East_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2241;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Idaho East";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Idaho East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-112.1666666666667],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2241],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Idaho East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-112.1666666666667],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.503257818182, -111.046784),
                    new Vector(43.0198848181819, -111.049214),
                    new Vector(43.2847368181819, -111.047504),
                    new Vector(43.5155238181818, -111.046775),
                    new Vector(43.9825518181819, -111.050411),
                    new Vector(44.4733308181818, -111.051563),
                    new Vector(44.4861288181818, -111.094628),
                    new Vector(44.5007538181819, -111.128918),
                    new Vector(44.5278978181819, -111.134363),
                    new Vector(44.5451778181819, -111.170237),
                    new Vector(44.5648518181819, -111.178769),
                    new Vector(44.5731768181818, -111.219512),
                    new Vector(44.6025618181818, -111.234236),
                    new Vector(44.6179788181818, -111.2198),
                    new Vector(44.6269068181819, -111.223976),
                    new Vector(44.6422068181818, -111.270668),
                    new Vector(44.6737968181819, -111.2702),
                    new Vector(44.6829408181819, -111.29567),
                    new Vector(44.7051888181819, -111.31547),
                    new Vector(44.7278598181819, -111.319223),
                    new Vector(44.7261858181819, -111.349976),
                    new Vector(44.7450948181818, -111.372305),
                    new Vector(44.7376878181818, -111.384968),
                    new Vector(44.7088698181818, -111.395075),
                    new Vector(44.7131808181818, -111.443639),
                    new Vector(44.7021648181819, -111.475427),
                    new Vector(44.6914188181819, -111.4808),
                    new Vector(44.6700258181818, -111.460694),
                    new Vector(44.6525568181818, -111.458264),
                    new Vector(44.6407128181818, -111.470171),
                    new Vector(44.6376888181819, -111.507692),
                    new Vector(44.6159718181818, -111.501743),
                    new Vector(44.5932018181819, -111.514523),
                    new Vector(44.5511898181819, -111.492896),
                    new Vector(44.5499478181818, -111.462836),
                    new Vector(44.5379148181818, -111.459317),
                    new Vector(44.5361418181819, -111.482573),
                    new Vector(44.5286988181819, -111.490241),
                    new Vector(44.5528638181819, -111.567227),
                    new Vector(44.5429908181819, -111.605243),
                    new Vector(44.5507578181819, -111.684866),
                    new Vector(44.5337658181817, -111.716996),
                    new Vector(44.5188258181818, -111.766919),
                    new Vector(44.5184658181818, -111.792605),
                    new Vector(44.5039848181818, -111.807833),
                    new Vector(44.5562658181818, -111.872498),
                    new Vector(44.5497228181819, -111.940394),
                    new Vector(44.5296708181818, -111.977825),
                    new Vector(44.5350438181818, -112.023608),
                    new Vector(44.522848818182, -112.027073),
                    new Vector(44.5286088181819, -112.059365),
                    new Vector(44.5182228181818, -112.099901),
                    new Vector(44.5282578181818, -112.124192),
                    new Vector(44.5314438181819, -112.199657),
                    new Vector(44.5384908181819, -112.217756),
                    new Vector(44.5594878181819, -112.230401),
                    new Vector(44.5599738181818, -112.256672),
                    new Vector(44.5417038181818, -112.282349),
                    new Vector(44.525098818182, -112.342496),
                    new Vector(44.497180818182, -112.34057),
                    new Vector(44.4492738181819, -112.367579),
                    new Vector(44.4492828181819, -112.420751),
                    new Vector(44.4688398181818, -112.458515),
                    new Vector(44.4629988181819, -112.501832),
                    new Vector(44.4774978181818, -112.539326),
                    new Vector(44.4808008181819, -112.653194),
                    new Vector(44.4969378181819, -112.71434),
                    new Vector(44.4843198181819, -112.733708),
                    new Vector(44.4739158181819, -112.77986),
                    new Vector(44.4580128181818, -112.796231),
                    new Vector(44.421085818182, -112.826687),
                    new Vector(44.3948148181818, -112.818713),
                    new Vector(44.3956608181819, -112.802018),
                    new Vector(44.2199808181818, -112.801379),
                    new Vector(44.2283238181818, -112.982819),
                    new Vector(43.9692948181819, -112.982828),
                    new Vector(43.9671708181818, -112.683407),
                    new Vector(43.6137408181818, -112.678502),
                    new Vector(43.6150008181818, -112.689176),
                    new Vector(43.5297798181819, -112.688861),
                    new Vector(43.5253248181818, -112.80479),
                    new Vector(43.4388168181818, -112.806284),
                    new Vector(43.4384478181818, -112.924967),
                    new Vector(43.3577988181819, -112.924076),
                    new Vector(43.3563588181818, -112.936127),
                    new Vector(43.2767088181818, -112.937693),
                    new Vector(43.2762948181818, -112.998155),
                    new Vector(43.1038098181818, -113.000648),
                    new Vector(43.1057898181818, -113.236637),
                    new Vector(42.7596948181817, -113.22797),
                    new Vector(42.7581378181819, -113.174339),
                    new Vector(42.6613158181818, -113.177183),
                    new Vector(42.6619278181818, -113.229563),
                    new Vector(42.6146418181818, -113.230265),
                    new Vector(42.6186738181818, -113.211968),
                    new Vector(42.6103308181818, -113.175626),
                    new Vector(42.5884878181819, -113.17559),
                    new Vector(42.5849148181819, -112.996292),
                    new Vector(42.3243108181819, -112.99577),
                    new Vector(42.0011478181819, -112.989569),
                    new Vector(41.9990508181818, -112.147106),
                    new Vector(42.0022998181818, -112.100513),
                    new Vector(42.0001758181818, -111.494579),
                    new Vector(41.9961978181819, -111.048701),
                    new Vector(42.503257818182, -111.046784)
                })
            }
        };
    }
}