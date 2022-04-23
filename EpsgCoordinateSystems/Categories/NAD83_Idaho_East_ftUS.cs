using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Idaho_East_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2241;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Idaho East";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Idaho East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-112.1666666666667],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2241],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Idaho East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-112.1666666666667],PARAMETER[scale_factor,0.999947368],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-111.046784, 42.503257818182, 0),
                    new Vector(-111.049214, 43.0198848181819, 0),
                    new Vector(-111.047504, 43.2847368181819, 0),
                    new Vector(-111.046775, 43.5155238181818, 0),
                    new Vector(-111.050411, 43.9825518181819, 0),
                    new Vector(-111.051563, 44.4733308181818, 0),
                    new Vector(-111.094628, 44.4861288181818, 0),
                    new Vector(-111.128918, 44.5007538181819, 0),
                    new Vector(-111.134363, 44.5278978181819, 0),
                    new Vector(-111.170237, 44.5451778181819, 0),
                    new Vector(-111.178769, 44.5648518181819, 0),
                    new Vector(-111.219512, 44.5731768181818, 0),
                    new Vector(-111.234236, 44.6025618181818, 0),
                    new Vector(-111.2198, 44.6179788181818, 0),
                    new Vector(-111.223976, 44.6269068181819, 0),
                    new Vector(-111.270668, 44.6422068181818, 0),
                    new Vector(-111.2702, 44.6737968181819, 0),
                    new Vector(-111.29567, 44.6829408181819, 0),
                    new Vector(-111.31547, 44.7051888181819, 0),
                    new Vector(-111.319223, 44.7278598181819, 0),
                    new Vector(-111.349976, 44.7261858181819, 0),
                    new Vector(-111.372305, 44.7450948181818, 0),
                    new Vector(-111.384968, 44.7376878181818, 0),
                    new Vector(-111.395075, 44.7088698181818, 0),
                    new Vector(-111.443639, 44.7131808181818, 0),
                    new Vector(-111.475427, 44.7021648181819, 0),
                    new Vector(-111.4808, 44.6914188181819, 0),
                    new Vector(-111.460694, 44.6700258181818, 0),
                    new Vector(-111.458264, 44.6525568181818, 0),
                    new Vector(-111.470171, 44.6407128181818, 0),
                    new Vector(-111.507692, 44.6376888181819, 0),
                    new Vector(-111.501743, 44.6159718181818, 0),
                    new Vector(-111.514523, 44.5932018181819, 0),
                    new Vector(-111.492896, 44.5511898181819, 0),
                    new Vector(-111.462836, 44.5499478181818, 0),
                    new Vector(-111.459317, 44.5379148181818, 0),
                    new Vector(-111.482573, 44.5361418181819, 0),
                    new Vector(-111.490241, 44.5286988181819, 0),
                    new Vector(-111.567227, 44.5528638181819, 0),
                    new Vector(-111.605243, 44.5429908181819, 0),
                    new Vector(-111.684866, 44.5507578181819, 0),
                    new Vector(-111.716996, 44.5337658181817, 0),
                    new Vector(-111.766919, 44.5188258181818, 0),
                    new Vector(-111.792605, 44.5184658181818, 0),
                    new Vector(-111.807833, 44.5039848181818, 0),
                    new Vector(-111.872498, 44.5562658181818, 0),
                    new Vector(-111.940394, 44.5497228181819, 0),
                    new Vector(-111.977825, 44.5296708181818, 0),
                    new Vector(-112.023608, 44.5350438181818, 0),
                    new Vector(-112.027073, 44.522848818182, 0),
                    new Vector(-112.059365, 44.5286088181819, 0),
                    new Vector(-112.099901, 44.5182228181818, 0),
                    new Vector(-112.124192, 44.5282578181818, 0),
                    new Vector(-112.199657, 44.5314438181819, 0),
                    new Vector(-112.217756, 44.5384908181819, 0),
                    new Vector(-112.230401, 44.5594878181819, 0),
                    new Vector(-112.256672, 44.5599738181818, 0),
                    new Vector(-112.282349, 44.5417038181818, 0),
                    new Vector(-112.342496, 44.525098818182, 0),
                    new Vector(-112.34057, 44.497180818182, 0),
                    new Vector(-112.367579, 44.4492738181819, 0),
                    new Vector(-112.420751, 44.4492828181819, 0),
                    new Vector(-112.458515, 44.4688398181818, 0),
                    new Vector(-112.501832, 44.4629988181819, 0),
                    new Vector(-112.539326, 44.4774978181818, 0),
                    new Vector(-112.653194, 44.4808008181819, 0),
                    new Vector(-112.71434, 44.4969378181819, 0),
                    new Vector(-112.733708, 44.4843198181819, 0),
                    new Vector(-112.77986, 44.4739158181819, 0),
                    new Vector(-112.796231, 44.4580128181818, 0),
                    new Vector(-112.826687, 44.421085818182, 0),
                    new Vector(-112.818713, 44.3948148181818, 0),
                    new Vector(-112.802018, 44.3956608181819, 0),
                    new Vector(-112.801379, 44.2199808181818, 0),
                    new Vector(-112.982819, 44.2283238181818, 0),
                    new Vector(-112.982828, 43.9692948181819, 0),
                    new Vector(-112.683407, 43.9671708181818, 0),
                    new Vector(-112.678502, 43.6137408181818, 0),
                    new Vector(-112.689176, 43.6150008181818, 0),
                    new Vector(-112.688861, 43.5297798181819, 0),
                    new Vector(-112.80479, 43.5253248181818, 0),
                    new Vector(-112.806284, 43.4388168181818, 0),
                    new Vector(-112.924967, 43.4384478181818, 0),
                    new Vector(-112.924076, 43.3577988181819, 0),
                    new Vector(-112.936127, 43.3563588181818, 0),
                    new Vector(-112.937693, 43.2767088181818, 0),
                    new Vector(-112.998155, 43.2762948181818, 0),
                    new Vector(-113.000648, 43.1038098181818, 0),
                    new Vector(-113.236637, 43.1057898181818, 0),
                    new Vector(-113.22797, 42.7596948181817, 0),
                    new Vector(-113.174339, 42.7581378181819, 0),
                    new Vector(-113.177183, 42.6613158181818, 0),
                    new Vector(-113.229563, 42.6619278181818, 0),
                    new Vector(-113.230265, 42.6146418181818, 0),
                    new Vector(-113.211968, 42.6186738181818, 0),
                    new Vector(-113.175626, 42.6103308181818, 0),
                    new Vector(-113.17559, 42.5884878181819, 0),
                    new Vector(-112.996292, 42.5849148181819, 0),
                    new Vector(-112.99577, 42.3243108181819, 0),
                    new Vector(-112.989569, 42.0011478181819, 0),
                    new Vector(-112.147106, 41.9990508181818, 0),
                    new Vector(-112.100513, 42.0022998181818, 0),
                    new Vector(-111.494579, 42.0001758181818, 0),
                    new Vector(-111.048701, 41.9961978181819, 0),
                    new Vector(-111.046784, 42.503257818182, 0)
                })
            }
        };
    }
}