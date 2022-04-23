using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_West_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3739;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wyoming West";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Wyoming West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-110.0833333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,3739],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Wyoming West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-110.0833333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-111.048701, 41.9961978181819, 0),
                    new Vector(-111.051077, 41.5785888181818, 0),
                    new Vector(-111.051653, 41.2584228181818, 0),
                    new Vector(-111.051023, 40.9965858181819, 0),
                    new Vector(-110.063183, 40.9978908181819, 0),
                    new Vector(-110.065964, 41.4074358181819, 0),
                    new Vector(-110.051375, 41.4090378181819, 0),
                    new Vector(-110.053391, 41.5822158181819, 0),
                    new Vector(-110.054588, 42.2665128181818, 0),
                    new Vector(-109.046543, 42.262849818182, 0),
                    new Vector(-109.046309, 42.4393848181819, 0),
                    new Vector(-109.072472, 42.439726818182, 0),
                    new Vector(-109.071356, 42.7055598181819, 0),
                    new Vector(-109.129442, 42.7055598181819, 0),
                    new Vector(-109.159934, 42.7457808181817, 0),
                    new Vector(-109.204772, 42.7685778181819, 0),
                    new Vector(-109.238378, 42.7663278181819, 0),
                    new Vector(-109.242473, 42.7789098181819, 0),
                    new Vector(-109.231673, 42.8016528181818, 0),
                    new Vector(-109.309658, 42.8476788181819, 0),
                    new Vector(-109.372901, 42.9443748181819, 0),
                    new Vector(-109.396094, 42.9443298181819, 0),
                    new Vector(-109.512374, 43.0105338181818, 0),
                    new Vector(-109.558364, 43.0204248181819, 0),
                    new Vector(-109.556024, 43.0382898181819, 0),
                    new Vector(-109.580315, 43.0978518181819, 0),
                    new Vector(-109.624217, 43.1351658181819, 0),
                    new Vector(-109.628951, 43.1545428181819, 0),
                    new Vector(-109.659092, 43.1769438181819, 0),
                    new Vector(-109.668047, 43.1938818181819, 0),
                    new Vector(-109.683482, 43.2816138181819, 0),
                    new Vector(-109.674725, 43.3052478181818, 0),
                    new Vector(-109.693751, 43.3294938181819, 0),
                    new Vector(-109.693499, 43.3568538181819, 0),
                    new Vector(-109.705577, 43.3654488181818, 0),
                    new Vector(-109.747688, 43.3636128181819, 0),
                    new Vector(-109.75064, 43.368490818182, 0),
                    new Vector(-109.748597, 43.4647728181818, 0),
                    new Vector(-110.053868, 43.4652048181818, 0),
                    new Vector(-110.057621, 44.0079858181819, 0),
                    new Vector(-110.058008, 44.1339678181818, 0),
                    new Vector(-110.094944, 44.1400248181819, 0),
                    new Vector(-110.107283, 44.1495108181818, 0),
                    new Vector(-110.115077, 44.1651348181819, 0),
                    new Vector(-110.1092, 44.1850338181818, 0),
                    new Vector(-110.117606, 44.1933228181818, 0),
                    new Vector(-110.108525, 44.1987768181818, 0),
                    new Vector(-110.112341, 44.2127448181819, 0),
                    new Vector(-110.135489, 44.2354338181819, 0),
                    new Vector(-110.15438, 44.2957608181818, 0),
                    new Vector(-110.181578, 44.3063718181819, 0),
                    new Vector(-110.192837, 44.3035638181819, 0),
                    new Vector(-110.20766, 44.3257218181819, 0),
                    new Vector(-110.22071, 44.3283048181819, 0),
                    new Vector(-110.235461, 44.3774088181819, 0),
                    new Vector(-110.295941, 44.4284748181819, 0),
                    new Vector(-110.28659, 44.5002048181819, 0),
                    new Vector(-110.310611, 44.5443138181818, 0),
                    new Vector(-110.342021, 44.5437468181819, 0),
                    new Vector(-110.370416, 44.5519818181819, 0),
                    new Vector(-110.374529, 44.5819518181818, 0),
                    new Vector(-110.668613, 44.5794678181819, 0),
                    new Vector(-110.668352, 44.661313818182, 0),
                    new Vector(-111.051617, 44.6644908181819, 0),
                    new Vector(-111.051563, 44.4733308181818, 0),
                    new Vector(-111.050411, 43.9825518181819, 0),
                    new Vector(-111.046775, 43.5155238181818, 0),
                    new Vector(-111.047504, 43.2847368181819, 0),
                    new Vector(-111.049214, 43.0198848181819, 0),
                    new Vector(-111.046784, 42.503257818182, 0),
                    new Vector(-111.048701, 41.9961978181819, 0)
                })
            }
        };
    }
}