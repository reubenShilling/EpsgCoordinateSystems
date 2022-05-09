using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_West_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3739;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Wyoming West";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Wyoming West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-110.0833333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,3739],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Wyoming West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-110.0833333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.9961978181819, -111.048701),
                    new Vector(41.5785888181818, -111.051077),
                    new Vector(41.2584228181818, -111.051653),
                    new Vector(40.9965858181819, -111.051023),
                    new Vector(40.9978908181819, -110.063183),
                    new Vector(41.4074358181819, -110.065964),
                    new Vector(41.4090378181819, -110.051375),
                    new Vector(41.5822158181819, -110.053391),
                    new Vector(42.2665128181818, -110.054588),
                    new Vector(42.262849818182, -109.046543),
                    new Vector(42.4393848181819, -109.046309),
                    new Vector(42.439726818182, -109.072472),
                    new Vector(42.7055598181819, -109.071356),
                    new Vector(42.7055598181819, -109.129442),
                    new Vector(42.7457808181817, -109.159934),
                    new Vector(42.7685778181819, -109.204772),
                    new Vector(42.7663278181819, -109.238378),
                    new Vector(42.7789098181819, -109.242473),
                    new Vector(42.8016528181818, -109.231673),
                    new Vector(42.8476788181819, -109.309658),
                    new Vector(42.9443748181819, -109.372901),
                    new Vector(42.9443298181819, -109.396094),
                    new Vector(43.0105338181818, -109.512374),
                    new Vector(43.0204248181819, -109.558364),
                    new Vector(43.0382898181819, -109.556024),
                    new Vector(43.0978518181819, -109.580315),
                    new Vector(43.1351658181819, -109.624217),
                    new Vector(43.1545428181819, -109.628951),
                    new Vector(43.1769438181819, -109.659092),
                    new Vector(43.1938818181819, -109.668047),
                    new Vector(43.2816138181819, -109.683482),
                    new Vector(43.3052478181818, -109.674725),
                    new Vector(43.3294938181819, -109.693751),
                    new Vector(43.3568538181819, -109.693499),
                    new Vector(43.3654488181818, -109.705577),
                    new Vector(43.3636128181819, -109.747688),
                    new Vector(43.368490818182, -109.75064),
                    new Vector(43.4647728181818, -109.748597),
                    new Vector(43.4652048181818, -110.053868),
                    new Vector(44.0079858181819, -110.057621),
                    new Vector(44.1339678181818, -110.058008),
                    new Vector(44.1400248181819, -110.094944),
                    new Vector(44.1495108181818, -110.107283),
                    new Vector(44.1651348181819, -110.115077),
                    new Vector(44.1850338181818, -110.1092),
                    new Vector(44.1933228181818, -110.117606),
                    new Vector(44.1987768181818, -110.108525),
                    new Vector(44.2127448181819, -110.112341),
                    new Vector(44.2354338181819, -110.135489),
                    new Vector(44.2957608181818, -110.15438),
                    new Vector(44.3063718181819, -110.181578),
                    new Vector(44.3035638181819, -110.192837),
                    new Vector(44.3257218181819, -110.20766),
                    new Vector(44.3283048181819, -110.22071),
                    new Vector(44.3774088181819, -110.235461),
                    new Vector(44.4284748181819, -110.295941),
                    new Vector(44.5002048181819, -110.28659),
                    new Vector(44.5443138181818, -110.310611),
                    new Vector(44.5437468181819, -110.342021),
                    new Vector(44.5519818181819, -110.370416),
                    new Vector(44.5819518181818, -110.374529),
                    new Vector(44.5794678181819, -110.668613),
                    new Vector(44.661313818182, -110.668352),
                    new Vector(44.6644908181819, -111.051617),
                    new Vector(44.4733308181818, -111.051563),
                    new Vector(43.9825518181819, -111.050411),
                    new Vector(43.5155238181818, -111.046775),
                    new Vector(43.2847368181819, -111.047504),
                    new Vector(43.0198848181819, -111.049214),
                    new Vector(42.503257818182, -111.046784),
                    new Vector(41.9961978181819, -111.048701)
                })
            }
        };
    }
}