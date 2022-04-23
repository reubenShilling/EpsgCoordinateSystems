using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_West_Central_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3738;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wyoming West Central";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Wyoming West Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-108.75],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,3738],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Wyoming West Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-108.75],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-107.52431, 42.2590608181818, 0),
                    new Vector(-107.524184, 42.4404738181819, 0),
                    new Vector(-107.545343, 42.440806818182, 0),
                    new Vector(-107.539124, 42.7825368181818, 0),
                    new Vector(-107.500388, 42.7826718181818, 0),
                    new Vector(-107.501918, 43.1339148181819, 0),
                    new Vector(-107.517623, 43.1339598181819, 0),
                    new Vector(-107.516615, 43.4708928181819, 0),
                    new Vector(-107.534975, 43.4717748181819, 0),
                    new Vector(-107.534768, 43.5045618181818, 0),
                    new Vector(-107.596706, 43.5056148181819, 0),
                    new Vector(-107.595185, 43.6450428181818, 0),
                    new Vector(-107.715488, 43.6462758181819, 0),
                    new Vector(-107.714399, 43.7310468181819, 0),
                    new Vector(-107.950766, 43.7310288181819, 0),
                    new Vector(-107.949911, 43.8148998181819, 0),
                    new Vector(-108.168899, 43.8159348181819, 0),
                    new Vector(-108.188213, 43.8308208181818, 0),
                    new Vector(-108.18599, 43.8463908181819, 0),
                    new Vector(-108.321872, 43.8465798181819, 0),
                    new Vector(-108.322304, 43.9035588181819, 0),
                    new Vector(-108.432968, 43.9049088181819, 0),
                    new Vector(-108.431753, 43.9938648181818, 0),
                    new Vector(-108.499928, 43.9952148181819, 0),
                    new Vector(-108.50108, 44.0800128181819, 0),
                    new Vector(-108.558482, 44.0807868181818, 0),
                    new Vector(-108.557312, 44.1679518181818, 0),
                    new Vector(-108.57902, 44.1681228181818, 0),
                    new Vector(-108.578984, 44.527303818182, 0),
                    new Vector(-108.592475, 44.5277538181819, 0),
                    new Vector(-108.599324, 44.8641378181819, 0),
                    new Vector(-108.62312, 44.8633098181818, 0),
                    new Vector(-108.625253, 44.997589818182, 0),
                    new Vector(-109.799384, 44.9995158181818, 0),
                    new Vector(-109.99553, 45.0027918181819, 0),
                    new Vector(-110.392763, 44.9986248181818, 0),
                    new Vector(-110.429645, 44.9922798181819, 0),
                    new Vector(-111.053426, 44.9956908181819, 0),
                    new Vector(-111.051617, 44.6644908181819, 0),
                    new Vector(-110.668352, 44.661313818182, 0),
                    new Vector(-110.668613, 44.5794678181819, 0),
                    new Vector(-110.374529, 44.5819518181818, 0),
                    new Vector(-110.370416, 44.5519818181819, 0),
                    new Vector(-110.342021, 44.5437468181819, 0),
                    new Vector(-110.310611, 44.5443138181818, 0),
                    new Vector(-110.28659, 44.5002048181819, 0),
                    new Vector(-110.295941, 44.4284748181819, 0),
                    new Vector(-110.235461, 44.3774088181819, 0),
                    new Vector(-110.22071, 44.3283048181819, 0),
                    new Vector(-110.20766, 44.3257218181819, 0),
                    new Vector(-110.192837, 44.3035638181819, 0),
                    new Vector(-110.181578, 44.3063718181819, 0),
                    new Vector(-110.15438, 44.2957608181818, 0),
                    new Vector(-110.135489, 44.2354338181819, 0),
                    new Vector(-110.112341, 44.2127448181819, 0),
                    new Vector(-110.108525, 44.1987768181818, 0),
                    new Vector(-110.117606, 44.1933228181818, 0),
                    new Vector(-110.1092, 44.1850338181818, 0),
                    new Vector(-110.115077, 44.1651348181819, 0),
                    new Vector(-110.107283, 44.1495108181818, 0),
                    new Vector(-110.094944, 44.1400248181819, 0),
                    new Vector(-110.058008, 44.1339678181818, 0),
                    new Vector(-110.057621, 44.0079858181819, 0),
                    new Vector(-110.053868, 43.4652048181818, 0),
                    new Vector(-109.748597, 43.4647728181818, 0),
                    new Vector(-109.75064, 43.368490818182, 0),
                    new Vector(-109.747688, 43.3636128181819, 0),
                    new Vector(-109.705577, 43.3654488181818, 0),
                    new Vector(-109.693499, 43.3568538181819, 0),
                    new Vector(-109.693751, 43.3294938181819, 0),
                    new Vector(-109.674725, 43.3052478181818, 0),
                    new Vector(-109.683482, 43.2816138181819, 0),
                    new Vector(-109.668047, 43.1938818181819, 0),
                    new Vector(-109.659092, 43.1769438181819, 0),
                    new Vector(-109.628951, 43.1545428181819, 0),
                    new Vector(-109.624217, 43.1351658181819, 0),
                    new Vector(-109.580315, 43.0978518181819, 0),
                    new Vector(-109.556024, 43.0382898181819, 0),
                    new Vector(-109.558364, 43.0204248181819, 0),
                    new Vector(-109.512374, 43.0105338181818, 0),
                    new Vector(-109.396094, 42.9443298181819, 0),
                    new Vector(-109.372901, 42.9443748181819, 0),
                    new Vector(-109.309658, 42.8476788181819, 0),
                    new Vector(-109.231673, 42.8016528181818, 0),
                    new Vector(-109.242473, 42.7789098181819, 0),
                    new Vector(-109.238378, 42.7663278181819, 0),
                    new Vector(-109.204772, 42.7685778181819, 0),
                    new Vector(-109.159934, 42.7457808181817, 0),
                    new Vector(-109.129442, 42.7055598181819, 0),
                    new Vector(-109.071356, 42.7055598181819, 0),
                    new Vector(-109.072472, 42.439726818182, 0),
                    new Vector(-109.046309, 42.4393848181819, 0),
                    new Vector(-109.046543, 42.262849818182, 0),
                    new Vector(-110.054588, 42.2665128181818, 0),
                    new Vector(-110.053391, 41.5822158181819, 0),
                    new Vector(-110.051375, 41.4090378181819, 0),
                    new Vector(-110.065964, 41.4074358181819, 0),
                    new Vector(-110.063183, 40.9978908181819, 0),
                    new Vector(-110.002163, 40.9976028181819, 0),
                    new Vector(-109.048316, 40.9984398181819, 0),
                    new Vector(-107.918672, 41.0033718181819, 0),
                    new Vector(-107.916125, 41.4066528181819, 0),
                    new Vector(-107.936366, 41.4069588181818, 0),
                    new Vector(-107.935952, 41.6627298181818, 0),
                    new Vector(-107.524526, 41.6633058181818, 0),
                    new Vector(-107.526398, 41.7005118181818, 0),
                    new Vector(-107.509838, 41.7014118181819, 0),
                    new Vector(-107.506508, 42.0904638181819, 0),
                    new Vector(-107.524481, 42.0908778181819, 0),
                    new Vector(-107.52431, 42.2590608181818, 0)
                })
            }
        };
    }
}