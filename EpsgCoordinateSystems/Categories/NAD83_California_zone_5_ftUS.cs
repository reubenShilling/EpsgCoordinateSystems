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
    internal class NAD83_California_zone_5_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2229;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "California zone 5";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / California zone 5 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2229],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / California zone 5 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(34.0783398181819, -114.424025),
                    new Vector(34.1026578181819, -114.410165),
                    new Vector(34.1413038181819, -114.322793),
                    new Vector(34.1712288181818, -114.285362),
                    new Vector(34.186213818182, -114.235772),
                    new Vector(34.2669798181819, -114.149912),
                    new Vector(34.2726138181819, -114.125225),
                    new Vector(34.3145448181819, -114.134126),
                    new Vector(34.3364418181818, -114.153422),
                    new Vector(34.3652058181819, -114.182078),
                    new Vector(34.4054898181819, -114.257849),
                    new Vector(34.4120688181818, -114.283391),
                    new Vector(34.4357568181819, -114.302867),
                    new Vector(34.4548728181819, -114.332639),
                    new Vector(34.4596788181818, -114.376505),
                    new Vector(34.4770848181819, -114.383867),
                    new Vector(34.5365658181818, -114.376829),
                    new Vector(34.5837258181819, -114.409742),
                    new Vector(34.5989628181818, -114.434303),
                    new Vector(34.6108878181819, -114.42227),
                    new Vector(34.7098698181818, -114.465632),
                    new Vector(34.7447538181819, -114.497798),
                    new Vector(34.7489118181819, -114.525554),
                    new Vector(34.7599548181819, -114.542033),
                    new Vector(34.8318648181819, -114.570221),
                    new Vector(34.8755328181819, -114.627254),
                    new Vector(34.9194978181818, -114.630476),
                    new Vector(34.9436088181819, -114.621008),
                    new Vector(34.9976538181818, -114.632276),
                    new Vector(34.9989138181818, -114.621071),
                    new Vector(35.7957018181818, -115.6262),
                    new Vector(35.7966378181818, -116.607317),
                    new Vector(35.8057008181819, -117.642173),
                    new Vector(35.8049808181818, -117.931046),
                    new Vector(35.7981858181818, -117.929831),
                    new Vector(35.7975468181819, -118.007519),
                    new Vector(35.7930558181819, -119.52977),
                    new Vector(35.7944328181818, -120.189083),
                    new Vector(35.7932538181818, -120.199235),
                    new Vector(35.8010388181818, -121.329086),
                    new Vector(35.6635368181819, -121.270271),
                    new Vector(35.6293188181818, -121.146566),
                    new Vector(35.4565818181819, -120.991946),
                    new Vector(35.4277638181819, -120.875207),
                    new Vector(35.3645388181818, -120.849998),
                    new Vector(35.2594098181819, -120.883604),
                    new Vector(35.2092528181818, -120.861347),
                    new Vector(35.1400248181819, -120.638417),
                    new Vector(35.0748198181819, -120.616763),
                    new Vector(34.9726338181818, -120.644339),
                    new Vector(34.9038108181818, -120.665948),
                    new Vector(34.8556158181819, -120.608159),
                    new Vector(34.7599098181819, -120.631676),
                    new Vector(34.7040198181818, -120.601616),
                    new Vector(34.5723408181819, -120.641288),
                    new Vector(34.5213738181818, -120.509411),
                    new Vector(34.4424978181819, -120.456203),
                    new Vector(34.4719008181818, -120.140168),
                    new Vector(34.4616678181819, -120.011495),
                    new Vector(34.4047968181818, -119.869439),
                    new Vector(34.4164338181819, -119.606288),
                    new Vector(34.3748628181818, -119.483015),
                    new Vector(34.2380988181818, -119.266763),
                    new Vector(34.1463348181819, -119.216336),
                    new Vector(34.0400808181818, -118.939361),
                    new Vector(34.0182558181818, -118.788116),
                    new Vector(34.0372548181819, -118.541858),
                    new Vector(33.882967818182, -118.412105),
                    new Vector(33.8123268181818, -118.388174),
                    new Vector(33.7754448181818, -118.428953),
                    new Vector(33.7384548181819, -118.405094),
                    new Vector(33.7039128181818, -118.286888),
                    new Vector(33.7739238181819, -118.246622),
                    new Vector(33.7475628181818, -118.106717),
                    new Vector(33.7623498181819, -118.087889),
                    new Vector(33.7941378181818, -118.091642),
                    new Vector(33.8102928181819, -118.065353),
                    new Vector(33.8627898181819, -118.042286),
                    new Vector(33.8807898181819, -118.012649),
                    new Vector(33.8832378181819, -117.99221),
                    new Vector(33.8982678181819, -117.990185),
                    new Vector(33.9138738181819, -117.971573),
                    new Vector(33.9447978181819, -117.970295),
                    new Vector(33.9507648181819, -117.78323),
                    new Vector(33.880960818182, -117.677408),
                    new Vector(33.9041268181819, -117.680936),
                    new Vector(33.9056388181819, -117.655493),
                    new Vector(33.9265638181818, -117.653468),
                    new Vector(33.9286248181818, -117.608081),
                    new Vector(33.9731928181819, -117.605651),
                    new Vector(33.9920838181819, -117.554846),
                    new Vector(34.0334478181819, -117.554594),
                    new Vector(34.0346358181819, -117.372785),
                    new Vector(34.0205418181818, -117.371606),
                    new Vector(34.0182018181818, -117.223079),
                    new Vector(34.0072938181818, -117.22361),
                    new Vector(34.0056558181818, -116.924405),
                    new Vector(34.0347528181819, -116.924918),
                    new Vector(34.0333938181818, -115.973249),
                    new Vector(34.0406568181818, -115.312343),
                    new Vector(34.0779258181819, -115.312091),
                    new Vector(34.0783398181819, -114.424025)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(34.0752258181818, -119.867828),
                    new Vector(34.0591788181819, -119.927687),
                    new Vector(34.0318728181817, -119.873984),
                    new Vector(34.0046748181819, -119.889068),
                    new Vector(33.9684138181819, -119.847272),
                    new Vector(33.9652818181819, -119.712533),
                    new Vector(34.0065018181818, -119.539373),
                    new Vector(34.0345908181819, -119.523092),
                    new Vector(34.0557858181818, -119.572592),
                    new Vector(34.0213428181818, -119.66792),
                    new Vector(34.0752258181818, -119.867828)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.9241608181818, -120.167384),
                    new Vector(33.8948208181819, -120.10919),
                    new Vector(33.9477678181819, -119.96339),
                    new Vector(34.0411068181818, -120.046802),
                    new Vector(34.0108848181818, -120.238547),
                    new Vector(33.9241608181818, -120.167384)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.4808208181818, -118.594769),
                    new Vector(33.4344798181818, -118.556438),
                    new Vector(33.4195578181819, -118.481342),
                    new Vector(33.3247788181819, -118.455395),
                    new Vector(33.3074898181819, -118.304033),
                    new Vector(33.3344448181818, -118.294601),
                    new Vector(33.4110078181818, -118.362398),
                    new Vector(33.4808208181818, -118.594769)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(32.8191948181819, -118.350959),
                    new Vector(32.9873778181819, -118.541579),
                    new Vector(33.0359688181817, -118.571486),
                    new Vector(33.0210198181819, -118.599521),
                    new Vector(32.8920768181819, -118.511681),
                    new Vector(32.8061178181819, -118.420106),
                    new Vector(32.8191948181819, -118.350959)
                })
            }
        };
    }
}